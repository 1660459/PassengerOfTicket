
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DULIEU
{
    public class DAO_Xe
    {
        public DataTable LoadXe()
        {
            Provider kn = new Provider();
            string strSQL = "sp_LoadXe";
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

        public DataTable IDXe()
        {
            Provider kn = new Provider();
            string strSQL = "sp_IDXe";
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
        public DataTable LoadLoaiXe()
        {
            Provider kn = new Provider();
            string strSQL = "sp_LoadLoaiXe";
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
        public int ThemXe(Xe cm)
        {
            int flag = 0;
            Provider provider = new Provider();
            try
            {
                string SqlStr = "sp_ThemXe";
                provider.Connect();
                provider.ExecuteNonQuery(CommandType.StoredProcedure, SqlStr,
                        new SqlParameter { ParameterName = "@xe_id", Value = cm.xe_id },
                        new SqlParameter { ParameterName = "@ten_xe", Value = cm.ten_xe },
                        new SqlParameter { ParameterName = "@so_dang_ky", Value = cm.so_dang_ky },
                        new SqlParameter { ParameterName = "@loaixe_id_loaixe", Value = cm.loaixe_id_loaixe }
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
        public int XoaXe(string idXe)
        {

            int flag = 0;
            Provider dbConnect = new Provider();
            try
            {
                string strSQL = "sp_XoaXe";
                dbConnect.Connect();
                dbConnect.ExecuteNonQuery(CommandType.StoredProcedure, strSQL,
                      new SqlParameter { ParameterName = "@xe_id", Value = idXe }
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
        public int SuaXe(Xe cm)
        {
            int flag = 0;
            Provider provider = new Provider();
            try
            {
                string SqlStr = "sp_SuaXe";
                provider.Connect();
                provider.ExecuteNonQuery(CommandType.StoredProcedure, SqlStr,
                     new SqlParameter { ParameterName = "@xe_id", Value = cm.xe_id },
                        new SqlParameter { ParameterName = "@ten_xe", Value = cm.ten_xe },
                        new SqlParameter { ParameterName = "@so_dang_ky", Value = cm.so_dang_ky },
                        new SqlParameter { ParameterName = "@loaixe_id_loaixe", Value = cm.loaixe_id_loaixe }
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

