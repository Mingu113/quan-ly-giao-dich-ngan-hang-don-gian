
namespace Xử_lý_giao_dịch_ngân_hàng
{
    partial class GiaoDien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiaoDien));
            this.ThemKH = new System.Windows.Forms.Button();
            this.GiaoDich = new System.Windows.Forms.Button();
            this.InDS_KhachHang = new System.Windows.Forms.Button();
            this.InDS_SaoKe = new System.Windows.Forms.Button();
            this.HienThi_DS = new System.Windows.Forms.RichTextBox();
            this.LB_HienThi_DS = new System.Windows.Forms.Label();
            this.IN_MaKH = new System.Windows.Forms.TextBox();
            this.LB_IN_MaKH = new System.Windows.Forms.Label();
            this.Export = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ThemKH
            // 
            resources.ApplyResources(this.ThemKH, "ThemKH");
            this.ThemKH.Name = "ThemKH";
            this.ThemKH.UseVisualStyleBackColor = true;
            this.ThemKH.Click += new System.EventHandler(this.Button1_Click);
            // 
            // GiaoDich
            // 
            resources.ApplyResources(this.GiaoDich, "GiaoDich");
            this.GiaoDich.Name = "GiaoDich";
            this.GiaoDich.UseVisualStyleBackColor = true;
            this.GiaoDich.Click += new System.EventHandler(this.GiaoDich_Click);
            // 
            // InDS_KhachHang
            // 
            resources.ApplyResources(this.InDS_KhachHang, "InDS_KhachHang");
            this.InDS_KhachHang.Name = "InDS_KhachHang";
            this.InDS_KhachHang.UseVisualStyleBackColor = true;
            this.InDS_KhachHang.Click += new System.EventHandler(this.InDS_KhachHang_Click);
            // 
            // InDS_SaoKe
            // 
            resources.ApplyResources(this.InDS_SaoKe, "InDS_SaoKe");
            this.InDS_SaoKe.Name = "InDS_SaoKe";
            this.InDS_SaoKe.UseVisualStyleBackColor = true;
            this.InDS_SaoKe.Click += new System.EventHandler(this.InDS_SaoKe_Click);
            // 
            // HienThi_DS
            // 
            this.HienThi_DS.BackColor = System.Drawing.SystemColors.Control;
            this.HienThi_DS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.HienThi_DS, "HienThi_DS");
            this.HienThi_DS.Name = "HienThi_DS";
            this.HienThi_DS.ReadOnly = true;
            // 
            // LB_HienThi_DS
            // 
            resources.ApplyResources(this.LB_HienThi_DS, "LB_HienThi_DS");
            this.LB_HienThi_DS.Name = "LB_HienThi_DS";
            // 
            // IN_MaKH
            // 
            resources.ApplyResources(this.IN_MaKH, "IN_MaKH");
            this.IN_MaKH.Name = "IN_MaKH";
            this.IN_MaKH.TextChanged += new System.EventHandler(this.IN_MaKH_TextChanged);
            // 
            // LB_IN_MaKH
            // 
            resources.ApplyResources(this.LB_IN_MaKH, "LB_IN_MaKH");
            this.LB_IN_MaKH.Name = "LB_IN_MaKH";
            // 
            // Export
            // 
            resources.ApplyResources(this.Export, "Export");
            this.Export.Name = "Export";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // GiaoDien
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Export);
            this.Controls.Add(this.LB_IN_MaKH);
            this.Controls.Add(this.IN_MaKH);
            this.Controls.Add(this.LB_HienThi_DS);
            this.Controls.Add(this.HienThi_DS);
            this.Controls.Add(this.InDS_SaoKe);
            this.Controls.Add(this.InDS_KhachHang);
            this.Controls.Add(this.GiaoDich);
            this.Controls.Add(this.ThemKH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GiaoDien";
            this.Load += new System.EventHandler(this.GiaoDien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void IN_MaKH_KeyDown1(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button ThemKH;
        private System.Windows.Forms.Button GiaoDich;
        private System.Windows.Forms.Button InDS_KhachHang;
        private System.Windows.Forms.Button InDS_SaoKe;
        private System.Windows.Forms.RichTextBox HienThi_DS;
        private System.Windows.Forms.Label LB_HienThi_DS;
        private System.Windows.Forms.TextBox IN_MaKH;
        private System.Windows.Forms.Label LB_IN_MaKH;
        private System.Windows.Forms.Button Export;
    }
}

