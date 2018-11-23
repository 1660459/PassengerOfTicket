using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DULIEU;
using System.Data;
namespace XULY
{
    public class BUS_KhachHang
    {
        public DataTable LoadKH()
        {
            DAO_KhachHang kh = new DAO_KhachHang();
            DataTable dt = new DataTable();
            dt = kh.LoadKhachHang();
            return dt;
        }
        public int ThemKhachHang(KhachHang a)
        {
            int kq = 0;
            DAO_KhachHang kh = new DAO_KhachHang();
            kq = kh.AddKhachHang(a);
            return kq;
        }
        public int XoaKhachHang(string a)
        {
            int kq = 0;
            DAO_KhachHang kh = new DAO_KhachHang();
            kq = kh.XoaKhachHang(a);
            return kq;
        }
    }
}
