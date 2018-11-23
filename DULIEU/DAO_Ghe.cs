
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DULIEU
{
    public class DAO_Ghe
    {
        //public string LayIdGhe(int soghe , string IDxe)
        //{
        //    string idghe = null;
        //    Provider provider = new Provider();
        //    DataTable dt = new DataTable();
        //    try
        //    {
        //        string SqlStr = "sp_LayIdVe";
        //        provider.Connect();
        //        dt = provider.Select(CommandType.StoredProcedure, SqlStr,
        //            new SqlParameter { ParameterName = "@so_ghe",Value = soghe },
        //            new SqlParameter { ParameterName = "@Xe", Value = IDxe }
        //            );

        //    }
        //    catch (SqlException ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        provider.Disconnect();
        //    }
        //    return idghe;
        //}
    }
}
