/*
 * This library is part of Stock Trader System
 *
 * Copyright (c) qiujoe (http://www.github.com/qiujoe)
 *
 * This library is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either
 * version 2.1 of the License, or (at your option) any later version.
 *
 * This library is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
 * Lesser General Public License for more details.
 *
 * For further information about StockTrader, please see the
 * project website: http://www.github.com/qiujoe/StockTrader
 *
 * You should have received a copy of the GNU Lesser General Public
 * License along with this library; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stock.Sqlite;
using System.Net;
using System.Threading;
using System.Diagnostics;
using Stock.Common;

namespace Stock.Market.Sina
{
    public class SinaStockMarketListener : StockMarketListener
    {
        private CookieContainer Cookie = new CookieContainer();

        private const string dataurl = "http://hq.sinajs.cn/list={0}";
        private HttpClient client = null;
        public SinaStockMarketListener()
        {
            client = new HttpClient(this.Cookie);
        }

        Thread listenThread = null;
        public override void Run()
        {
            listenThread = new Thread(new ThreadStart(internalRun));
            listenThread.Start();
        }

        private List<string> s_codes = new List<string>();
        private  void internalRun()
        {
            while (true)
            {
                Thread.Sleep(2000);
                bool isSent = false;
                int n = 150;
                if (s_codes.Count == 0 && codes.Count != 0)
                {
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < codes.Count; i++)
                    {
                        if ((i % n) < n)
                        {
                            isSent = false;
                            sb.Append(StockUtil.GetFullCode(codes[i]));
                            sb.Append(",");
                        }
                        if (i % n == (n - 1))
                        {
                            sb.Remove(sb.Length - 1, 1);
                            s_codes.Add(sb.ToString());
                            sb.Clear();
                            isSent = true;
                        }
                    }
                    if (!isSent)
                    {
                        sb.Remove(sb.Length - 1, 1);
                        s_codes.Add(sb.ToString());
                    }
                }

                foreach (string item in s_codes)
                {
                    sendRequest(item);
                }
            }
        }

        public override void Close()
        {
            if (this.listenThread != null)
            {
                this.listenThread.Abort();
            }
        }

        private void sendRequest(string t_codes)
        {
            //string address = String.Format(dataurl, String.Join(",", t_codes.ToArray()));
            // string address = String.Format(dataurl, t_codes);
            //Stopwatch watch = new Stopwatch();
            //watch.Start();
            //string resp = client.Get(address);
            string resp = client.Get(String.Format(dataurl, t_codes));
            if (resp == null)
            {
                Console.WriteLine("没有获取到数据");
                return;
            }
//            Console.WriteLine(resp);
            string[] data = resp.Split(new char[] { '\n' });
            Dictionary<string, Bid> dictionary2 = new Dictionary<string, Bid>();
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].Length != 0)
                {
                    Bid bid = Parse(data[i]);
                    StockMarketManager.AddBid(bid);
                    //if (bid.Code == "sz150153")
                    //    Console.WriteLine("当前时间{0}： 数据为{1}", DateTime.Now, data[i]);
                }
            }
            //Console.WriteLine("耗时{0}", watch.ElapsedMilliseconds);
            //client.DownloadString(address);
            //client.Timeout = 700;
            //client.DownloadStringAsyncWithTimeout(addr);
            //client.DownloadStringCompleted += new DownloadStringCompletedEventHandler(client_DownloadStringCompleted);
            //client.DownloadStringTimeout += new HttpClient.DownloadStringTimeoutEventHandler(client_DownloadStringTimeout);
            // string resp = client.DownloadString(address);
       }

        void client_DownloadStringTimeout(object sender)
        {
            
        }

        void client_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            if (e.Cancelled) return;
            string[] data = e.Result.Split(new char[] { '\n' });
            Dictionary<string, Bid> dictionary2 = new Dictionary<string, Bid>();
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].Length != 0)
                {
                    Bid bid = Parse(data[i]);
                    StockMarketManager.AddBid(bid);
                }
            }
        }

        const int BUY_1_A = 10;
        const int BUY_1_P = BUY_1_A + 1;
        const int BUY_2_A = BUY_1_P+1;
        const int BUY_2_P = BUY_2_A + 1;
        const int BUY_3_A = BUY_2_P + 1;
        const int BUY_3_P = BUY_3_A + 1;
        const int BUY_4_A = BUY_3_P + 1;
        const int BUY_4_P = BUY_4_A + 1;
        const int BUY_5_A = BUY_4_P + 1;
        const int BUY_5_P = BUY_5_A + 1;

        const int SELL_1_A = BUY_5_P + 1;
        const int SELL_1_P = SELL_1_A + 1;
        const int SELL_2_A = SELL_1_P + 1;
        const int SELL_2_P = SELL_2_A + 1;
        const int SELL_3_A = SELL_2_P + 1;
        const int SELL_3_P = SELL_3_A + 1;
        const int SELL_4_A = SELL_3_P + 1;
        const int SELL_4_P = SELL_4_A + 1;
        const int SELL_5_A = SELL_4_P + 1;
        const int SELL_5_P = SELL_5_A + 1;

        private Bid Parse(string data)
        {
            String[] items = data.Split(new char[] { ',' });
            if (items.Length < 10) return null;
            
            Bid bid = new Bid();

            bid.Code = data.Substring(11, 8);
            bid.Name = items[0].Substring(21, items[0].Length-21);    // var hq_str_sz150023="深成指B
            bid.Open = float.Parse(items[1]);
            bid.LastClose = float.Parse(items[2]);
            bid.CurrentPrice = float.Parse(items[3]);
            bid.High = float.Parse(items[4]);
            bid.Low = float.Parse(items[5]);
            //bid.Buy = decimal.Parse(items[6]);
            //bid.Sell = decimal.Parse(items[7]);
            bid.Volumn = long.Parse(items[8]);
            bid.Turnover = float.Parse(items[9]);

            bid.AddBuyGoodsData(new Bid.GoodsData(float.Parse(items[BUY_1_P]), int.Parse(items[BUY_1_A])));
            bid.AddBuyGoodsData(new Bid.GoodsData(float.Parse(items[BUY_2_P]), int.Parse(items[BUY_2_A])));
            bid.AddBuyGoodsData(new Bid.GoodsData(float.Parse(items[BUY_3_P]), int.Parse(items[BUY_3_A])));
            bid.AddBuyGoodsData(new Bid.GoodsData(float.Parse(items[BUY_4_P]), int.Parse(items[BUY_4_A])));
            bid.AddBuyGoodsData(new Bid.GoodsData(float.Parse(items[BUY_5_P]), int.Parse(items[BUY_5_A])));


            bid.AddSellGoodsData(new Bid.GoodsData(float.Parse(items[SELL_1_P]), int.Parse(items[SELL_1_A])));
            bid.AddSellGoodsData(new Bid.GoodsData(float.Parse(items[SELL_2_P]), int.Parse(items[SELL_2_A])));
            bid.AddSellGoodsData(new Bid.GoodsData(float.Parse(items[SELL_3_P]), int.Parse(items[SELL_3_A])));
            bid.AddSellGoodsData(new Bid.GoodsData(float.Parse(items[SELL_4_P]), int.Parse(items[SELL_4_A])));
            bid.AddSellGoodsData(new Bid.GoodsData(float.Parse(items[SELL_5_P]), int.Parse(items[SELL_5_A])));

            bid.PushTime = items[31];
            return bid;
        }
    }
}
