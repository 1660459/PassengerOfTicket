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

        public DataTable LoadGiaVe()
        {
            Provider kn = new Provider();
            string strSQL = "sp_LoadGiaVe";
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

        public DataTable IDGiaVe()
        {
            Provider kn = new Provider();
            string strSQL = "sp_LoadIDGiaVe";
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
        public string GetGiaVe(string idtuyen)
        {
            Provider kn = new Provider();
            string strSQL = "sp_GetGiaVe";
            DataTable dt = new DataTable();
            try
            {
                kn.Connect();
                dt = kn.Select(CommandType.StoredProcedure, strSQL,
                    new SqlParameter {ParameterName= "@ID" , Value = idtuyen}
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
            DataRow row = dt.Rows[0];
            return row[0].ToString();
        }
        public string MaVeMoi()
        {
            Provider kn = new Provider();
            string strSQL = "sp_MaVeMoi";
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
            DataRow row = dt.Rows[0];
            return row[0].ToString();
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
        public int ThemGiaVe(GiaVe cm)
        {
            int flag = 0;
            Provider provider = new Provider();
            try
            {
                string SqlStr = "sp_ThemGiaVe";
                provider.Connect();
                provider.ExecuteNonQuery(CommandType.StoredProcedure, SqlStr,
                        new SqlParameter { ParameterName = "@id_ve", Value = cm.stt },
                        new SqlParameter { ParameterName = "@id_tuyen_id", Value = cm.id_tuyen_id },
                        new SqlParameter { ParameterName = "@gia_ve", Value = cm.gia_ve }
                        
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
        public int SuaGiaVe(GiaVe cm)
        {
            int flag = 0;
            Provider provider = new Provider();
            try
            {
                string SqlStr = "sp_SuaGiaVe";
                provider.Connect();
                provider.ExecuteNonQuery(CommandType.StoredProcedure, SqlStr,
                        new SqlParameter { ParameterName = "@id_ve", Value = cm.stt },
                        new SqlParameter { ParameterName = "@id_tuyen_id", Value = cm.id_tuyen_id },
                        new SqlParameter { ParameterName = "@gia_ve", Value = cm.gia_ve }

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
        public int XoaGiaVe(int STT , string ID)
        {

            int flag = 0;
            Provider dbConnect = new Provider();
            try
            {
                string strSQL = "sp_XoaGiaVe";
                dbConnect.Connect();
                dbConnect.ExecuteNonQuery(CommandType.StoredProcedure, strSQL,
                      new SqlParameter { ParameterName = "@STT", Value = STT },
                      new SqlParameter { ParameterName = "@ID", Value = ID }
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
