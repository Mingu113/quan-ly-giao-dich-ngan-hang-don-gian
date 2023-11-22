using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xử_lý_giao_dịch_ngân_hàng
{
    public partial class GiaoDich : Form
    {
        public string KHpath = ProjectPath.KHpath;
        public string GDpath = ProjectPath.GDPath;
        public GiaoDich()
        {
            InitializeComponent();
        }

        // Tạo danh sách khách hàng để thao tác
        private readonly List<KhachHang> DS_KhachHang = new List<KhachHang>();
        // Đọc danh sách khách hàng từ tập tin khách hàng
        private void DocDanhSachKhachHang()
        {
            // Nếu không tìm thấy tập tin khách hàng: Báo lỗi, đóng cửa sổ
            if(!File.Exists(KHpath))
            {
                MessageBox.Show("Không tìm thấy tập tin khách hàng", "Lỗi tập tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            // Nếu tập tin khách hàng trống
            else if(new FileInfo(KHpath).Length == 0)
            {
                MessageBox.Show("Không có khách hàng trong tập tin", "Lỗi khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            // Nhập thông tin khách hàng từ tập tin
            else
            {
                var DS = File.ReadLines(KHpath);
                foreach (var khach in DS)
                {
                    int MaKH = int.Parse(khach.Split(',')[0]);
                    string TenKH = khach.Split(',')[1];
                    int SoDu = int.Parse(khach.Split(',')[2]);
                    DS_KhachHang.Add(new KhachHang(MaKH, TenKH, SoDu));
                }
            }
        }
        // Tìm kiếm khách hàng thông qua ID, sau đó trả về có tìm thấy khách hàng hay không, nếu có xuất khách hàng với mã đã nhập
        private bool TimKiemKhachHang(string ID_TimKiem, out KhachHang khach_OUT)
        {
            if(ID_TimKiem == null)
            {
                khach_OUT = null;
                return false;
            }
            if(ID_TimKiem == "") ID_TimKiem = IN_MaKhachHang.Text;
            KhachHang khach = DS_KhachHang.Find(
                delegate (KhachHang timkiem) { return timkiem.MaKhachHang.ToString().Equals(ID_TimKiem); }
                    );
            if (khach != null)
            {
                khach_OUT = khach;
                return true;
            }
            khach_OUT = null;
            return false;
        }
        // Làm trống các trường nhập và xuất
        private void Clear_WinForm()
        {
            OP_TenKhachHang.Text = "";
            OP_SoDu.Text = "";
            IN_LuongTien.Clear();
        }
        // Hiển thị
        private void IN_MaKhachHang_TextChanged(object sender, EventArgs e)
        {
            // Hiển thị thông tin khách hàng và số dư
            if (TimKiemKhachHang(IN_MaKhachHang.Text, out KhachHang khach))
            {
                OP_TenKhachHang.Text = khach.TenKhachHang;
                OP_SoDu.Text = khach.SoDu.ToString();
            }
            else
            {
                Clear_WinForm();
            }
        }

        private void GiaoDich_Load(object sender, EventArgs e)
        {
            // Tạo tập tin Giao dịch nếu không tìm thấy
            if (!File.Exists(GDpath))
            {
                File.WriteAllText(GDpath, "");
            }
            DocDanhSachKhachHang();
        }

        private void Confirm_TienHanh_Click(object sender, EventArgs e)
        {
            // Lấy thông tin khách hàng đã nhập
            bool found = TimKiemKhachHang(IN_MaKhachHang.Text, out KhachHang khach);
            bool DaNhap_TienGiaoDich = Decimal.TryParse(IN_LuongTien.Text, out decimal TienGiaoDich);
            //decimal TienGiaoDich = Decimal.Parse(IN_LuongTien.Text);
            // Báo lỗi nếu không tìm thấy khách hàng
            if (!TimKiemKhachHang(IN_MaKhachHang.Text, out _))
            {
                MessageBox.Show("Không tìm thấy khách hàng với mã khách hàng được nhập", "Không tìm thấy khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear_WinForm();
            }
            // Báo lỗi nếu chưa chọn loại giao dịch
             else if(!IN_GuiTien.Checked && !IN_RutTien.Checked)
            {
                MessageBox.Show("Không có loại giao dịch nào được chọn", "Chưa chọn loại giao dịch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear_WinForm();
            }// Báo lỗi nếu chưa nhập lượng tiền giao dịch
            else if (!DaNhap_TienGiaoDich)
            {
                MessageBox.Show("Chưa nhập lượng tiền cho lần giao dịch", "Chưa chọn lượng tiền giao dịch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear_WinForm();
            }
            // Báo lỗi nếu rút tiền nhưng không đủ tiền
            else if(IN_RutTien.Checked && TienGiaoDich > khach.SoDu)
            {
                MessageBox.Show("Khách hàng được chọn không có đủ tiền trong tài khoản để rút", "Tài khoản không đủ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear_WinForm();
            }
            // Thực hiện giao dịch
            else if(found && DaNhap_TienGiaoDich)
            {
                string Loai_GiaoDich;
                if (IN_GuiTien.Checked) Loai_GiaoDich = "Gửi tiền";
                else Loai_GiaoDich = "Rút tiền";
                // Cập nhật trong tập tin khách hàng (rewrite file - heavy on memory method)
                string[] DSKH = File.ReadAllLines(KHpath);
                if (IN_RutTien.Checked) khach.SoDu -= TienGiaoDich;
                else khach.SoDu += TienGiaoDich;
                DSKH[khach.MaKhachHang - 1] = khach.MaKhachHang.ToString() + ',' + khach.TenKhachHang + ',' + khach.SoDu.ToString();
                File.WriteAllLines(KHpath, DSKH);
                // Cập nhật trong tập tin giao dịch 
                string New_GiaoDich = khach.MaKhachHang.ToString() + ',' + Loai_GiaoDich + ',' + TienGiaoDich.ToString() + Environment.NewLine;
                File.AppendAllText(GDpath, New_GiaoDich);
                // Thông báo thành công, cập nhật lại Winform
                MessageBox.Show("Giao dịch thành công cho khách hàng " + khach.TenKhachHang + ", Loại giao dịch: " + Loai_GiaoDich + ", Số tiền: " + TienGiaoDich.ToString(), "Giao dịch thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Clear_WinForm();
            }
        }
    }
}
