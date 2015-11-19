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
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Scripting.Hosting;
using Stock.Strategy.Python;


namespace Stock.Strategy
{
    public class StrategyControl : UserControl
    {
        #region 初始化界面

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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.listView3 = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnFile = new System.Windows.Forms.Button();
            this.btnSetup = new System.Windows.Forms.Button();
            this.btnShowData = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(106, 188);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 13;
            this.BtnDelete.Text = "删除";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(25, 188);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "增加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // listView3
            // 
            this.listView3.CheckBoxes = true;
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader1,
            this.columnHeader2});
            this.listView3.Location = new System.Drawing.Point(25, 83);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(403, 82);
            this.listView3.TabIndex = 15;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "代码";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "名称";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "持仓";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "隐含收益率";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "Python文件位置：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(361, 21);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = "E:\\projects\\test.py";
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(399, 36);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(29, 23);
            this.btnFile.TabIndex = 18;
            this.btnFile.Text = "...";
            this.btnFile.UseVisualStyleBackColor = true;
            // 
            // btnSetup
            // 
            this.btnSetup.Location = new System.Drawing.Point(353, 188);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Size = new System.Drawing.Size(75, 23);
            this.btnSetup.TabIndex = 19;
            this.btnSetup.Text = "设置";
            this.btnSetup.UseVisualStyleBackColor = true;
            this.btnSetup.Click += new System.EventHandler(this.btnSetup_Click_1);
            // 
            // btnShowData
            // 
            this.btnShowData.Location = new System.Drawing.Point(272, 188);
            this.btnShowData.Name = "btnShowData";
            this.btnShowData.Size = new System.Drawing.Size(75, 23);
            this.btnShowData.TabIndex = 20;
            this.btnShowData.Text = "显示数据";
            this.btnShowData.UseVisualStyleBackColor = true;
            this.btnShowData.Click += new System.EventHandler(this.btnShowData_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(191, 188);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 21;
            this.btnImport.Text = "导入池子";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // StrategyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnShowData);
            this.Controls.Add(this.btnSetup);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.btnAdd);
            this.Name = "StrategyControl";
            this.Size = new System.Drawing.Size(454, 240);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSetup;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;

        #endregion
        private Button btnShowData;
        private Button btnImport;

        #region properties

        private IStrategy strategy;

        public IStrategy Strategy
        {
            get { return strategy; }
            set { strategy = value; }
        }
 
        #endregion

        public StrategyControl(IStrategy strategy)
        {
            InitializeComponent();
            this.strategy = strategy;

            // load my stock pool
            LoadMyStockPool();
        }

        private void LoadMyStockPool() {
            IControlOperation co = (strategy as IControlOperation);
            if (co != null)
            {
                IList<StockData> datas= co.LoadData();
                foreach (StockData data in datas)
                {
                    this.AddStock(data.Code, data.Name);
                }
            }
            else
                MessageBox.Show("本策略不支持本操作");

         }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new AddStockForm(this).ShowDialog();
        }

        public void AddStock(string code, string name)
        {
            ListViewItem item = new ListViewItem(new string[] {
            code,
            name}, -1);
            this.listView3.Items.Add(item);
            this.strategy.AddStock(code);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in this.listView3.Items)
	        {
                
                if (item.Checked)
                {
                    listView3.Items.Remove(item);
                    
                    this.strategy.RemoveStock(item.Text);
                }
	        }    
        }

        private void btnSetup_Click_1(object sender, EventArgs e)
        {
            IControlOperation co = (strategy as IControlOperation);
            if (co != null)
                co.Setup();
            else
                MessageBox.Show("本策略不支持本操作");
        }

        private void btnShowData_Click(object sender, EventArgs e)
        {
            IControlOperation co = (strategy as IControlOperation);
            if (co != null)
                co.ShowData();
            else
                MessageBox.Show("本策略不支持本操作");
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            IControlOperation co = (strategy as IControlOperation);
            if (co != null)
                co.ImportPool();
            else
                MessageBox.Show("本策略不支持本操作");
        }
    }
}
