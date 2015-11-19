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

namespace Stock.Sqlite.Trader
{
    public interface IFundTrader
    {

        /// <summary>
        /// 申购基金 深圳
        /// </summary>
        /// <param name="code"></param>
        /// <param name="total"></param>
        /// <returns>合同号</returns>
        string PurchaseFundSZ(String code, float total);

        /// <summary>
        /// 赎回基金 深圳
        /// </summary>
        /// <param name="code">代码</param>
        /// <param name="num">份额</param>
        /// <returns>合同号</returns>
        string RedempteFundSZ(String code, int num);

        /// <summary>
        /// 合并子基金 深圳
        /// </summary>
        /// <param name="code">母鸡代码</param>
        /// <param name="num">合并数量</param>
        /// <returns>合同号</returns>
        string MergeFundSZ(String code, int num);

        /// <summary>
        /// 分拆母基金 深圳
        /// </summary>
        /// <param name="code">母鸡代码</param>
        /// <param name="num">分拆数量</param>
        /// <returns>合同号</returns>
        string PartFundSZ(String code, int num);


        /// <summary>
        /// 申购基金 上海
        /// </summary>
        /// <param name="code"></param>
        /// <param name="total"></param>
        /// <returns>合同号</returns>
        string PurchaseFundSH(String code, float total);

        /// <summary>
        /// 赎回基金 上海
        /// </summary>
        /// <param name="code">代码</param>
        /// <param name="num">份额</param>
        /// <returns>合同号</returns>
        string RedempteFundSH(String code, int num);

        /// <summary>
        /// 合并子基金 上海
        /// </summary>
        /// <param name="code">母鸡代码</param>
        /// <param name="num">合并数量</param>
        /// <returns>合同号</returns>
        string MergeFundSH(String code, int num);

        /// <summary>
        /// 分拆母基金 上海
        /// </summary>
        /// <param name="code">母鸡代码</param>
        /// <param name="num">分拆数量</param>
        /// <returns>合同号</returns>
        string PartFundSH(String code, int num);
    }
}
