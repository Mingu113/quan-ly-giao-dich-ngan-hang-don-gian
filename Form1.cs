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

namespace Xử_lý_giao_dịch_ngân_hàng
{
    public partial class GiaoDien : Form
    {
        public GiaoDien()
        {
            InitializeComponent();
        }
        // Thêm khách hàng
        private void Button1_Click(object sender, EventArgs e)
        {
            var form = new ThemKH();
            if (Application.OpenForms[form.Name] == null)
            {
                form.ShowDialog();
            }
            else
            {
                Application.OpenForms[form.Name].Focus();
            }
        }

        private void GiaoDien_Load(object sender, EventArgs e)
        {
            LB_IN_MaKH.Visible = false;
            IN_MaKH.Visible = false;
            IN_MaKH.KeyPress += new KeyPressEventHandler(TimKiem);
            Export.Visible = false;
        }
        // Tạo giao dịch
        private void GiaoDich_Click(object sender, EventArgs e)
        {
            var form = new GiaoDich();
            if(Application.OpenForms[form.Name] == null)
            {
                form.ShowDialog();
            } else
            {
                Application.OpenForms[form.Name].Focus();
            }
        }
        // Đọc và hiển thị danh sách trong cửa sổ
        private void DocDanhSach(string path)
        {
            StreamReader reader = new StreamReader(path);
            // Hiển thị danh sách khách hàng
            if (path == ProjectPath.KHpath)
            {
                LB_HienThi_DS.Text = "Danh sách khách hàng";
                HienThi_DS.Text = $"{"Mã", 10}" + $"{"Họ tên",10}" + $"{"Số dư", 30}" + Environment.NewLine;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    HienThi_DS.Text += $"{line.Split(',')[0],10}" + $"{line.Split(',')[1],10}" + $"{line.Split(',')[2], 30}" + Environment.NewLine;
                }
            }
            // Hiển thị sao kê của khách hàng
            else if(path == ProjectPath.GDPath)
            {
                LB_HienThi_DS.Text = "Sao kê của khách hàng: ";
                HienThi_DS.Text = $"{"Loại giao dịch",10}" + $"{"Lượng tiền",30}" + Environment.NewLine;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if(line.Split(',')[0].Equals(IN_MaKH.Text))
                    HienThi_DS.Text += $"{line.Split(',')[1],10}" + $"{line.Split(',')[2],40}" + Environment.NewLine;
                }
            }
            else
            {
                HienThi_DS.Text = "";
                LB_HienThi_DS.Text = "";
            }
            reader.Close();
        }
        // Hiển thị danh sách khách hàng
        private void InDS_KhachHang_Click(object sender, EventArgs e)
        {
            LB_IN_MaKH.Visible = false;
            IN_MaKH.Visible = false;
            DocDanhSach(ProjectPath.KHpath);
            Export.Visible = true;
        }
        // Hiển thị danh sách sao kê
        private void InDS_SaoKe_Click(object sender, EventArgs e)
        {
            LB_IN_MaKH.Visible = true;
            IN_MaKH.Visible = true;
        }
        // Xoá đi sao kê của khách hàng đang in nếu trường nhập trống
        private void IN_MaKH_TextChanged(object sender, EventArgs e)
        {
            if (IN_MaKH.Text == "") HienThi_DS.Text = "";
        }
        // Tìm kiếm sao kê của một khách hàng từ mã khách hàng đã nhập
        private void TimKiem(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                DocDanhSach(ProjectPath.GDPath);
                Export.Visible = true;
            }
        }

        // Xuất danh sách ra một tập tin, .txt hoặc .csv
        private void Export_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại lưu tập tin
            SaveFileDialog saveFile = new SaveFileDialog();
            if(IN_MaKH.Visible == false)
            {
                saveFile.FileName = @"Danh sách.txt";
                saveFile.Title = "Xuất danh sách khách hàng";
            } 
            else
            {
                saveFile.FileName = @"Sao kê của khách hàng " + IN_MaKH.Text + ".txt";
                saveFile.Title = "Xuất sao kê";
            }
            saveFile.Filter = "Tập tin văn bản (*.txt)| *.txt| CSV (*.csv)| *.csv";
            // Bắt đầu việc xuất tập tin
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                if (saveFile.FileName != "")
                {
                    using (StreamWriter sw = new StreamWriter(saveFile.FileName))
                    {
                        // Kiểm tra xuất danh sách nào
                        string path;
                        if (IN_MaKH.Visible == false) path = ProjectPath.KHpath;
                        else path = ProjectPath.GDPath;
                        StreamReader reader = new StreamReader(path);
                        string line;
                        // Xuất sang tập tin
                        if(path == ProjectPath.KHpath) // Xuất danh sách khách hàng
                        while ((line = reader.ReadLine()) != null) 
                        {
                            sw.WriteLine(line);
                        }
                        else // Xuất sao kê
                        {
                            while ((line = reader.ReadLine()) != null)
                            {
                                if(line.Split(',')[0] == IN_MaKH.Text) sw.WriteLine(line);
                            }
                        }
                        reader.Close();
                        sw.Close();
                    }

                }
            }
        }
    }
}
