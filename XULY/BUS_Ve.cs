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
            DataTable dt = kh.IDGiaVe();
            foreach (DataRow row in dt.Rows)
            {
                if (ve.stt == int.Parse(row[0].ToString()) && ve.id_tuyen_id == row[1].ToString())
                {
                    return -1;
                }
            }
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
        public string GetGiaVe(string ghichu)
        {
            DAO_Ve ve = new DAO_Ve();
            DAO_ChuyenXe cx = new DAO_ChuyenXe();
            string idtuyen = cx.GetIDTuyen(ghichu);
            string dt = ve.GetGiaVe(idtuyen);
            return dt;
        }
        public string MaVeMoi()
        {
            DAO_Ve ve = new DAO_Ve();
            string dt = "";
            dt = ve.MaVeMoi();
            return dt;
        }
        
    }
}
