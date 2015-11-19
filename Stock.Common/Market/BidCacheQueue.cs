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

namespace Stock.Market
{
    /// <summary>
    /// 股票价格队列, 当价格发生变动时,发送给观察者
    /// </summary>
    public class BidCacheQueue
    {
         /// <summary>
        /// 定义一个委托类型
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="bid"></param>
        public delegate void BidChangeHandler(object sender, Bid bid);
 
         /// <summary>定义一个事件</summary>
        public event BidChangeHandler OnBidChange;

        private Bid lastData;
        private Queue<Bid> queue = new Queue<Bid>();

        private String code = null;
        // private String name = null;

        public BidCacheQueue(String code)
        {
            this.code = code;
        }

        public String Code  { get {return code;} }
        // public String Name {get {return name;}}

        public Bid LastData
        {
            get {
                if (lastData == null)
                    lastData = new Bid();
                return lastData; 
            }
        }

        List<Bid> bids = new List<Bid>();
        public List<Bid> BidList
        {
            get { return this.bids; }
        }

        public void Enqueue(Bid obj)
        {
            bids.Insert(0, obj);
            queue.Enqueue(obj);
            lastData = obj;
            if (OnBidChange != null)
            {
                OnBidChange(this, obj);
            }
        }

        public Bid Dequeue()
        {
            return queue.Dequeue();
        }
    }
}
