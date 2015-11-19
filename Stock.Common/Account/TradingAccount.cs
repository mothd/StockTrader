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

namespace Stock.Account
{
    /// <summary>
    /// 账户信息,包括
    /// <ol>
    ///     <li>资金信息</li>
    ///     <li>每个股票的市值,成本,手续费,佣金等信息</li>
    /// </ol>
    /// </summary>
    public class TradingAccount
    {
        public class FundInfo {
            public int MoneyType { get; set; }
            public string MoneyName { get; set; }
            public float CurrentBalance { get; set; }  // 资金余额
            public float EnableBalance { get; set; }   // 可用金额
            public float FetchBalance { get; set; }    //可取金额
            public float MarketValue { get; set; }     // 股票市值
            public float AssetBalance { get; set; }    // 总资产
        }


        private IList<StockHolderInfo> stockHolders = new List<StockHolderInfo>();

        public FundInfo fundInfo {get;set;}

        public StockHolderInfo[] StockHolders
        {
            get
            {
                return stockHolders.ToArray();
            }
        }

        public void AddStockHolder(StockHolderInfo shi)
        {
            this.stockHolders.Add(shi);
        }

        public void AddStockHolder(List<StockHolderInfo> shis)
        {
            foreach (StockHolderInfo shi in shis)
            {
                this.stockHolders.Add(shi);
            } 
        }
    }
}
