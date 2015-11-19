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
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stock.Sqlite;

namespace Stock.Strategy
{
    /// <summary>
    /// 管理策略
    /// </summary>
    public class StrategyManager
    {
        ICollection strategies = new ArrayList();

        private static StrategyManager instance = new StrategyManager();

        public static StrategyManager Instance
        {
            get { return instance; }
        }

        #region .ctor()
        private StrategyManager()
        {
        }
        #endregion

        /// <summary>
        ///  从服务器端读取所有的策略
        /// </summary>
        /// <returns></returns>
        public IStrategyDesc[] ReadAllStrategies()
        {
            return null;
        }

        ICollection<IStrategy> myStrategies = new List<IStrategy>();

        /// <summary>
        /// 读取个人用的策略
        /// </summary>
        /// <returns></returns>
        public IStrategy[] ReadMyStrategies()
        {
            return myStrategies.ToArray(); ;
        }

        /// <summary>
        /// 增加我的策略
        /// </summary>
        /// <param name="strategy"></param>
        public void AddMyStrategy(IStrategy strategy)
        {
            this.myStrategies.Add(strategy);

            // TODO: 保存
        }

        public IStrategy AddMyStrategy(String dllPath, String clazz)
        {
            IStrategy strategy = DllUtils.CreateInstance<IStrategy>(dllPath, clazz);
            this.AddMyStrategy(strategy);
            return strategy;
        }


        /// <summary>
        /// 删除我的策略
        /// </summary>
        /// <param name="strategy"></param>
        public void DeleteMyStrategy(IStrategy strategy)
        {
            
        }
    }
}
