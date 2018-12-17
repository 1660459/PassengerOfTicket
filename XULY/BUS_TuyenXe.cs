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

        public List<string> LoadIDTuyenXe()
        {
            List<string> list = new List<string>();
            DAO_TuyenXe txe = new DAO_TuyenXe();
            DataTable dt = new DataTable();
            dt = txe.IDTuyen();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(row[0].ToString());
            }
            return list;
        }
        public List<string> LoadIDTram()
        {
            List<string> list = new List<string>();
            DAO_TuyenXe txe = new DAO_TuyenXe();
            DataTable dt = new DataTable();
            dt = txe.IDTram();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(row[0].ToString());
            }
            return list;
        }
        public int ThemTuyenXe(TuyenXe a)
        {
            int kq = 0;
            DAO_TuyenXe txe = new DAO_TuyenXe();
            DataTable dt = txe.IDTuyen();
            foreach (DataRow row in dt.Rows)
            {
                if (a.id_tuyen == row[0].ToString())
                {
                    return -1;
                }
            }
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
