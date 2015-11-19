using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stock.Formula
{
    public class LCD : AbstractFormula, IFormula
    {
        private int k;
        public LCD(int K)
        {
            this.k = K;
        }

        public ValueList Calculate()
        {
            ValueList 移均 = MA(CLOSE, 2);
            ValueList 均价 = EMA(SUM(AMOUNT, 0) / SUM(100 * VOL, 0), 2);
            ValueList 加速度 = 3000 * MA((均价 - REF(均价, 1)), 2);
            ValueList 动差 = (移均 - 均价);
            ValueList 积 = EMA(40 * (加速度 * 动差 * 加速度), 3);

            return null;
        }
    }
}
