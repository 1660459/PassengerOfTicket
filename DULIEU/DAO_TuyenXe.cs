using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DULIEU
{
    public class DAO_TuyenXe
    {
        public DataTable LoadTuyenXe()
        {

            Provider kn = new Provider();
            string strSQL = "sp_LoadTuyenXe";
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
        
        public DataTable IDTuyen()
        {

            Provider kn = new Provider();
            string strSQL = "sp_IDTuyen";
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
        public DataTable IDTuyenFromGiaVe()
        {

            Provider kn = new Provider();
            string strSQL = "sp_IDTuyenFromGiaVe";
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
        
        public DataTable IDTram()
        {

            Provider kn = new Provider();
            string strSQL = "sp_LoadIDTram";
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
        public int ThemTuyenXe(TuyenXe cm)
        {
            int flag = 0;
            Provider provider = new Provider();
            try
            {
                string SqlStr = "sp_ThemTuyenXe";
                provider.Connect();
                provider.ExecuteNonQuery(CommandType.StoredProcedure, SqlStr,
                        new SqlParameter { ParameterName = "@id_tuyen", Value = cm.id_tuyen },
                        new SqlParameter { ParameterName = "@khoang_cach", Value = cm.khoang_cach },
                        new SqlParameter { ParameterName = "@thoigianchay", Value = cm.thoigianchay },
                        new SqlParameter { ParameterName = "@tram_id_tram", Value = cm.tram_id_tram },
                        new SqlParameter { ParameterName = "@tram_id_tram1", Value = cm.tram_id_tram1 }
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
        public int XoaTuyenXe(string idTuyen)
        {

            int flag = 0;
            Provider dbConnect = new Provider();
            try
            {
                string strSQL = "sp_XoaTuyenXe";
                dbConnect.Connect();
                dbConnect.ExecuteNonQuery(CommandType.StoredProcedure, strSQL,
                      new SqlParameter { ParameterName = "@id_tuyen", Value = idTuyen }
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
        public int SuaTuyenXe(TuyenXe cm)
        {
            int flag = 0;
            Provider provider = new Provider();
            try
            {
                string SqlStr = "sp_SuaTuyenXe";
                provider.Connect();
                provider.ExecuteNonQuery(CommandType.StoredProcedure, SqlStr,
                       new SqlParameter { ParameterName = "@id_tuyen", Value = cm.id_tuyen },
                        new SqlParameter { ParameterName = "@khoang_cach", Value = cm.khoang_cach },
                        new SqlParameter { ParameterName = "@thoigianchay", Value = cm.thoigianchay },
                        new SqlParameter { ParameterName = "@tram_id_tram", Value = cm.tram_id_tram },
                        new SqlParameter { ParameterName = "@tram_id_tram1", Value = cm.tram_id_tram1 }
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
