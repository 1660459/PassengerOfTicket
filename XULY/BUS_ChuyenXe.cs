using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DULIEU;
namespace XULY
{
    public class BUS_ChuyenXe
    {
        public DataTable LoadChuyenXe()
        {
            DAO_ChuyenXe CX = new DAO_ChuyenXe();
            DataTable dt = new DataTable();
            dt = CX.LoadChuyenXe();
            return dt;
        }

        public int ThemChuyenXe(ChuyenXe a)
        {
            int kq = 0;
            DAO_ChuyenXe CX = new DAO_ChuyenXe();
            kq = CX.ThemChuyenXe(a);
            return kq;
        }
        public int SuaChuyenXe(ChuyenXe a)
        {
            int kq = 0;
            DAO_ChuyenXe CX = new DAO_ChuyenXe();
            kq = CX.SuaChuyenXe(a);
            return kq;
        }
        public int XoaChuyenXe(string a)
        {
            int kq = 0;
            DAO_ChuyenXe CX = new DAO_ChuyenXe();
            kq = CX.XoaChuyenXe(a);
            return kq;
        }
    }
}
