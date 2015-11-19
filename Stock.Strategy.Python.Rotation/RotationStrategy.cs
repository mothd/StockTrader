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
using Microsoft.Scripting.Hosting;
using Stock.Strategy.Python;

namespace Stock.Strategy.Python.Rotation
{
    public class RotationStrategy : PythonStrategy
    {
        private int basePoint = 0;

        /// <summary>
        /// 基点
        /// </summary>
        public int BasePoint
        {
            get { return basePoint; }
            set { basePoint = value; }
        }

        public override string Name
        {
            get
            {
                return "分级A轮动模型";
            }
        }

        public override string Description
        {
            get
            {
                return "参照西胖子的轮动模型，本着轮动就是收益的目标。建议选择约定收益率一样的分级A 作为轮动标的,流动性非常好的标的。";
            }
        }

        public override void Run()
        {
            // 定时检查是否成功交易(买入卖出)
        }

        private float ComputeYhsyl(String code, float price)
        {
            return 0f;
        }

        public override void OnTicket(object sender)
        {
            scope.SetVariable("WeiTuo", this);// 将this Set 到Ipy脚本的WeiTuo值中
            scope.SetVariable("Bids", this.Bids);    // 多个股票的盘口数据
            scope.SetVariable("StockPool", this.StockPool); // 股票池
            scope.SetVariable("TradeAccount", this.GetTradingAccountInfo());   // 账户信息

            ScriptSource code = engine.CreateScriptSourceFromFile("e:\\projects\\test.py");
            // code.Execute(scope);
            Console.WriteLine("调用python策略");
        }

        public override void Setup()
        {
            new RotationStrategyForm(this).ShowDialog();
        }

        public override void Init()
        {
        }
    }
}
