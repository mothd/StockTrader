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
using Stock.Sqlite;
using Stock.Common;

namespace Stock.Trader.HuaTai
{
    /// <summary>
    /// 请求基类
    /// </summary>
    public class Request
    {
        public string uid { get; set; }

        public string cssweb_type { get; set; }

        public string version
        {
            get
            {
                return "1";
            }
        }

        public string custid { get; set; }

        public string op_branch_no { get; set; }

        public string branch_no { get; set; }

        public string op_entrust_way { get { return "7"; } }

        public string exchange_type { get; set; }

        public string function_id { get; set; } 

        public string fund_account { get; set; }

        public string password { get; set; }

        public string op_station { get; set; }

        public string identity_type
        {
            get
            {
                return "";
            }
        }

        public string ram
        {
            get
            {
                return StockUtil.RandomString;
            }
        }
    }

    /// <summary>
    /// 登录
    /// </summary>
    public class LoginPostRequest
    {
        public LoginPostRequest() { }

        public string userType
        {
            get
            {
                return "jy";
            }
        }
        public string loginEvent
        {
            get { return "1"; }
        }
        public string trdpwdEns
        {
            get;
            set;
        }

        public string macaddr { get; set; }
        public string hddInfo { get; set; }
        public string lipInfo { get; set; }
        public string topPath { get { return "null"; } }
        public string accountType
        {
            get { return "1"; }
        }
        public string userName
        {
            get;
            set;
        }
        public string servicePwd { get; set; }
        public string trdpwd
        {
            get;
            set;
        }
        public string vcode { get; set; }
    }

    /// <summary>
    /// 买股票
    /// </summary>
    public class StockBuyRequest : Request
    {
        // uid=153-0679-7959208&cssweb_type=STOCK_BUY&version=1&custid=666600&op_branch_no=17&
        // branch_no=17&op_entrust_way=7&op_station=IP$192.168.1.1;MAC$00-0C-29-1A-B4-32;HDD$                    &
        // function_id=302&fund_account=666600&password=ojCz+ofwfgred0kXNZv4/iTA$$&identity_type=&
        // exchange_type=1&stock_account=A763412369&stock_code=600717&entrust_amount=100&entrust_price=1&
        // entrust_prop=0&entrust_bs=1&ram=0.10738790780305862
        public StockBuyRequest() {
            this.cssweb_type = "STOCK_BUY";
            this.function_id = "302";
        }

        public int entrust_amount { get; set; }

        public int entrust_bs
        {
            get
            {
                return 1;
            }
        }

        public float entrust_price { get; set; }

        public int entrust_prop
        {
            get
            {
                return 0;
            }
        }

        public string stock_account { get; set; }

        public string stock_code { get; set; }

    }

    /// <summary>
    /// 卖股票
    /// </summary>
    public class StockSaleRequest : Request
    {
        // uid=153-1f64-7915165&cssweb_type=STOCK_SALE&version=1&custid=666600111111&op_branch_no=17&
        // branch_no=17&op_entrust_way=7&op_station=IP$183.206.203.123;MAC$00-0C-29-1A-B4-32;HDD$                    &
        // function_id=302&fund_account=666600111111&password=ojCz+oMyzH50kXNZv4/iTA$$&identity_type=&
        // exchange_type=1&stock_account=A763412369&stock_code=600717&entrust_amount=100&entrust_price=10&
        // entrust_prop=0&entrust_bs=2&ram=0.21561731165274978

        public StockSaleRequest()
        {
            cssweb_type = "STOCK_SELL";
            function_id = "302";
        }
        public int entrust_amount { get; set; }

        public int entrust_bs
        {
            get
            {
                return 2;
            }
        }

        public float entrust_price { get; set; }

        public int entrust_prop
        {
            get
            {
                return 0;
            }
        }

        public string stock_account { get; set; }

        public string stock_code { get; set; }
     
    }

    /// <summary>
    /// 查询可撤单列表
    /// </summary>
    public class GetCancelListRequest : Request
    {
        // uid=153-0679-7959208&cssweb_type=GET_CANCEL_LIST&version=1&custid=666600&op_branch_no=17&
        // branch_no=17&op_entrust_way=7&op_station=IP$192.168.1.1;MAC$00-0C-29-1A-B4-32;HDD$                    &
        // function_id=401&fund_account=666600&password=ojCz+grgw/iTA$$&identity_type=&exchange_type=&
        // stock_account=&stock_code=&locate_entrust_no=&query_direction=&sort_direction=0&request_num=100&
        // position_str=&ram=0.1280686566606164

        public GetCancelListRequest()
        {
            cssweb_type = "GET_CANCEL_LIST";
            function_id = "401";
        }

        public string stock_account { get; set; }
        public string stock_code { get; set; }
        public string locate_entrust_no {get{return "";} }
        public string query_direction { get{return "";}}
        public int sort_direction { get { return 0; } }
        public int request_num { get { return 100; } }
        public string position_str { get{return "";}}
    }

    /// <summary>
    /// 获取当日委托
    /// </summary>
    public class GetTodayEntrusterRequest : Request
    {
        // uid=152-107c-7090078&cssweb_type=GET_TODAY_ENTRUST&version=1&custid=666600001111&op_branch_no=17&
        // branch_no=17&op_entrust_way=7&op_station=IP$183.206.207.161;MAC$00-0C-29-1A-B4-32;HDD$                    &
        // function_id=401&fund_account=666600001111&password=ojCz+oMyzH00kXNZv4/iTA$$&identity_type=&
        // exchange_type=&stock_account=&stock_code=&locate_entrust_no=&query_direction=&sort_direction=0&
        // request_num=100&position_str=&ram=0.5542000429704785
        public GetTodayEntrusterRequest() {
            cssweb_type = "GET_TODAY_ENTRUST";
            function_id = "401";
        }
        public string stock_account { get; set; }
        public string stock_code { get; set; }
        public string locate_entrust_no { get; set; }
        public string query_direction { get; set; }
        public int sort_direction { get { return 0; } }
        public int request_num { get { return 100; } }
        public string position_str { get; set; }
    }

