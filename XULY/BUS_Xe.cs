using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DULIEU;
namespace XULY
{
    public class BUS_Xe
    {
        public DataTable LoadXe()
        {
            DAO_Xe xe = new DAO_Xe();
            DataTable dt = new DataTable();
            dt = xe.LoadXe();
            return dt;
        }
        public int ThemXe(Xe a)
        {
            int kq = 0;
            DAO_Xe xe = new DAO_Xe();
            kq = xe.ThemXe(a);
            return kq;
        }
        public int SuaXe(Xe a)
        {
            int kq = 0;
            DAO_Xe xe = new DAO_Xe();
            kq = xe.SuaXe(a);
            return kq;
        }
        public int XoaXe(string a)
        {
            int kq = 0;
            DAO_Xe kh = new DAO_Xe();
            kq = kh.XoaXe(a);
            return kq;
        }

        public List<string> LoadLoaiXe()
        {
            DAO_Xe xe = new DAO_Xe();
            DataTable dt = new DataTable();
            dt = xe.LoadLoaiXe();
            List<string> list = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(row[0].ToString());
            }
            return list;
        }
    }
}
