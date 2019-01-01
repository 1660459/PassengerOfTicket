using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DULIEU;
namespace XULY
{
    public class BUS_QuanLiVeXe
    {
        public List<string> LoadTenLoaiXe()
        {
            DataTable dt = new DataTable();
            DAO_LoaiXe lx = new DAO_LoaiXe();
            List<string> list = new List<string>();
            dt = lx.LayTenLoaiXe();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(row[0].ToString());
            }
            return list;
        }
        public List<string> LoadGCChuyenXe()
        {
            DataTable dt = new DataTable();
            DAO_ChuyenXe cx = new DAO_ChuyenXe();
            List<string> listn = IDTuyenFromGiaVe();
            List<string> listkq = new List<string>();
            for (int i = 0; i < listn.Count; i++ )
            {
                string temp = cx.LoadGhiChuChuyenXe(listn[i].ToString());
                listkq.Add(temp);
            }
            return listkq;
        }

        List<string> IDTuyenFromGiaVe()
        {
            List<string> list = new List<string>();
            DAO_TuyenXe tx = new DAO_TuyenXe();
            DataTable dt = tx.IDTuyenFromGiaVe();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(row[0].ToString());
            }
            return list;
        }
    }
}
