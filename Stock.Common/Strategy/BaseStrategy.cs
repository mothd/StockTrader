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
using Stock.Strategy;
using Stock.Sqlite;
using Stock.Market;
using System.Collections;
using Microsoft.Scripting.Hosting;
using Stock.Account;
using System.Windows.Forms;
using Stock.Strategy.Python;
using Stock.Account.Settings;
using System.Threading;
using Stock.Trader;
using Stock.Common;

namespace Stock.Strategy
{
    public abstract class BaseStrategy : IStrategy, IStockTrader, IControlOperation
    {
        private bool isValid = true;
        protected ICollection<string> stockPool = new List<string>();
        private IDictionary<String, BidCacheQueue> bids;

        protected StrategyControl control;

        public StrategyControl Control
        {
            get { return this.control; }
            set { this.control = value; }
        }

        public TradingAccount AccountInfo { get; set; }

        #region 实现策略描述接口

        public event StockRemoveHandler OnStockRemove;
        public event StockAddHandler OnStockAdd;

        public virtual void Run()
        {
            // 检测挂单是否成交，指定时间内未成交撤单
            //DateTime now = DateTime.Now;
            //int span = int.Parse(Configure.GetStockTraderItem(Configure.CANCEL_TIME_SPAN));

            //foreach (EntrustInfo item in entrustNos.Values)
            //{
            //    CancelStock(item.No);
            //}
        }

        public virtual void OnStockDataChanged(object sender, Stock.Market.Bid data)
        {
            // NOTHING TO DO
        }

        public virtual void OnTicket(object sender) { }

        public void AddStock(string code)
        {
            if (OnStockAdd != null)
                OnStockAdd(this, code);

            if(!stockPool.Contains(code))
                stockPool.Add(code);
        }

        public void RemoveStock(string code)
        {
            if (OnStockRemove != null)
                OnStockRemove(this, code);

            stockPool.Remove(code);
        }

        public int Id { get; set; }
        public abstract string Name
        {
            get;
        }

        public abstract string Description
        {
            get;
        }

        public bool Enabled
        {
            get
            {
                return this.isValid;
            }
            set
            {
                this.isValid = value;
            }
        }

        public String[] StockPool
        {
            get
            {
                return this.stockPool.ToArray<String>();
            }
        }

        #endregion

        public BaseStrategy()
        {
            try
            {
                control = CreateControl();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                throw e;
            }
        }

        protected virtual StrategyControl CreateControl()
        {
            return new StrategyControl(this);
        }

        /// <summary>
        /// 股票池中的盘口数据
        /// </summary>
        public IDictionary<String, BidCacheQueue> Bids
        {
            get
            {
                if (bids == null)
                {
                    bids = new Dictionary<String, BidCacheQueue>();
                    
                    foreach (string code in StockMarketManager.bidCache.Keys)
	                {
		                if(stockPool.Contains(code)) {
                            bids.Add(code, StockMarketManager.bidCache[code]);
                        }
	                }
                }
                return bids;
            }
        }

        #region 交易接口的实现

        IStockTrader trader = StockTraderManager.Instance.GetStockTrader();

        public virtual void Init()
        {
            // trader.Init();
        }

        public virtual TraderResult SellStock(string code, float price, int num)
        {
            LogHelper.WriteLog(this.GetType(),"BaseStrategy.SellStock");
            TraderResult result = trader.SellStock(code, price, num);
            switch (result.Code)
            {
                case TraderResultEnum.ERROR:
                    MessageBox.Show(result.Message);
                    break;
                case TraderResultEnum.SUCCESS:
                    AddEntrustNo(result.EntrustNo);
                    break;
            }
            WSClient.Instance.SendMessage(String.Format("SellStock(code {0}, price {1}, num {2})", code, price, num));
            return result;
        }

