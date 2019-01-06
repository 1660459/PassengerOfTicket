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

        public DataTable LoadVe()
        {
            DAO_Ve ve = new DAO_Ve();
            DataTable dt = new DataTable();
            dt = ve.LoadVe();
            return dt;
        }
        public DataTable LoadVeTheoTG(string idchuyen , DateTime bd , DateTime kt)
        {
            DAO_Ve ve = new DAO_Ve();
            DataTable dt = new DataTable();
            dt = ve.LoadVeTheoTG(idchuyen , bd , kt);
            return dt;
        }
        public DataTable LoadVeTheoTGTuyen(string ghichu, DateTime bd, DateTime kt)
        {
            DAO_Ve ve = new DAO_Ve();
            DataTable dt = new DataTable();
            dt = ve.LoadVeTheoTGTuyen(ghichu, bd, kt);
            return dt;
        }
        public DataTable LoadVeTheoChuyen(string idchuyen)
        {
            DAO_Ve ve = new DAO_Ve();
            DataTable dt = new DataTable();
            dt = ve.LoadVeTheoChuyen(idchuyen);
            return dt;
        }
        public DataTable LoadVeTheoTuyen(string ghichu)
        {
            DAO_Ve ve = new DAO_Ve();
            DataTable dt = new DataTable();
            dt = ve.LoadVeTheoTuyen(ghichu);
            return dt;
        }
        
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
                if (ve.id_tuyen_id == row[1].ToString())
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
        public string MaVeNDMoi()
        {
            DAO_Ve ve = new DAO_Ve();
            string dt = "";
            dt = ve.MaVeNDMoi();
            return dt;
        }
        public string VeTuTang()
        {
            DAO_Ve ve = new DAO_Ve();
            string dt = "";
            dt = ve.VeMoi();
            return dt;
        }
        
        public int ThemVe(Ve ve)
        {
            int kq = 0;
            DAO_Ve kh = new DAO_Ve();
            DataTable dt = kh.IDVe();
            foreach (DataRow row in dt.Rows)
            {
                if (ve.id_ve == row[0].ToString())
                {
                    return -1;
                }
            }
            dt = kh.TrungVe();
            foreach (DataRow row in dt.Rows)
            {
                if (ve.chuyen_id_chuyen == row[0].ToString() && ve.ghe_id_ghe == row[1].ToString())
                {
                    return -2;
                }
            }
            kq = kh.ThemVe(ve);
            return kq;
        }
    }
}
