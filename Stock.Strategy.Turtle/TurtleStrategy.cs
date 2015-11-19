using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stock.Strategy.Turtle
{
    public class TurtleStrategy : BaseStrategy
    {
        public TurtleStrategy()
        {
            IsValid = false;
        }

        public override void OnTicket(object sender)
        {
            
        }

        public override string Name
        {
            get
            {
                return " 海龟交易法则"; 
            }
            set{ }
        }

        public override string Description
        {
            get
            {
                return "海龟交易法则";
            }
            set { }
        }


    }
}
