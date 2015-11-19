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

namespace Stock.Formula
{
    public class AbstractFormula
    {
        private IList<IStockData> stocks;

        public AbstractFormula(string code)
        {

        }

        public AbstractFormula()
        {
        }

        #region 行情函数

        public ValueList OPEN
        {
            get {return new ValueList(from it in this.stocks select it.Open);}
        }

        public ValueList O
        {
            get { return OPEN; }
        }

        public ValueList CLOSE
        {
            get { return new ValueList(from it in this.stocks select it.Close); }
        }

        public ValueList C
        {
            get { return CLOSE; }
        }

        public  ValueList HIGH
        {
            get { return new ValueList(from it in this.stocks select it.High); }
        }

        public  ValueList H
        {
            get { return HIGH; }
        }

        public ValueList LOW
        {
            get { return new ValueList(from it in this.stocks select it.Low); }
        }

        public ValueList L
        {
            get { return LOW; }
        }

        public ValueList VOL
        {
            get { return new ValueList(from it in this.stocks select it.Volume); }
        }

        public ValueList AMOUNT
        {
            get { return new ValueList(from it in this.stocks select it.Amount); }
        }

        public ValueList V
        {
            get { return VOL; }
        }

        public ValueList ADVANCE
        {
            get { return null; }
        }

        public ValueList DECLINE
        {
            get { return null; }
        }

        #endregion

        #region 引用函数

        public ValueList REF(ValueList X, int A) {
            return null;
        }

        public ValueList SUM(ValueList X, int N)
        {
            return null;
        }

        /// <summary>
        /// 移动平均线， (X1+X2+X3+...+Xn)/N
        /// </summary>
        /// <param name="X"></param>
        /// <param name="M"></param>
        /// <returns></returns>
        public ValueList MA(ValueList X, int M)
        {
            float[] Y = new float[X.Count];
            for (int i = 0; i < X.Count; i++)
            {
                int skip = i - M + 1;
                Y[i] = X.Skip<float>(skip).Take<float>(M).Average();
            }
            return new ValueList(Y);
        }

        /// <summary>
        /// 若Y=SMA(X,N,M)，则 Y=[M*X+(N-M)*Y']/N,其中Y'表示上一周期Y值,N必须大于M。
        /// </summary>
        /// <param name="X"></param>
        /// <param name="N"></param>
        /// <param name="M"></param>
        /// <returns></returns>
        public ValueList SMA(ValueList X, int N, int M)
        {

            float[] Y = new float[X.Count];
            Y[0] = X[0];
            for (int i = 1; i < X.Count; i++)
            {
                float Y1 = Y[i - 1];
                Y[i] = (M * X[i] + (N - M) * Y1) / N;
            }
            return new ValueList(Y);
        }

        public ValueList EXPMA(ValueList X, int M)
        {
            return EMA(X, M);
        }

        /// <summary>
        /// 若Y=EMA(X,N)，则Y=[2*X+(N-1)*Y']/(N+1),其中Y'表示上一周期Y值。
        /// </summary>
        /// <param name="X"></param>
        /// <param name="N"></param>
        /// <returns></returns>
        public ValueList EMA(ValueList X, int N)
        {
            float[] Y = new float[X.Count];
            Y[0] = X[0];
            for (int i = 1; i < X.Count; i++)
            {
                float Y1 = Y[i - 1];
                Y[i] = (2 * X[i] + (N - 1) * Y1) / (N+1);
            }
            return new ValueList(Y);
        }

        public ValueList MEMA(ValueList X, int M)
        {
            return null;
        }

        public ValueList EXPMEMA(ValueList X, int M)
        {
            return null;
        }

        /// <summary>
        /// 若Y=DMA(X,A)，则 Y=A*X+(1-A)*Y',其中Y'表示上一周期Y值,A必须小于1。
        /// </summary>
        /// <param name="X"></param>
        /// <param name="M"></param>
        /// <returns></returns>
        public ValueList DMA(ValueList X, float A)
        {
            float[] Y = new float[X.Count];
            Y[0] = X[0];
            for (int i = 1; i < X.Count; i++)
            {
                float Y1 = Y[i - 1];
                Y[i] = A * X[i] + (1 - A) * Y1;
            }

            return new ValueList(Y);
        }

        public ValueList HHV
        {
            get { return null; }
        }

        public ValueList LLV
        {
            get { return null; }
        }

        #endregion

        #region 逻辑函数

        public bool CROSS(ValueList A, ValueList B)
        {
            return false;
        }

        public bool LONGCROSS(ValueList A, ValueList B, int N)
        {
            return false;
        }

        public bool UPNDAY(ValueList CLOSE, int M)
        {
            return false;
        }

        public bool DOWNNDAY(ValueList CLOSE, int M)
        {
            return false;
        }

        #endregion

        #region 统计函数

        /// <summary>
        /// 平均绝对方差
        /// </summary>
        /// <param name="X"></param>
        /// <param name="N"></param>
        /// <returns></returns>
        public ValueList AVEDEV(ValueList X, int N)
        {
            return null;
        }

        /// <summary>
        /// 数据偏差平方和
        /// </summary>
        /// <param name="X"></param>
        /// <param name="N"></param>
        /// <returns></returns>
        public ValueList DEVSQ(ValueList X, int N)
        {
            return null;
        }

        /// <summary>
        /// 估算标准差
        /// </summary>
        /// <param name="X"></param>
        /// <param name="N"></param>
        /// <returns></returns>
        public ValueList STD(ValueList X, int N)
        {
            return null;
        }

        /// <summary>
        /// 总体标准差
        /// </summary>
        /// <param name="X"></param>
        /// <param name="N"></param>
        /// <returns></returns>
        public ValueList STDP(ValueList X, int N)
        {
            return null;
        }

        /// <summary>
        /// 线性回归预测值
        /// </summary>
        /// <param name="X"></param>
        /// <param name="N"></param>
        /// <returns></returns>
        public ValueList FORCAST(ValueList X, int N)
        {
            return null;
        }

        /// <summary>
        /// 估算样本方差
        /// </summary>
        /// <param name="X"></param>
        /// <param name="N"></param>
        /// <returns></returns>
        public ValueList VAR(ValueList X, int N)
        {
            return null;
        }

        /// <summary>
        /// 总体样本方差
        /// </summary>
        /// <param name="X"></param>
        /// <param name="N"></param>
        /// <returns></returns>
        public ValueList VARP(ValueList X, int N)
        {
            return null;
        }

        #endregion

        #region 形态函数
        #endregion
    }
}
