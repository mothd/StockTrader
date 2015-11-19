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
using WebSocketSharp;
using Stock.Account.Settings;
using System.Threading;
using Stock.Sqlite;
using System.Windows.Forms;

namespace Stock.Common
{
    public class WSClient : IDisposable
    {
        public delegate void Received(string message);
        public event Received ReceivedRealTime;
        public event Received ReceivedAStock;
        public event Received Received5;
        public event Received Received15;
        public event Received Received30;
        public event Received Received60; 
        public event Received ReceivedDay;
        public event Received ReceivedFundNetValue;
        public event Received ReceivedFundIdxCons;
        public event Received ReceivedAllStrategy;
        public event Received ReceivedMyStrategy;


        public const string CMD_GET_A_STOCK_BID = "31";

        private static WSClient instance = new WSClient();
        public static WSClient Instance
        {
            get { return instance; }
        }

        private WebSocket wsChat = null;

        private System.Threading.Timer timer;
        private WSClient()
        {
            timer = new System.Threading.Timer(new TimerCallback(timerCall), this, 30000, 0);
        }

        private void timerCall(object obj)
        {
            if(wsChat.ReadyState == WebSocketState.Open)
                wsChat.Ping();
//            this.SendMessage("91: ping");
        }
 
        const string SERVER = "server";
        const string USERNAME = "username";
        const string PASSWORD = "password";

        showNotifyForm showForm = null;
        private EventHandler openHandler = null;
        private EventHandler<CloseEventArgs> closeHandler;
        private EventHandler<ErrorEventArgs> errorHandler;
        private EventHandler<MessageEventArgs> messageHandler;
        public void InitWebSocket()
        {
            // form.Show();
            showForm = ShowNotifyForm;

            wsChat = new WebSocket(String.Format("ws://{0}/websock/stockmarket", Configure.GetStockTraderItem(SERVER)));
            openHandler = new EventHandler(wsChat_OnOpen);
            wsChat.OnOpen += openHandler;
            closeHandler = new EventHandler<CloseEventArgs>(wsChat_OnClose);
            wsChat.OnClose += closeHandler;
            errorHandler = new EventHandler<ErrorEventArgs>(wsChat_OnError);
            wsChat.OnError += errorHandler;
            messageHandler = new EventHandler<MessageEventArgs>(wsChat_OnMessage);
            wsChat.OnMessage += messageHandler;
            connectServer();
        }

        public void SendMessage(String s)
        {
            if (wsChat == null) InitWebSocket();
            wsChat.SendAsync(s, null);
        }

        private void connectServer()
        {
            wsChat.Connect();
            login();
        }

        private void login()
        {
            SendMessage(String.Format("80:{0},{1}", Configure.GetStockTraderItem(USERNAME), Configure.GetStockTraderItem(PASSWORD)));
        }
        
        private void wsChat_OnMessage(object sender, MessageEventArgs e)
        {
            
            switch (e.Data.Substring(0, 2))
            {
                case "30":      // 实时
                    ReceivedRealTime(e.Data.Substring(3));
                    break;
                case "31":      // 获取一个股票的行情
                    ReceivedAStock(e.Data.Substring(3));
                    break;
                case "10":      // 策略列表
                    ReceivedAllStrategy(e.Data.Substring(3));
                   break;
                case "11":      // 我的策略
                   ReceivedMyStrategy(e.Data.Substring(3));
                    break;
                case "12":      // 保存我的策略
                    break;
                case "20":      // 5分钟线
                    Received5(e.Data);
                    break;
                case "21":      // 15分钟线
                    Received15(e.Data);
                    break;
                case "22":      // 30分钟线
                    Received30(e.Data);
                    break;
                case "23":      // 60分钟线
                    Received60(e.Data);
                    break;
                case "24":      // 日线
                    Received60(e.Data);
                    break;
                case "40":      // 基金净值
                    ReceivedFundNetValue(e.Data.Substring(3));
                    break;
                case "45":      // 基金指数的成分股
                    ReceivedFundIdxCons(e.Data.Substring(3));
                    break;
                case "71":
                    showForm.Invoke(e.Data.Substring(3));
                    break;
                    
                case "80":  // 登录
                case "90":  // 系统返回消息
                default:
                    // ShowNotifyForm(e.Data);
                    Console.WriteLine(e.Data);
                    break;
            }
        }

        private NotifyForm form = new NotifyForm();
        private delegate void showNotifyForm(string s);
        private void ShowNotifyForm(string s)
        {
            form.InvokeShow(s + " 时间为：" + DateTime.Now);
        }

        void wsChat_OnError(object sender, ErrorEventArgs e)
        {
            wsChat.OnOpen -= openHandler;
            wsChat.OnClose -= closeHandler;
            wsChat.OnError -= errorHandler;
            wsChat.OnMessage -= messageHandler;
            wsChat.Close();
            MessageBox.Show("链接服务器出错，1秒后重连");
            Thread.Sleep(1000);
            InitWebSocket();
        }

        void wsChat_OnClose(object sender, CloseEventArgs e)
        {
            Console.WriteLine(e.Reason);
        }

        void wsChat_OnOpen(object sender, EventArgs e)
        {
            Console.WriteLine("打开链接");
        }

        public void Close()
        {
            if (wsChat != null)
            {
                wsChat.Close();
                wsChat = null;
            }
        }

        public void Dispose()
        {
            Close();
        }
    }
}
