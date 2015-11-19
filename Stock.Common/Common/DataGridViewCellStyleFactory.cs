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
using System.Windows.Forms;
using System.Drawing;
using Stock.Account.Settings;

namespace Stock.Common
{
    public class DataGridViewCellStyleFactory
    {
        private static IDictionary<string, DataGridViewCellStyle> styles = new Dictionary<string, DataGridViewCellStyle>();
        private static Font font1;
        private static Font font2;

        static DataGridViewCellStyleFactory(){
            int font_size = 0;
            string size = Configure.GetStockTraderItem(Configure.FONT_SIZE);
            if (size == null) font_size = 9;
            else font_size = int.Parse(size);

            String font_family = Configure.GetStockTraderItem(Configure.FONT_FAMILY);
            if (font_family == null) font_family = "微软雅黑";

            font1 = new Font(font_family, font_size, FontStyle.Regular);
            font2 = new Font(font_family, font_size, FontStyle.Bold);
        }
    
        public static DataGridViewCellStyle CreateCellStyle(bool bold, string format, Color fcolor, Color bcolor, DataGridViewContentAlignment alignment)
        {
            string key = string.Format("key_{0}_{1}_{2}_{3}_{4}", bold, format, fcolor, bcolor, alignment);
            if (!styles.Keys.Contains(key))
            {
                DataGridViewCellStyle style = new DataGridViewCellStyle();

                if (bold) style.Font = font2;
                else style.Font = font1;
                style.ForeColor = fcolor;
                style.BackColor = bcolor;
                style.Format = format;
                style.Alignment = alignment;

                styles.Add(key, style);
            }
            return styles[key];
        }

        public static DataGridViewCellStyle CreateCellStyle(string format)
        {
            return CreateCellStyle(false, format, Color.Black, Color.White, DataGridViewContentAlignment.MiddleRight);
        }

        public static DataGridViewCellStyle CreateCellStyle(bool bold, string format)
        {
            return CreateCellStyle(bold, format, Color.Black, Color.White, DataGridViewContentAlignment.MiddleRight);
        }

        public static DataGridViewCellStyle CreateCellStyle(bool bold, string format, Color fcolor, Color bcolor)
        {
            return CreateCellStyle(bold, format, fcolor, bcolor, DataGridViewContentAlignment.MiddleRight);
        }

        public static DataGridViewCellStyle CreateCellStyle(bool bold, Color fcolor, Color bcolor)
        {
            return CreateCellStyle(bold, "N2", fcolor, bcolor, DataGridViewContentAlignment.MiddleRight);
        }

        public static DataGridViewCellStyle CreateCellStyle(Color fcolor, Color bcolor)
        {
            return CreateCellStyle(false, "N2", fcolor, bcolor, DataGridViewContentAlignment.MiddleRight);
        }

    }
}
