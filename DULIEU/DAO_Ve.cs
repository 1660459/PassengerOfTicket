using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DULIEU
{
    public class DAO_Ve
    {
        public DataTable LoadVe()
        {
            Provider kn = new Provider();
            string strSQL = "sp_LoadVe";
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
        public int ThemVe(Ve cm)
        {
            int flag = 0;
            Provider provider = new Provider();
            try
            {
                string SqlStr = "sp_ThemVe";
                provider.Connect();
                provider.ExecuteNonQuery(CommandType.StoredProcedure, SqlStr,
                        new SqlParameter { ParameterName = "@id_ve", Value = cm.id_ve },
                        new SqlParameter { ParameterName = "@ghe_id_ghe", Value = cm.ghe_id_ghe },
                        new SqlParameter { ParameterName = "@chuyen_id_chuyen", Value = cm.chuyen_id_chuyen },
                        new SqlParameter { ParameterName = "@tinhtrang", Value = cm.tinhtrang },
                        new SqlParameter { ParameterName = "@giatien", Value = cm.giatien },
                        new SqlParameter { ParameterName = "@khachhang_id_khachhang", Value = cm.khachhang_id_khachhang },
                        new SqlParameter { ParameterName = "@ngayxuatve", Value = cm.ngayxuatve },
                        new SqlParameter { ParameterName = "@ghichu", Value = cm.ghichu }
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
        public int XoaVe(string idVe)
        {

            int flag = 0;
            Provider dbConnect = new Provider();
            try
            {
                string strSQL = "sp_XoaVe";
                dbConnect.Connect();
                dbConnect.ExecuteNonQuery(CommandType.StoredProcedure, strSQL,
                      new SqlParameter { ParameterName = "@id_tuyen", Value = idVe }
                       );

                flag = 1;
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                dbConnect.Disconnect();
            }
            return flag;

        }
        public int SuaVe(Ve cm)
        {
            int flag = 0;
            Provider provider = new Provider();
            try
            {
                string SqlStr = "sp_SuaVe";
                provider.Connect();
                provider.ExecuteNonQuery(CommandType.StoredProcedure, SqlStr,
                     new SqlParameter { ParameterName = "@id_ve", Value = cm.id_ve },
                        new SqlParameter { ParameterName = "@ghe_id_ghe", Value = cm.ghe_id_ghe },
                        new SqlParameter { ParameterName = "@chuyen_id_chuyen", Value = cm.chuyen_id_chuyen },
                        new SqlParameter { ParameterName = "@tinhtrang", Value = cm.tinhtrang },
                        new SqlParameter { ParameterName = "@giatien", Value = cm.giatien },
                        new SqlParameter { ParameterName = "@khachhang_id_khachhang", Value = cm.khachhang_id_khachhang },
                        new SqlParameter { ParameterName = "@ngayxuatve", Value = cm.ngayxuatve },
                        new SqlParameter { ParameterName = "@ghichu", Value = cm.ghichu }
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
    }
}
