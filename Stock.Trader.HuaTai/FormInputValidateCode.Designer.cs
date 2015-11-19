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

namespace Stock.Trader.HuaTai
{
    partial class FormInputValidateCode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInputValidateCode));
            this.picValidateCode = new System.Windows.Forms.PictureBox();
            this.txtValidateCode = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtServicePwd = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtTrdpwd = new AxCSSWEBLOGINHTLib.AxCsswebLogin();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picValidateCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTrdpwd)).BeginInit();
            this.SuspendLayout();
            // 
            // picValidateCode
            // 
            this.picValidateCode.Location = new System.Drawing.Point(12, 133);
            this.picValidateCode.Name = "picValidateCode";
            this.picValidateCode.Size = new System.Drawing.Size(70, 22);
            this.picValidateCode.TabIndex = 0;
            this.picValidateCode.TabStop = false;
            // 
            // txtValidateCode
            // 
            this.txtValidateCode.Location = new System.Drawing.Point(118, 134);
            this.txtValidateCode.Name = "txtValidateCode";
            this.txtValidateCode.Size = new System.Drawing.Size(100, 21);
            this.txtValidateCode.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(118, 175);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "交易密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "通讯密码";
            // 
            // txtServicePwd
            // 
            this.txtServicePwd.Location = new System.Drawing.Point(118, 77);
            this.txtServicePwd.Name = "txtServicePwd";
            this.txtServicePwd.Size = new System.Drawing.Size(100, 21);
            this.txtServicePwd.TabIndex = 6;
            this.txtServicePwd.Text = "750404";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(118, 12);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 21);
            this.txtUsername.TabIndex = 7;
            // 
            // txtTrdpwd
            // 
            this.txtTrdpwd.Enabled = true;
            this.txtTrdpwd.Location = new System.Drawing.Point(117, 45);
            this.txtTrdpwd.Name = "txtTrdpwd";
            this.txtTrdpwd.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("txtTrdpwd.OcxState")));
            this.txtTrdpwd.Size = new System.Drawing.Size(100, 26);
            this.txtTrdpwd.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "验证码";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 183);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 16);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "保存";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // FormInputValidateCode
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 210);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtTrdpwd);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtServicePwd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtValidateCode);
            this.Controls.Add(this.picValidateCode);
            this.Name = "FormInputValidateCode";
            this.Text = "FormInputValidateCode";
            ((System.ComponentModel.ISupportInitialize)(this.picValidateCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTrdpwd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        public System.Windows.Forms.PictureBox picValidateCode;
        public System.Windows.Forms.TextBox txtValidateCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtServicePwd;
        public System.Windows.Forms.TextBox txtUsername;
        public AxCSSWEBLOGINHTLib.AxCsswebLogin txtTrdpwd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}