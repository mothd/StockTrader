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


using System.Window;
using Stock.Trader.Settings;

namespace StockTrader
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("基金组", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("股票组", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctxStrategyMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.增加策略ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miFfjjStrategy = new System.Windows.Forms.ToolStripMenuItem();
            this.miGpStrategy = new System.Windows.Forms.ToolStripMenuItem();
            this.删除策略ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.启用策略ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.暂停策略ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lvStockPosition = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button16 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lvTradeList = new System.Windows.Forms.ListView();
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader26 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader27 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader28 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctxStrategyMenu.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.ContextMenuStrip = this.ctxStrategyMenu;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            listViewGroup1.Header = "基金组";
            listViewGroup1.Name = "jjz";
            listViewGroup2.Header = "股票组";
            listViewGroup2.Name = "gpz";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.listView1.HideSelection = false;
            this.listView1.LabelEdit = true;
            this.listView1.Location = new System.Drawing.Point(22, 17);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(180, 248);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "策略名";
            this.columnHeader3.Width = 132;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "策略说明";
            // 
            // ctxStrategyMenu
            // 
            this.ctxStrategyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.增加策略ToolStripMenuItem,
            this.删除策略ToolStripMenuItem,
            this.启用策略ToolStripMenuItem,
            this.暂停策略ToolStripMenuItem});
            this.ctxStrategyMenu.Name = "ctxStrategyMenu";
            this.ctxStrategyMenu.Size = new System.Drawing.Size(125, 92);
            // 
            // 增加策略ToolStripMenuItem
            // 
            this.增加策略ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFfjjStrategy,
            this.miGpStrategy});
            this.增加策略ToolStripMenuItem.Name = "增加策略ToolStripMenuItem";
            this.增加策略ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.增加策略ToolStripMenuItem.Text = "增加策略";
            // 
            // miFfjjStrategy
            // 
            this.miFfjjStrategy.Name = "miFfjjStrategy";
            this.miFfjjStrategy.Size = new System.Drawing.Size(148, 22);
            this.miFfjjStrategy.Text = "分级基金策略";
            // 
            // miGpStrategy
            // 
            this.miGpStrategy.Name = "miGpStrategy";
            this.miGpStrategy.Size = new System.Drawing.Size(148, 22);
            this.miGpStrategy.Text = "股票策略";
            // 
            // 删除策略ToolStripMenuItem
            // 
            this.删除策略ToolStripMenuItem.Name = "删除策略ToolStripMenuItem";
            this.删除策略ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.删除策略ToolStripMenuItem.Text = "删除策略";
            // 
            // 启用策略ToolStripMenuItem
            // 
            this.启用策略ToolStripMenuItem.Name = "启用策略ToolStripMenuItem";
            this.启用策略ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.启用策略ToolStripMenuItem.Text = "启用策略";
            // 
            // 暂停策略ToolStripMenuItem
            // 
            this.暂停策略ToolStripMenuItem.Name = "暂停策略ToolStripMenuItem";
            this.暂停策略ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.暂停策略ToolStripMenuItem.Text = "暂停策略";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(214, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 247);
            this.panel1.TabIndex = 29;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lvStockPosition);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(684, 179);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "持仓";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lvStockPosition
            // 
            this.lvStockPosition.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15});
            this.lvStockPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvStockPosition.FullRowSelect = true;
            this.lvStockPosition.Location = new System.Drawing.Point(3, 3);
            this.lvStockPosition.MultiSelect = false;
            this.lvStockPosition.Name = "lvStockPosition";
            this.lvStockPosition.Size = new System.Drawing.Size(678, 173);
            this.lvStockPosition.TabIndex = 0;
            this.lvStockPosition.UseCompatibleStateImageBehavior = false;
            this.lvStockPosition.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "证券代码";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "证券名称";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "股票余额";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "冻结数量";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "可用余额";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "成本价";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "保本价";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "市价";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "盈亏比";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "盈亏";
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "市值";
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "交易市场";
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "股东账户";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.button16);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.button12);
            this.tabPage1.Controls.Add(this.button13);
            this.tabPage1.Controls.Add(this.button14);
            this.tabPage1.Controls.Add(this.button15);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.button10);
            this.tabPage1.Controls.Add(this.button11);
            this.tabPage1.Controls.Add(this.button9);
            this.tabPage1.Controls.Add(this.button8);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(684, 179);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(434, 53);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(98, 28);
            this.button5.TabIndex = 52;
            this.button5.Text = "启动交易";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(463, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 51;
            this.label7.Text = "数量";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(290, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 50;
            this.label6.Text = "价格";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 49;
            this.label5.Text = "代码";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(503, 26);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 48;
            this.textBox3.Text = "100";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(334, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 47;
            this.textBox2.Text = "11";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(169, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 46;
            this.textBox1.Text = "600717";
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(13, 21);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(97, 23);
            this.button16.TabIndex = 45;
            this.button16.Text = "寻找下单软件";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(563, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 44;
            this.label4.Text = "上海基金";
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(434, 121);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(98, 28);
            this.button12.TabIndex = 43;
            this.button12.Text = "分拆";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(294, 121);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(98, 28);
            this.button13.TabIndex = 42;
            this.button13.Text = "合并";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(149, 121);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(98, 28);
            this.button14.TabIndex = 41;
            this.button14.Text = "赎回";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(12, 121);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(98, 28);
            this.button15.TabIndex = 40;
            this.button15.Text = "申购";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(563, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 39;
            this.label3.Text = "深圳基金";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(434, 87);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(98, 28);
            this.button10.TabIndex = 38;
            this.button10.Text = "分拆";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(294, 87);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(98, 28);
            this.button11.TabIndex = 37;
            this.button11.Text = "合并";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(149, 87);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(98, 28);
            this.button9.TabIndex = 36;
            this.button9.Text = "回报窗口";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(12, 87);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(98, 28);
            this.button8.TabIndex = 35;
            this.button8.Text = "卖出窗口";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(294, 53);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 28);
            this.button3.TabIndex = 33;
            this.button3.Text = "撤单";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(149, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 28);
            this.button2.TabIndex = 32;
            this.button2.Text = "买入";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 28);
            this.button1.TabIndex = 31;
            this.button1.Text = "卖出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 310);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(692, 205);
            this.tabControl1.TabIndex = 31;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lvTradeList);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(684, 179);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "成交";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(684, 179);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "委托";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.textBox4);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(684, 179);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "交易日志";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox4.Location = new System.Drawing.Point(0, 0);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(684, 179);
            this.textBox4.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.dataGridView1);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(684, 179);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.DefaultCellStyle.NullValue = null;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(678, 173);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            dataGridViewCellStyle1.Format = "N3";
            dataGridViewCellStyle1.NullValue = null;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // lvTradeList
            // 
            this.lvTradeList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader21,
            this.columnHeader22,
            this.columnHeader23,
            this.columnHeader24,
            this.columnHeader25,
            this.columnHeader26,
            this.columnHeader27,
            this.columnHeader28});
            this.lvTradeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvTradeList.FullRowSelect = true;
            this.lvTradeList.Location = new System.Drawing.Point(0, 0);
            this.lvTradeList.MultiSelect = false;
            this.lvTradeList.Name = "lvTradeList";
            this.lvTradeList.Size = new System.Drawing.Size(684, 179);
            this.lvTradeList.TabIndex = 1;
            this.lvTradeList.UseCompatibleStateImageBehavior = false;
            this.lvTradeList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "证券代码";
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "证券名称";
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "股票余额";
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "冻结数量";
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "可用余额";
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "成本价";
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "保本价";
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "市价";
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "盈亏比";
            // 
            // columnHeader25
            // 
            this.columnHeader25.Text = "盈亏";
            // 
            // columnHeader26
            // 
            this.columnHeader26.Text = "市值";
            // 
            // columnHeader27
            // 
            this.columnHeader27.Text = "交易市场";
            // 
            // columnHeader28
            // 
            this.columnHeader28.Text = "股东账户";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 515);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ctxStrategyMenu.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ContextMenuStrip ctxStrategyMenu;
        private System.Windows.Forms.ToolStripMenuItem miFfjjStrategy;
        private System.Windows.Forms.ToolStripMenuItem miGpStrategy;
        private System.Windows.Forms.ToolStripMenuItem 增加策略ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除策略ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 启用策略ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 暂停策略ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView lvStockPosition;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.ListView lvTradeList;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ColumnHeader columnHeader24;
        private System.Windows.Forms.ColumnHeader columnHeader25;
        private System.Windows.Forms.ColumnHeader columnHeader26;
        private System.Windows.Forms.ColumnHeader columnHeader27;
        private System.Windows.Forms.ColumnHeader columnHeader28;
    }
}

