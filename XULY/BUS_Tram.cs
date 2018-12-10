using DULIEU;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XULY
{
     public class BUS_Tram
    {
        public DataTable LoadTram()
        {
            DAO_Tram tram = new DAO_Tram();
            DataTable dt = new DataTable();
            dt = tram.LoadTram();
            return dt;
        }
        public int ThemTram(Tram a)
        {
            int kq = 0;
            DAO_Tram tram = new DAO_Tram();
            DataTable dt = tram.IDTram();
            foreach (DataRow row in dt.Rows)
            {
                if (a.id_tram == row[0].ToString())
                {
                    return -1;
                }
            }
            kq = tram.ThemTram(a);
            return kq;
        }
        public int SuaTram(Tram a)
        {
            int kq = 0;
            DAO_Tram tram = new DAO_Tram();
            kq = tram.SuaTram(a);
            return kq;
        }
        public int XoaTram(string a)
        {
            int kq = 0;
            DAO_Tram kh = new DAO_Tram();
            kq = kh.XoaTram(a);
            return kq;
        }
    }
}
