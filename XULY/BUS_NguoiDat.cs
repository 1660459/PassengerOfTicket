using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DULIEU;
using System.Data;
namespace XULY
{
    public class BUS_NguoiDat
    {
        public int ThemNguoiDat(NguoiDat nd)
        {
            int kq = 0;
            DAO_NguoiDat kh = new DAO_NguoiDat();
            kq = kh.AddNguoiDat(nd);
            return kq;
        }
        public DataTable LoadNguoiDat()
        {
            DAO_NguoiDat nd = new DAO_NguoiDat();
            DataTable dt = new DataTable();
            dt = nd.LoadNguoiDat();
            return dt;
        }
    }
}
