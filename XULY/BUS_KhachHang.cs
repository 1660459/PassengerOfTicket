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
        public DataTable TimKhachHang(string tenKH)
        {
            DAO_KhachHang kh = new DAO_KhachHang();
            DataTable dt = new DataTable();
            dt = kh.FindKH(tenKH);
            return dt;
        }
        
        public List<string> LoadTenKH()
        {
            List<string> list = new List<string>();
            DAO_KhachHang kh = new DAO_KhachHang();
            DataTable dt = new DataTable();
            dt = kh.LoadIDKhachHang();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(row[0].ToString());
            }
            return list;
        }
        
        public int ThemKhachHang(KhachHang a)
        {
            int kq = 0;
            DAO_KhachHang kh = new DAO_KhachHang();
            DataTable dt = kh.IDKhachHang();
            foreach (DataRow row in dt.Rows)
            {
                if (a.id_khachhang == row[0].ToString())
                {
                    return -1;
                }
            }
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
        public int SuaKhachHang(KhachHang a)
        {
            int kq = 0;
            DAO_KhachHang kh = new DAO_KhachHang();
            kq = kh.SuaKhachHang(a);
            return kq;
        }
      
    }
}