    /// <summary>
    /// 获取历史委托
    /// </summary>
    public class GetHistoryEntrusterRequest : Request
    {
        //uid=152-107c-7090078&cssweb_type=HISTORY_TRADE&version=1&custid=666600001111&op_branch_no=17&
        // branch_no=17&op_entrust_way=7&op_station=IP$183.206.207.161;MAC$00-0C-29-1A-B4-32;HDD$                    &
        // function_id=411&fund_account=666600001111&password=ojCz+oMyzH00kXNZv4/iTA$$&identity_type=&
        // start_date=20150918&end_date=20151019&exchange_type=&stock_account=&stock_code=&query_direction=1&
        // request_num=100&position_str=&ram=0.356126575730741
    }

    /// <summary>
    /// 撤销委托
    /// </summary>
    public class StockCancelRequest : Request
    {
        public StockCancelRequest()
        {
            cssweb_type = "STOCK_CANCEL";
            function_id = "304";
        }

        public string batch_flag
        {
            get
            {
                return "0";
            }
        }
        public string entrust_no { get; set; }

        // uid=153-759d-7924950&cssweb_type=STOCK_CANCEL&version=1&custid=666600111111&
        // op_branch_no=17&branch_no=17&op_entrust_way=7&op_station=IP$192.168.1.1;MAC$00-0D-27-1A-B4-32;HDD$                    &
        // function_id=304&fund_account=666600111111&password=ojCz+otgMyy5hf/iTA$$&
        // identity_type=&
        // batch_flag=0&exchange_type=&entrust_no=12140&ram=0.6111481911502779
    }

    /// <summary>
    /// 获取当日成交
    /// </summary>
    public class GetTodayTradeRequest : Request
    {
        // uid=153-0679-7959208&cssweb_type=GET_TODAY_TRADE&version=1&custid=666600&op_branch_no=17&
        // branch_no=17&op_entrust_way=7&op_station=IP$192.168.1.1;MAC$00-0C-29-1A-B4-32;HDD$                    &
        // function_id=402&fund_account=66660&password=ojCz+oMyy5hf/iTA$$&identity_type=&serial_no=&
        // exchange_type=&stock_account=&stock_code=&query_direction=1&request_num=100&query_mode=0&
        // position_str=&ram=0.8150487979874015

        public GetTodayTradeRequest()
        {
            cssweb_type = "GET_TODAY_TRADE";
            function_id = "402";
        }

        public string stock_account { get { return ""; } }
        public string stock_code { get { return ""; } }
        public string locate_entrust_no { get { return ""; } }
        public string query_direction { get { return "1"; } }
        public string serial_no { get { return ""; } }
        public int sort_direction { get { return 0; } }
        public int request_num { get { return 100; } }
        public string position_str { get { return ""; } }
        public string query_mode { get { return "0"; } }

    }

    /// <summary>
    /// 获取股票仓位
    /// </summary>
    public class GetStockPositionRequest : Request
    {
        // uid=153-0679-7959208&cssweb_type=GET_STOCK_POSITION&version=1&custid=666600&op_branch_no=17&
        // branch_no=17&op_entrust_way=7&op_station=IP$192.168.1.1;MAC$00-0C-29-1A-B4-32;HDD$                    &
        // function_id=403&fund_account=666600&password=ojCz+oMyy5hf/iTA$$&identity_type=&
        // exchange_type=&stock_account=&stock_code=&query_direction=&query_mode=0&request_num=100&
        // position_str=&ram=0.8974461741745472

        public GetStockPositionRequest()
        {
            cssweb_type = "GET_STOCK_POSITION";
            function_id = "403";
        }

        public string position_str{ get { return ""; } }
        public string query_direction { get { return ""; } }
        public int query_mode { get { return 0; } }
        public int request_num { get { return 100; } }
        public string stock_account { get { return ""; } }
        public string stock_code { get { return ""; } }

    }

    /// <summary>
    /// 获取资金信息
    /// </summary>
    public class GetFundsRequest : Request
    {
        // uid=153-0679-7959208&cssweb_type=GET_FUNDS&version=1&custid=666600&op_branch_no=17&
        // branch_no=17&op_entrust_way=7&op_station=IP$192.168.1.1;MAC$00-0C-29-1A-B4-32;HDD$                    &
        // function_id=405&fund_account=666600&password=ojCz+oMyy5hf/iTA$$&identity_type=&
        // money_type=&ram=0.911359122954309
        public GetFundsRequest()
        {
            cssweb_type = "GET_FUNDS";
            function_id = "405";
        }

        public string money_type { get { return ""; } }
    }

    public class FundGetJjszRequest : Request
    {
        public FundGetJjszRequest()
        {
            cssweb_type = "FUND_GET_JJSZ";
            function_id = "741";
        }
        // uid=153-0679-7959208&cssweb_type=FUND_GET_JJSZ&version=1&custid=666600&op_branch_no=17&
        // branch_no=17&op_entrust_way=7&op_station=IP$192.168.1.1;MAC$00-0C-29-1A-B4-32;HDD$                    &
        // function_id=7411&fund_account=666600&password=ojCz+oMyy5hf/iTA$$&identity_type=&
        // fund_company=&fund_code=&query_mode=0&ram=0.3891886440105736
        public string fund_company { get{return "";}}
        public string fund_code { get { return ""; } }
        public string query_mode { get { return "0"; } }
    }

}
