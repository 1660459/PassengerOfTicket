using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DULIEU
{
    class DAO_KhachHang
    {
        public DataTable LoadKhachHang()
        {

            Provider kn = new Provider();
            string strSQL = "sp_LoadKhachHang";
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
        public int AddKhachHang(KhachHang cm)
        {
            int flag = 0;
            Provider provider = new Provider();
            try
            {
                string SqlStr = "sp_ThemKhachHang";
                provider.Connect();
                provider.ExecuteNonQuery(CommandType.StoredProcedure, SqlStr,
                        new SqlParameter { ParameterName = "@id_khachhang", Value = cm.id_khachhang },
                        new SqlParameter { ParameterName = "@hoten", Value = cm.hoten },
                        new SqlParameter { ParameterName = "@dienthoai", Value = cm.dienthoai },
                        new SqlParameter { ParameterName = "@email", Value = cm.email },
                        new SqlParameter { ParameterName = "@loai", Value = cm.loai }
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
        public int XoaKhachHang(string idKH){
            
            int flag = 0;
            Provider dbConnect = new Provider();
            try
            {
                string strSQL = "sp_XoaKhachHang";
                dbConnect.Connect();
                dbConnect.ExecuteNonQuery(CommandType.StoredProcedure, strSQL,
                      new SqlParameter { ParameterName = "@id_khachhang", Value = idKH }
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
        public int SuaKhachHang(KhachHang cm)
        {
            int flag = 0;
            Provider provider = new Provider();
            try
            {
                string SqlStr = "sp_SuaKhachHang";
                provider.Connect();
                provider.ExecuteNonQuery(CommandType.StoredProcedure, SqlStr,
                        new SqlParameter { ParameterName = "@id_khachhang", Value = cm.id_khachhang },
                        new SqlParameter { ParameterName = "@hoten", Value = cm.hoten },
                        new SqlParameter { ParameterName = "@dienthoai", Value = cm.dienthoai },
                        new SqlParameter { ParameterName = "@email", Value = cm.email },
                        new SqlParameter { ParameterName = "@loai", Value = cm.loai }
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

