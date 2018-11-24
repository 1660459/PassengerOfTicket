using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DULIEU;
using System.Data;
namespace XULY
{
    public class BUS_TuyenXe
    {
        public DataTable LoadTuyenXe()
        {
            DAO_TuyenXe txe = new DAO_TuyenXe();
            DataTable dt = new DataTable();
            dt = txe.LoadTuyenXe();
            return dt;
        }
        public int ThemTuyenXe(TuyenXe a)
        {
            int kq = 0;
            DAO_TuyenXe txe = new DAO_TuyenXe();
            kq = txe.ThemTuyenXe(a);
            return kq;
        }
        public int SuaTuyenXe(TuyenXe a)
        {
            int kq = 0;
            DAO_TuyenXe txe = new DAO_TuyenXe();
            kq = txe.SuaTuyenXe(a);
            return kq;
        }
        public int XoaTuyenXe(string a)
        {
            int kq = 0;
            DAO_TuyenXe txe = new DAO_TuyenXe();
            kq = txe.XoaTuyenXe(a);
            return kq;
        }
    }
}
