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
using System.Collections;

using Stock.Strategy;
using System.Threading;
using Stock.Sqlite;
using Stock.Account.Settings;
using Stock.Common;

namespace Stock.Market
{
    public delegate void TicketHandler(object sender);

    public sealed class StockMarketManager
    {

        public static IDictionary<String, BidCacheQueue> bidCache = new Dictionary<String, BidCacheQueue>();
        private bool started = false;
        public event TicketHandler OnTicket;

        private System.Timers.Timer timer = null;
        public static StockMarketManager Instance = new StockMarketManager();

        private StockMarketManager()
        {
            int span = int.Parse(Configure.GetStockTraderItem(Configure.TICKET_TIME_SPAN));
            timer = new System.Timers.Timer(span);
        }

        /// <summary>
        /// 增加一个报价
        /// </summary>
        /// <param name="bid"></param>
        public static void AddBid(Bid bid) {
            if (bid == null) return;
            if (!bidCache.ContainsKey(bid.Code))
                bidCache.Add(bid.Code, new BidCacheQueue(bid.Code));

            bidCache[bid.Code].Enqueue(bid);
        }

        private void Timer_TimesUp(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (OnTicket != null)
            {
                OnTicket(this);
            }
        }


        private Thread listenThread;
        private StockMarketListener rsmt;
        /// <summary>
        /// 启动行情监听器
        /// </summary>
        public void Start()
        {
            if (started)
                throw new Exception();

            rsmt = DllUtils.CreateInstance<StockMarketListener>(Configure.GetCurrentMarketListener().Dll, Configure.GetCurrentMarketListener().ClazzName);
            foreach (string code in StockMarketManager.bidCache.Keys)
            {
                rsmt.AddStock(code);
            }
            rsmt.Init();
            rsmt.Run();
            //listenThread = new Thread(new ThreadStart(rsmt.Run));
            //listenThread.Start();

            timer.Start();
            timer.Elapsed += new System.Timers.ElapsedEventHandler(Timer_TimesUp);
        }

        public void Close()
        {
            if(rsmt != null)
                rsmt.Close();
        }

        /// <summary>
        /// 在行情市场中登记一个策略，每个ticket，调用一次策略。
        /// </summary>
        /// <param name="strategy">策略实例</param>
        public void RegisterStrategy(IStrategy strategy)
        {
            if (strategy.Enabled)
            {
                foreach (string s in strategy.StockPool)
                {
                    string code = StockUtil.GetFullCode(s);
                    if (!StockMarketManager.bidCache.ContainsKey(code))
                    {
                        StockMarketManager.bidCache.Add(code, new BidCacheQueue(code));
                    }
                    StockMarketManager.bidCache[code].OnBidChange += strategy.OnStockDataChanged;
                }

                // 调用策略
                this.OnTicket += strategy.OnTicket;
                strategy.Run();
            }
        }
       

    }
}