        public virtual TraderResult BuyStock(string code, float price, int num)
        {
            LogHelper.WriteLog(this.GetType(), "BaseStrategy.BuyStock");
            TraderResult result =trader.BuyStock(code, price, num);
            switch (result.Code)
            {
                case TraderResultEnum.ERROR:
                    MessageBox.Show(result.Message);
                    break;
                case TraderResultEnum.SUCCESS:
                    AddEntrustNo(result.EntrustNo);
                    break;
            }
            WSClient.Instance.SendMessage(String.Format("BuyStock(code {0}, price {1}, num {2})", code, price, num));
            return result;
        }

        public TraderResult CancelStock(int entrustNo)
        {
            LogHelper.WriteLog(this.GetType(), "BaseStrategy.CancelStock");
            TraderResult result = trader.CancelStock(entrustNo);
            switch (result.Code)
            {
                case TraderResultEnum.ERROR:
                    MessageBox.Show(result.Message);
                    break;
                case TraderResultEnum.SUCCESS:
                    AddEntrustNo(result.EntrustNo);
                    break;
            }
            WSClient.Instance.SendMessage(String.Format("CancelStock(entrustNo {0})", entrustNo));
            return result;
        }

        public TraderResult GetTodayTradeList()
        {
            LogHelper.WriteLog(this.GetType(), "BaseStrategy.GetTodayTradeList");
            return trader.GetTodayTradeList();
        }

        public TraderResult GetTodayEntrustList()
        {
            LogHelper.WriteLog(this.GetType(), "BaseStrategy.GetTodayEntrustList");
            return trader.GetTodayEntrustList();
        }

        public void Keep()
        {
            LogHelper.WriteLog(this.GetType(), "BaseStrategy.Keep");
            trader.Keep();
        }

        public virtual TraderResult GetTradingAccountInfo()
        {
            LogHelper.WriteLog(this.GetType(), "BaseStrategy.GetTradingAccountInfo");
            this.AccountInfo = (TradingAccount)trader.GetTradingAccountInfo().Result;
            return trader.GetTradingAccountInfo();
        }

        #endregion

        #region 控件操作接口

        public virtual void Setup()
        {
            // nothing to do
        }

        public virtual void ShowData()
        {
            // thing to do
        }

        public virtual void ImportPool()
        {
            // 
        }

        public virtual IList<StockData> LoadData()
        {
            // nothing to do
            return new List<StockData>();
        }

        #endregion

        #region 撤单相关部分
        protected IDictionary<int, EntrustInfo> entrustNos = new Dictionary<int, EntrustInfo>();
        protected class EntrustInfo
        {
            public int No;
            public DateTime Time;
        }

        private void AddEntrustNo(int entrustNo)
        {

            if(!entrustNos.ContainsKey(entrustNo))
                entrustNos.Add(entrustNo, new EntrustInfo { No = entrustNo, Time = DateTime.Now });
        }

        private void RemoveEntrustNo(int entrustNo)
        {
            entrustNos.Remove(entrustNo);
        }

        private void CancelEntrustJob()
        {
            // 1、获取成交列表
            TraderResult ret = this.GetTodayTradeList();
            TradingList list = (TradingList)ret.Result;

            // 2、从委托列表中移除已成交的部分
            // foreach (var item in list)
            //{
                
            //}
        }

        #endregion

        public delegate void SellStockHandler(string code, float price, int num);
        public event SellStockHandler sellStockEventHandler;

        //private delegate string SellStock(string code, float price, int num);
        //private void executeThreadWithTimeout(Action action, int timeoutMilliseconds)
        //{
        //    Thread threadToKill = null;
        //    Action wrappedAction = () =>
        //    {
        //        threadToKill = Thread.CurrentThread;
        //        action();
        //    };

        //    IAsyncResult result = wrappedAction.BeginInvoke(null, null);
        //    if (result.AsyncWaitHandle.WaitOne(timeoutMilliseconds))
        //    {
        //        wrappedAction.EndInvoke(result);
        //    }
        //    else
        //    {
        //        threadToKill.Abort();
        //        throw new TimeoutException();
        //    }
        //}
    }
}
