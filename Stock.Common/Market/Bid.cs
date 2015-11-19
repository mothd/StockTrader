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

namespace Stock.Market
{
    /// <summary>
    /// 股票盘口数据
    /// </summary>
    public class Bid
    {
        /// <summary>
        /// 每价格挂单的数据
        /// </summary>
        public class GoodsData
        {
            public float Price { get; set; }
            public int OrderAmount {get; set;}

            public GoodsData(float price, int amount)
            {
                Price = price;
                OrderAmount = amount;
            }

        }

        public String Code {get; set;}    // 证券代码
        public string Name { get; set; }    // 名称

        public float LastClose { get; set; }
        public float Open { get; set; }
        public float High { get; set; }
        public float Low { get; set; }

        public float CurrentPrice { get; set; }    // 成交价
        public long Volumn { get; set; }     // 成交量
        public float Turnover { get; set; }      // 成交金额
        public String PushTime{get; set;}  // 推送时间

        private ICollection<GoodsData> buyList = new List<GoodsData>();
        private ICollection<GoodsData> sellList = new List<GoodsData>();

        public GoodsData[] BuyList
        {
            get
            {
                if (buyList.Count == 0) return new GoodsData[5] { new GoodsData(0, 0), new GoodsData(0, 0), new GoodsData(0, 0), new GoodsData(0, 0), new GoodsData(0, 0) };
                return this.buyList.ToArray<GoodsData>();   
            }
        }

        public GoodsData[] SellList
        {
            get
            {
                if (sellList.Count == 0) return new GoodsData[5] { new GoodsData(0, 0), new GoodsData(0, 0), new GoodsData(0, 0), new GoodsData(0, 0), new GoodsData(0, 0)};

                return this.sellList.ToArray<GoodsData>();   
            }
        }

        public void AddBuyGoodsData(GoodsData data)
        {
            this.buyList.Add(data);
        }

        public void AddSellGoodsData(GoodsData data)
        {
            this.sellList.Add(data);
        }
    }
}
