using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DULIEU
{
    public class DAO_LoaiXe
    {
        public DataTable LayTenLoaiXe()
        {
            Provider kn = new Provider();
            DataTable dt = new DataTable();
            string strSQL = "sp_LayTenLoaiXe";
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
