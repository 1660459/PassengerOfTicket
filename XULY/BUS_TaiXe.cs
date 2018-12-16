using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DULIEU;
using System.Data;

namespace XULY
{
    public class BUS_TaiXe
    {
        public DataTable LoadTaiXe()
        {
            DAO_TaiXe tai_xe = new DAO_TaiXe();
            DataTable dt = new DataTable();
            dt = tai_xe.LoadTaiXe();
            return dt;
        }
        public DataTable TimTaiXe(string tenTX)
        {
            DAO_TaiXe tai_xe = new DAO_TaiXe();
            DataTable dt = new DataTable();
            dt = tai_xe.FindTaiXe(tenTX);
            return dt;
        }
       
        public int ThemTaiXe(TaiXe a)
        {
            int kq = 0;
            DAO_TaiXe tai_xe = new DAO_TaiXe();
            DataTable dt = tai_xe.IDTaiXe();
            foreach (DataRow row in dt.Rows)
            {
                if (a.id_taixe == row[0].ToString())
                {
                    return -1;
                }
            }
            kq = tai_xe.ThemTaiXe(a);
            return kq;
        }
        public int SuaTaiXe(TaiXe a)
        {
            int kq = 0;
            DAO_TaiXe tai_xe = new DAO_TaiXe();
            kq = tai_xe.SuaTaiXe(a);
            return kq;
        }
        public int XoaTaiXe(string a)
        {
            int kq = 0;
            DAO_TaiXe tai_xe = new DAO_TaiXe();
            kq = tai_xe.XoaTaiXe(a);
            return kq;
        }
    }
}
