using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DULIEU
{
    public class DAO_TaiXe
    {
        public DataTable LoadTaiXe()
        {
            Provider kn = new Provider();
            string strSQL = "sp_LoadTaiXe";
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
        public DataTable FindTaiXe(string TenTX)
        {
            Provider kn = new Provider();
            string strSQL = "sp_FindTaiXe";
            DataTable dt = new DataTable();
            try
            {
                kn.Connect();
                dt = kn.Select(CommandType.StoredProcedure, strSQL,
                    new SqlParameter { ParameterName = "tentaixe" , Value = TenTX}
                    );
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
        
        public DataTable IDTaiXe()
        {
            Provider kn = new Provider();
            string strSQL = "sp_IDTaiXe";
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
        public int ThemTaiXe(TaiXe cm)
        {
            int flag = 0;
            Provider provider = new Provider();
            try
            {
                string SqlStr = "sp_ThemTaiXe";
                provider.Connect();
                provider.ExecuteNonQuery(CommandType.StoredProcedure, SqlStr,
                    new SqlParameter { ParameterName = "@id_taixe" , Value = cm.id_taixe},
                    new SqlParameter { ParameterName = "@tentaixe" , Value = cm.tentaixe},
                    new SqlParameter { ParameterName = "@banglai" , Value = cm.banglai}
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
        public int XoaTaiXe(string idTaiXe)
        {

            int flag = 0;
            Provider dbConnect = new Provider();
            try
            {
                string strSQL = "sp_XoaTaiXe";
                dbConnect.Connect();
                dbConnect.ExecuteNonQuery(CommandType.StoredProcedure, strSQL,
                      new SqlParameter { ParameterName = "@id_taixe", Value = idTaiXe }
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
        public int SuaTaiXe(TaiXe cm)
        {
            int flag = 0;
            Provider provider = new Provider();
            try
            {
                string SqlStr = "sp_SuaTaiXe";
                provider.Connect();
                provider.ExecuteNonQuery(CommandType.StoredProcedure, SqlStr,
                    new SqlParameter { ParameterName = "@id_taixe" , Value = cm.id_taixe},
                    new SqlParameter { ParameterName = "@tentaixe" , Value = cm.tentaixe},
                    new SqlParameter { ParameterName = "@banglai" , Value = cm.banglai}
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
