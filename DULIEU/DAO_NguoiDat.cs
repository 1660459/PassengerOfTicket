using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DULIEU
{
    public class DAO_NguoiDat
    {
        public int AddNguoiDat(NguoiDat cm)
        {
            int flag = 0;
            Provider provider = new Provider();
            try
            {
                string SqlStr = "sp_AddNguoiDat";
                provider.Connect();
                provider.ExecuteNonQuery(CommandType.StoredProcedure, SqlStr,
                        new SqlParameter { ParameterName = "@id_ve", Value = cm.id_ve },
                        new SqlParameter { ParameterName = "@stt", Value = cm.stt },
                        new SqlParameter { ParameterName = "@ten_khach_hang", Value = cm.ten_khach_hang },
                        new SqlParameter { ParameterName = "@so_dt", Value = cm.so_dt },
                        new SqlParameter { ParameterName = "@ghe_id_ghe", Value = cm.ghe_id_ghe },
                        new SqlParameter { ParameterName = "@chuyen_id_chuyen", Value = cm.chuyen_id_chuyen },
                        new SqlParameter { ParameterName = "@tinhtrang", Value = cm.tinhtrang },
                        new SqlParameter { ParameterName = "@giatien", Value = cm.giatien },
                        new SqlParameter { ParameterName = "@ngayxuatve", Value = cm.ngayxuatve },
                        new SqlParameter { ParameterName = "@ghichu", Value = cm.ghi_chu }
                         );
                flag = 1;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.Disconnect();
            }
            return flag;
        }
        public DataTable LoadNguoiDat()
        {
            Provider kn = new Provider();
            string strSQL = "sp_LoadNguoiDat";
            DataTable dt = new DataTable();
            try
            {
                kn.Connect();
                dt = kn.Select(CommandType.StoredProcedure, strSQL);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                kn.Disconnect();
            }
            return dt;
        }
    }
}
