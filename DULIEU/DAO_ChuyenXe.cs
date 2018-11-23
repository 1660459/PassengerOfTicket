using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DULIEU
{
    public class DAO_ChuyenXe
    {
        public DataTable LoadChuyenXe()
        {
            Provider kn = new Provider();
            string strSQL = "sp_LoadChuyenXe";
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
        public DataTable LoadGhiChuChuyenXe()
        {
            Provider kn = new Provider();
            string strSQL = "sp_LoadGhiChuChuyenXe"; // Stored Nay Nho' Distinct nhe'
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
       
        public int ThemChuyenXe(ChuyenXe cm)
        {
            int flag = 0;
            Provider provider = new Provider();
            try
            {
                string SqlStr = "sp_ThemChuyenXe";
                provider.Connect();
                provider.ExecuteNonQuery(CommandType.StoredProcedure, SqlStr,
                        new SqlParameter { ParameterName = "@id_chuyen", Value = cm.id_chuyen },
                        new SqlParameter { ParameterName = "@tuyen_id_tuyen", Value = cm.tuyen_id_tuyen },
                        new SqlParameter { ParameterName = "@giokhoihanh", Value = cm.giokhoihanh },
                        new SqlParameter { ParameterName = "@xe_xeid", Value = cm.xe_xeid },
                        new SqlParameter { ParameterName = "@ghichu", Value = cm.ghichu },
                        new SqlParameter { ParameterName = "@tai_xe_id_taixe", Value = cm.tai_xe_id_taixe }
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
        public int XoaChuyenXe(string idChuyen)
        {

            int flag = 0;
            Provider dbConnect = new Provider();
            try
            {
                string strSQL = "sp_XoaChuyenXe";
                dbConnect.Connect();
                dbConnect.ExecuteNonQuery(CommandType.StoredProcedure, strSQL,
                      new SqlParameter { ParameterName = "@id_tuyen", Value = idChuyen }
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
        public int SuaChuyenXe(ChuyenXe cm)
        {
            int flag = 0;
            Provider provider = new Provider();
            try
            {
                string SqlStr = "sp_SuaChuyenXe";
                provider.Connect();
                provider.ExecuteNonQuery(CommandType.StoredProcedure, SqlStr,
                       new SqlParameter { ParameterName = "@id_chuyen", Value = cm.id_chuyen },
                       new SqlParameter { ParameterName = "@tuyen_id_tuyen", Value = cm.tuyen_id_tuyen },
                       new SqlParameter { ParameterName = "@giokhoihanh", Value = cm.giokhoihanh },
                       new SqlParameter { ParameterName = "@xe_xeid", Value = cm.xe_xeid },
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
