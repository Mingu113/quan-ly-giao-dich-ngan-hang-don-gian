
namespace Xử_lý_giao_dịch_ngân_hàng
{
    partial class GiaoDich
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
            this.LB_MaKH = new System.Windows.Forms.Label();
            this.LB_LoaiGB = new System.Windows.Forms.Label();
            this.LB_LuongTien = new System.Windows.Forms.Label();
            this.IN_GuiTien = new System.Windows.Forms.RadioButton();
            this.IN_RutTien = new System.Windows.Forms.RadioButton();
            this.IN_MaKhachHang = new System.Windows.Forms.TextBox();
            this.IN_LuongTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OP_TenKhachHang = new System.Windows.Forms.Label();
            this.Confirm_TienHanh = new System.Windows.Forms.Button();
            this.LB_SoDu = new System.Windows.Forms.Label();
            this.OP_SoDu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LB_MaKH
            // 
            this.LB_MaKH.AutoSize = true;
            this.LB_MaKH.Location = new System.Drawing.Point(41, 9);
            this.LB_MaKH.Name = "LB_MaKH";
            this.LB_MaKH.Size = new System.Drawing.Size(83, 13);
            this.LB_MaKH.TabIndex = 0;
            this.LB_MaKH.Text = "Mã Khách hàng";
            // 
            // LB_LoaiGB
            // 
            this.LB_LoaiGB.AutoSize = true;
            this.LB_LoaiGB.Location = new System.Drawing.Point(41, 76);
            this.LB_LoaiGB.Name = "LB_LoaiGB";
            this.LB_LoaiGB.Size = new System.Drawing.Size(73, 13);
            this.LB_LoaiGB.TabIndex = 1;
            this.LB_LoaiGB.Text = "Loại giao dịch";
            // 
            // LB_LuongTien
            // 
            this.LB_LuongTien.AutoSize = true;
            this.LB_LuongTien.Location = new System.Drawing.Point(41, 109);
            this.LB_LuongTien.Name = "LB_LuongTien";
            this.LB_LuongTien.Size = new System.Drawing.Size(57, 13);
            this.LB_LuongTien.TabIndex = 2;
            this.LB_LuongTien.Text = "Lượng tiền";
            // 
            // IN_GuiTien
            // 
            this.IN_GuiTien.AutoSize = true;
            this.IN_GuiTien.Location = new System.Drawing.Point(120, 72);
            this.IN_GuiTien.Name = "IN_GuiTien";
            this.IN_GuiTien.Size = new System.Drawing.Size(61, 17);
            this.IN_GuiTien.TabIndex = 3;
            this.IN_GuiTien.TabStop = true;
            this.IN_GuiTien.Text = "Gửi tiền";
            this.IN_GuiTien.UseVisualStyleBackColor = true;
            // 
            // IN_RutTien
            // 
            this.IN_RutTien.AutoSize = true;
            this.IN_RutTien.Location = new System.Drawing.Point(188, 72);
            this.IN_RutTien.Name = "IN_RutTien";
            this.IN_RutTien.Size = new System.Drawing.Size(62, 17);
            this.IN_RutTien.TabIndex = 4;
            this.IN_RutTien.TabStop = true;
            this.IN_RutTien.Text = "Rút tiền";
            this.IN_RutTien.UseVisualStyleBackColor = true;
            // 
            // IN_MaKhachHang
            // 
            this.IN_MaKhachHang.Location = new System.Drawing.Point(130, 8);
            this.IN_MaKhachHang.Name = "IN_MaKhachHang";
            this.IN_MaKhachHang.Size = new System.Drawing.Size(100, 20);
            this.IN_MaKhachHang.TabIndex = 5;
            this.IN_MaKhachHang.TextChanged += new System.EventHandler(this.IN_MaKhachHang_TextChanged);
            // 
            // IN_LuongTien
            // 
            this.IN_LuongTien.Location = new System.Drawing.Point(130, 102);
            this.IN_LuongTien.Name = "IN_LuongTien";
            this.IN_LuongTien.Size = new System.Drawing.Size(133, 20);
            this.IN_LuongTien.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên Khách hàng";
            // 
            // OP_TenKhachHang
            // 
            this.OP_TenKhachHang.AutoSize = true;
            this.OP_TenKhachHang.Location = new System.Drawing.Point(134, 32);
            this.OP_TenKhachHang.Name = "OP_TenKhachHang";
            this.OP_TenKhachHang.Size = new System.Drawing.Size(0, 13);
            this.OP_TenKhachHang.TabIndex = 8;
            // 
            // Confirm_TienHanh
            // 
            this.Confirm_TienHanh.Location = new System.Drawing.Point(188, 135);
            this.Confirm_TienHanh.Name = "Confirm_TienHanh";
            this.Confirm_TienHanh.Size = new System.Drawing.Size(75, 23);
            this.Confirm_TienHanh.TabIndex = 9;
            this.Confirm_TienHanh.Text = "Tiến hành";
            this.Confirm_TienHanh.UseVisualStyleBackColor = true;
            this.Confirm_TienHanh.Click += new System.EventHandler(this.Confirm_TienHanh_Click);
            // 
            // LB_SoDu
            // 
            this.LB_SoDu.AutoSize = true;
            this.LB_SoDu.Location = new System.Drawing.Point(41, 54);
            this.LB_SoDu.Name = "LB_SoDu";
            this.LB_SoDu.Size = new System.Drawing.Size(35, 13);
            this.LB_SoDu.TabIndex = 10;
            this.LB_SoDu.Text = "Số dư";
            // 
            // OP_SoDu
            // 
            this.OP_SoDu.AutoSize = true;
            this.OP_SoDu.Location = new System.Drawing.Point(134, 54);
            this.OP_SoDu.Name = "OP_SoDu";
            this.OP_SoDu.Size = new System.Drawing.Size(0, 13);
            this.OP_SoDu.TabIndex = 11;
            // 
            // GiaoDich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 183);
            this.Controls.Add(this.OP_SoDu);
            this.Controls.Add(this.LB_SoDu);
            this.Controls.Add(this.Confirm_TienHanh);
            this.Controls.Add(this.OP_TenKhachHang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IN_LuongTien);
            this.Controls.Add(this.IN_MaKhachHang);
            this.Controls.Add(this.IN_RutTien);
            this.Controls.Add(this.IN_GuiTien);
            this.Controls.Add(this.LB_LuongTien);
            this.Controls.Add(this.LB_LoaiGB);
            this.Controls.Add(this.LB_MaKH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GiaoDich";
            this.Text = "GiaoDich";
            this.Load += new System.EventHandler(this.GiaoDich_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_MaKH;
        private System.Windows.Forms.Label LB_LoaiGB;
        private System.Windows.Forms.Label LB_LuongTien;
        private System.Windows.Forms.RadioButton IN_GuiTien;
        private System.Windows.Forms.RadioButton IN_RutTien;
        private System.Windows.Forms.TextBox IN_MaKhachHang;
        private System.Windows.Forms.TextBox IN_LuongTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label OP_TenKhachHang;
        private System.Windows.Forms.Button Confirm_TienHanh;
        private System.Windows.Forms.Label LB_SoDu;
        private System.Windows.Forms.Label OP_SoDu;
    }
}