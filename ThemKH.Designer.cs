
using System;

namespace Xử_lý_giao_dịch_ngân_hàng
{
    partial class ThemKH
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
            this.tenkhLB = new System.Windows.Forms.Label();
            this.makhLB = new System.Windows.Forms.Label();
            this.soduLB = new System.Windows.Forms.Label();
            this.tenkhIN = new System.Windows.Forms.TextBox();
            this.makhIN = new System.Windows.Forms.Label();
            this.ThemKhachHang = new System.Windows.Forms.Button();
            this.soduIN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tenkhLB
            // 
            this.tenkhLB.AutoSize = true;
            this.tenkhLB.Location = new System.Drawing.Point(46, 44);
            this.tenkhLB.Name = "tenkhLB";
            this.tenkhLB.Size = new System.Drawing.Size(89, 13);
            this.tenkhLB.TabIndex = 0;
            this.tenkhLB.Text = "Tên Khách Hàng";
            // 
            // makhLB
            // 
            this.makhLB.AutoSize = true;
            this.makhLB.Location = new System.Drawing.Point(46, 19);
            this.makhLB.Name = "makhLB";
            this.makhLB.Size = new System.Drawing.Size(83, 13);
            this.makhLB.TabIndex = 1;
            this.makhLB.Text = "Mã Khách hàng";
            // 
            // soduLB
            // 
            this.soduLB.AutoSize = true;
            this.soduLB.Location = new System.Drawing.Point(46, 69);
            this.soduLB.Name = "soduLB";
            this.soduLB.Size = new System.Drawing.Size(35, 13);
            this.soduLB.TabIndex = 2;
            this.soduLB.Text = "Số dư";
            // 
            // tenkhIN
            // 
            this.tenkhIN.Location = new System.Drawing.Point(149, 41);
            this.tenkhIN.Name = "tenkhIN";
            this.tenkhIN.Size = new System.Drawing.Size(210, 20);
            this.tenkhIN.TabIndex = 10;
            // 
            // makhIN
            // 
            this.makhIN.Location = new System.Drawing.Point(146, 15);
            this.makhIN.Name = "makhIN";
            this.makhIN.Size = new System.Drawing.Size(100, 23);
            this.makhIN.TabIndex = 8;
            // 
            // ThemKhachHang
            // 
            this.ThemKhachHang.Location = new System.Drawing.Point(282, 170);
            this.ThemKhachHang.Name = "ThemKhachHang";
            this.ThemKhachHang.Size = new System.Drawing.Size(94, 23);
            this.ThemKhachHang.TabIndex = 7;
            this.ThemKhachHang.Text = "Thêm";
            this.ThemKhachHang.UseVisualStyleBackColor = true;
            this.ThemKhachHang.Click += new System.EventHandler(this.ThemKhachHang_Click);
            // 
            // soduIN
            // 
            this.soduIN.Location = new System.Drawing.Point(149, 66);
            this.soduIN.Name = "soduIN";
            this.soduIN.Size = new System.Drawing.Size(210, 20);
            this.soduIN.TabIndex = 11;
            // 
            // ThemKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 214);
            this.Controls.Add(this.soduIN);
            this.Controls.Add(this.ThemKhachHang);
            this.Controls.Add(this.makhIN);
            this.Controls.Add(this.tenkhIN);
            this.Controls.Add(this.soduLB);
            this.Controls.Add(this.makhLB);
            this.Controls.Add(this.tenkhLB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ThemKH";
            this.Text = "ThemKH";
            this.Load += new System.EventHandler(this.ThemKH_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ThemKH_Load(object sender, EventArgs e)
        {
            // throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label tenkhLB;
        private System.Windows.Forms.Label makhLB;
        private System.Windows.Forms.Label soduLB;
        private System.Windows.Forms.TextBox tenkhIN;
        private System.Windows.Forms.Label makhIN;
        private System.Windows.Forms.Button ThemKhachHang;
        private System.Windows.Forms.TextBox soduIN;
    }
}