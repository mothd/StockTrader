﻿/*
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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Stock.Market
{
    public partial class TongShiForm : Form
    {
        private StockMarketListener listener;
        public TongShiForm(StockMarketListener listener)
        {
            InitializeComponent();
            this.listener = listener;
        }

        protected override void WndProc(ref Message m)
        {
            listener.WndProc(ref m);
            base.WndProc(ref m);
        }
    }
}
