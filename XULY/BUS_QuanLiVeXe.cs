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
            List<string> list = new List<string>();
            dt = cx.LoadGhiChuChuyenXe();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(row[0].ToString());
            }
            return list;
        }
    }
}
