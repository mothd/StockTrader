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
    public class OperType
    {
        public const string BUY = "买入";
        public const string SELL = "卖出";
    }

    public class EntrustRecord
    {
        public virtual int Id { get; set; }
        public virtual int StrategyId { get; set; }
        public virtual String StockCode { get; set; }
        private string stockName = "";
        public virtual String StockName {
            get { return stockName; }
            set { stockName = value; }
        }

        public virtual string OperType { get; set; }
        public virtual int Amount { get; set; }
        public virtual float Price { get; set; }
        public virtual int TransactAmount { get; set; }
        public virtual float TransactPrice { get; set; }
        public virtual int No { get; set; }
        public virtual DateTime Date { get; set; }
    }

}