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

namespace Stock.Trader
{
    public abstract class BaseStockTrader : IStockTrader
    {
        public virtual void Init()
        {
            throw new NotImplementedException();
        }

        protected virtual void Login()
        {
        }

        public TraderResult SellStock(string code, float price, int num)
        {
            TraderResult ret = internalSellStock(code, price, num);
            switch (ret.Code)
            {
                case TraderResultEnum.TIMEOUT:
                    return SellStock(code, price, num);
                case TraderResultEnum.UNLOGIN:
                    Login();
                    return SellStock(code, price, num);
                case TraderResultEnum.ERROR:
                case TraderResultEnum.SUCCESS:
                    return ret;
                default:
                    return null;
            }
        }

        protected virtual TraderResult internalSellStock(string code, float price, int num)
        {
            return null;
        }

        public TraderResult BuyStock(string code, float price, int num)
        {
            TraderResult ret = internalBuyStock(code, price, num);
            switch (ret.Code)
            {
                case TraderResultEnum.TIMEOUT:
                    return BuyStock(code, price, num);
                case TraderResultEnum.UNLOGIN:
                    Login();
                    return BuyStock(code, price, num);
                case TraderResultEnum.ERROR:
                case TraderResultEnum.SUCCESS:
                    return ret;
                default:
                    return null;
            }
        }

        protected virtual TraderResult internalBuyStock(string code, float price, int num)
        {
            return null;
        }

        public TraderResult CancelStock(int entrustNo)
        {
            TraderResult ret = internalCancelStock(entrustNo);
            switch (ret.Code)
            {
                case TraderResultEnum.TIMEOUT:
                    return CancelStock(entrustNo);
                case TraderResultEnum.UNLOGIN:
                    Login();
                    return CancelStock(entrustNo);
                case TraderResultEnum.ERROR:
                case TraderResultEnum.SUCCESS:
                    return ret;
                default:
                    return null;
            }
        }

        protected virtual TraderResult internalCancelStock(int entrustNo)
        {
            return null;
        }

        public TraderResult GetTodayTradeList()
        {
            TraderResult ret = internalGetTodayTradeList();
            switch (ret.Code)
            {
                case TraderResultEnum.TIMEOUT:
                    return GetTodayTradeList();
                case TraderResultEnum.UNLOGIN:
                    Login();
                    return GetTodayTradeList();
                case TraderResultEnum.ERROR:
                case TraderResultEnum.SUCCESS:
                    return ret;
                default:
                    return null;
            }
        }

        protected virtual TraderResult internalGetTodayTradeList() {
            return null;
        }

        public TraderResult GetTodayEntrustList()
        {
            TraderResult ret = internalGetTodayEntrustList();
            switch (ret.Code)
            {
                case TraderResultEnum.TIMEOUT:
                    return GetTodayEntrustList();
                case TraderResultEnum.UNLOGIN:
                    Login();
                    return GetTodayEntrustList();
                case TraderResultEnum.ERROR:
                case TraderResultEnum.SUCCESS:
                    return ret;
                default:
                    return null;
            }
        }

        protected virtual TraderResult internalGetTodayEntrustList()
        {
            return null;
        }

        public void Keep()
        {
            internalKeep();
        }

        protected virtual void internalKeep()
        {
            return;
        }

        public TraderResult GetTradingAccountInfo()
        {
            TraderResult ret = internalGetTradingAccountInfo();
            switch (ret.Code)
            {
                case TraderResultEnum.TIMEOUT:
                    return GetTradingAccountInfo();
                case TraderResultEnum.UNLOGIN:
                    Login();
                    return GetTradingAccountInfo();
                case TraderResultEnum.ERROR:
                case TraderResultEnum.SUCCESS:
                    return ret;
                default:
                    return null;
            }
        }

        protected virtual TraderResult internalGetTradingAccountInfo()
        {
            return null;
        }


        public string PurchaseFundSZ(string code, float total)
        {
            throw new NotImplementedException();
        }

        public string RedempteFundSZ(string code, int num)
        {
            throw new NotImplementedException();
        }

        public string MergeFundSZ(string code, int num)
        {
            throw new NotImplementedException();
        }

        public string PartFundSZ(string code, int num)
        {
            throw new NotImplementedException();
        }

        public string PurchaseFundSH(string code, float total)
        {
            throw new NotImplementedException();
        }

        public string RedempteFundSH(string code, int num)
        {
            throw new NotImplementedException();
        }

        public string MergeFundSH(string code, int num)
        {
            throw new NotImplementedException();
        }

        public string PartFundSH(string code, int num)
        {
            throw new NotImplementedException();
        }
    }
}
