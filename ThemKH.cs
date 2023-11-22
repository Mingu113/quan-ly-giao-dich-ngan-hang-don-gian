using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace Xử_lý_giao_dịch_ngân_hàng
{
    public partial class ThemKH : Form
    {
        public string path = ProjectPath.KHpath;
        /// <summary>
        /// Cấu trúc tập tin: gồm một dãy các hàng, cấu trúc mỗi hàng:
        /// Mã khách hàng, Tên Khách hàng, số dư
        /// </summary>
        private int MaKHMoiNhat = 0; // lay ma khach hang moi nhat
        // Lấy mã khách hàng mới nhất trong tập tin
        private void LayThongTinKhachHangMoiNhat()
        {
            ///
            if (!File.Exists(path))
            {
                File.WriteAllText(path, "");
            }
            ///
            if (new FileInfo(path).Length != 0)
            {
                string lastline = File.ReadLines(path).LastOrDefault().Split(',')[0];
                MaKHMoiNhat = int.Parse(lastline);
            }
        }
        public ThemKH()
        {
            InitializeComponent();
            LayThongTinKhachHangMoiNhat();
            this.makhIN.Text = (MaKHMoiNhat + 1).ToString();
        }
        // Thêm khách hàng
        private void ThemKhachHang_Click(object sender, EventArgs e)
        {
            // Kiểm tra đầy đủ thông tin đã nhập
            if(!Decimal.TryParse(soduIN.Text, out decimal sodu) || tenkhIN.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Nhập khách hàng
                KhachHang khachHang = new KhachHang
                {
                    MaKhachHang = int.Parse(makhIN.Text),
                    SoDu = sodu,
                    TenKhachHang = tenkhIN.Text
                };
                string New_KhachHang = khachHang.MaKhachHang.ToString() + ',' + khachHang.TenKhachHang + ',' + khachHang.SoDu.ToString() + Environment.NewLine;
                File.AppendAllText(path, New_KhachHang);
                LayThongTinKhachHangMoiNhat();
                makhIN.Text = (MaKHMoiNhat + 1).ToString();
                soduIN.Clear();
                tenkhIN.Clear();
            }
        }

    }
}
