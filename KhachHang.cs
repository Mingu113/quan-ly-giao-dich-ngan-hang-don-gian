using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Xử_lý_giao_dịch_ngân_hàng
{
    public static class ProjectPath
    {
        public static readonly string KHpath = Path.Combine(@"D:\customer.txt");
        public static readonly string GDPath = Path.Combine(@"D:\trans.txt");
    }
    public class KhachHang
    {
        public int MaKhachHang { get; set; }
        public string TenKhachHang { get; set; }
        public decimal SoDu { get; set; }
        public KhachHang()
        {

        }
        public KhachHang(int makh = 0, string name = "", int money = 0)
        {
            this.MaKhachHang = makh;
            this.TenKhachHang = name;
            this.SoDu = money;
        }
    }
}
