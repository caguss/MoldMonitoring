using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieMonitoring
{
    public class DataConnector
    {
        static string StringConnection = $"Server={Program.ServerName},{Program.Port}; Database={Program.DatabaseName}; uid={Program.Uid}; pwd={Program.Pwd}";


        public DataTable SearchStockList_R10(string search_option, string search_value)
        {

            using (SqlConnection conn = new SqlConnection(StringConnection))
            {
                conn.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand
                    {
                        CommandText = "USP_RFIDSearchStockList_R10",
                        CommandType = CommandType.StoredProcedure,
                        Connection = conn
                    };
                    cmd.Parameters.Add(new SqlParameter("@v_find_type", SqlDbType.VarChar, 10));
                    cmd.Parameters.Add(new SqlParameter("@v_find_value", SqlDbType.VarChar, 100));
                    cmd.Parameters["@v_find_type"].Value = search_option;
                    cmd.Parameters["@v_find_value"].Value = search_value;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();

                    da.Fill(ds);
                    da.Dispose();
                    conn.Close();

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        return ds.Tables[0];
                    }
                    else
                    {
                        return new DataTable();
                    }
                }
                catch (Exception ex)
                {
                    return new DataTable();
                }
            }
        }
    }
}
