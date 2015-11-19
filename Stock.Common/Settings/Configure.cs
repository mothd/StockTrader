using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Collections;

namespace Stock.Account.Settings
{
    public class Configure
    {
        public const String TICKET_TIME_SPAN = "Ticket.Time.Span";
        public const String KEEP_TIME_SPAN = "Keep.Time.Span";
        public const String CANCEL_TIME_SPAN = "Cancel.Time.Span";

        public const String FONT_SIZE = "font.size";
        public const String FONT_FAMILY = "font.family";
        public const string TRADE_FEE = "money.rate.fee";
        public const string TRADE_TAX = "money.rate.tax";

        public class Clazz
        {
            public String Dll {get; set;}
            public String ClazzName { get; set; }
        }

        public static Clazz GetCurrentStock()
        {
            IDictionary cs = (IDictionary)ConfigurationManager.GetSection("CurrentStock");
            return new Clazz
            {
                Dll = cs["dll"].ToString(),
                ClazzName = cs["clazz"].ToString()
            };
        }

        public static Clazz GetCurrentMarketListener()
        {
            IDictionary cs = (IDictionary)ConfigurationManager.GetSection("CurrentMarketListener");
            return new Clazz
            {
                Dll = cs["dll"].ToString(),
                ClazzName = cs["clazz"].ToString()
            };
        }

        public static String GetStockTraderItem(String key)
        {
            IDictionary cs = (IDictionary)ConfigurationManager.GetSection("StockTrader");
            if(cs.Contains(key))
                return cs[key].ToString();
            return null;
        }

    }
}
