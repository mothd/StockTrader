using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stock.Formula
{
    interface IStockData
    {
        string Code { get; set; }
        float Open { get; set; }
        float Close { get; set; }
        float High { get; set; }
        float Low { get; set; }
        float Volume { get; set; }
        float Amount { get; set; }

        DateTime PushTime { get; set; }
    }


}
