using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DULIEU;
using System.Data;
namespace XULY
{
    public class BUS_Ve
    {

        public DataTable LoadGiaVe()
        {
            DAO_Ve ve = new DAO_Ve();
            DataTable dt = new DataTable();
            dt = ve.LoadGiaVe();
            return dt;
        }
        public int XoaGiaVe(int a , string b)
        {
            int kq = 0;
            DAO_Ve kh = new DAO_Ve();
            kq = kh.XoaGiaVe(a,b);
            return kq;
        }
        public int ThemGiaVe(GiaVe ve)
        {
            int kq = 0;
            DAO_Ve kh = new DAO_Ve();
            kq = kh.ThemGiaVe(ve);
            return kq;
        }

        public int SuaGiaVe(GiaVe ve)
        {
            int kq = 0;
            DAO_Ve kh = new DAO_Ve();
            kq = kh.SuaGiaVe(ve);
            return kq;
        }
        
    }
}
