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
using NHibernate;
using NHibernate.Cfg;
using System.Reflection;
using Stock.Account;
using NHibernate.Tool.hbm2ddl;

namespace Stock.Local.SqlLite.Hibernate
{
    public class SqliteHelper
    {
        private static SqliteHelper instance = new SqliteHelper();
        public static SqliteHelper Instance
        {
            get
            {
                return instance;
            }
        }

        ISessionFactory factory = null;
        Configuration configuration = null;

        public SqliteHelper()
        {
            try
            {
                configuration = new Configuration();
                configuration.Configure();
                configuration.AddAssembly(Assembly.GetExecutingAssembly());
                factory = configuration.BuildSessionFactory();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public void InitDatabase()
        {
            //try
            //{
            //    // Create the database schema
            //    new SchemaExport(configuration).Create(true, true);

                //    // insert record
                //    StrategyDesc sd1 = new StrategyDesc
                //    {
                //        Name = "强势B轮动策略",
                //        Desc = "强势B轮动策略",
                //        Dll = "Stock.Strategy.RotationB.dll",
                //        Clazz = "Stock.Strategy.RotationB.RotationBStrategy",
                //        Enabled = true,
                //        Group = 0,
                //        Date = DateTime.Now
                //    };
                //    Save<StrategyDesc>(sd1);

                //    sd1 = new StrategyDesc
                //    {
                //        Name = "ZH242749策略",
                //        Desc = "雪球跟踪策略",
                //        Dll = "Stock.Strategy.XueQiu.dll",
                //        Clazz = "Stock.Strategy.XueQiu.TraceXueQiuStrategy",
                //        Enabled = true,
                //        Group = 0,
                //        Date = DateTime.Now
                //    };
                //    Save<StrategyDesc>(sd1);

                //    SubTradingAccount sta = new SubTradingAccount
                //    {
                //        CurrentBalance = 50000,
                //        EnableBalance = 50000,
                //        FetchBalance = 50000,
                //        FrozenBalance = 0,
                //        MarketValue = 0,
                //        AssetBalance = 50000,
                //        Date = DateTime.Now,
                //        StrategyId = 2
                //    };
                //    Save<SubTradingAccount>(sta);

                //    StockHolderInfo shi = new StockHolderInfo
                //    {
                //        StockAccount = "",
                //        ExchangeName = "",
                //        KeepCostPrice = 0,
                //        StrategyId = 2,
                //        StockCode = "300001",
                //        StockName = "无",
                //        MarketValue = 10000,
                //        CostPrice = 7,
                //        CurrentAmount = 1000,
                //        EnableAmount = 500,
                //        IncomeAmount = 500,
                //        LastPrice = 10
                //    };
                //    Save<StockHolderInfo>(shi);

                //}
                //catch (Exception e)
                //{
                //    Console.WriteLine(e.StackTrace);
                //}
            }

        private ISession session = null;
        public ISession OpenSession()
        {
            if(session == null)
                session = factory.OpenSession();

            session.FlushMode = FlushMode.Always;
            return session;
        }

        public ISession Session
        {
            get { return this.session; }
        }

        public T Load<T>(int id)
        {
            T obj = session.Load<T>(id);
            return obj;          
        }

        public  void Save<T>(T obj)
        {
            session.Save(obj);
            session.Flush();
        }

        public void Update<T>(T obj)
        {
            session.Update(obj);
            session.Flush();
        }

        public void Delete<T>(T obj)
        {
            session.Delete(obj);
            session.Flush();
        }

        public void Delete<T>(int id)
        {
            T obj = session.Load<T>(id);
            session.Delete(obj);
            session.Flush();
        }

        public T Find<T>(String where)
        {
            IList<T>  objs = session.CreateQuery(where).List<T>();
            if (objs == null || objs.Count == 0) return default(T);

            return objs[0];
            //return default(T);
        }

        public IList<T> List<T>(string where)
        {
            try
            {
                IQuery q = session.CreateQuery(where);
                return q.List<T>();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return null;
            }
        }

        public void CloseSession()
        {
            if (session != null)
            {
                session.Close();
                session = null;
            }
        }
    }
}
