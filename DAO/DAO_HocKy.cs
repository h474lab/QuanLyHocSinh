using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_HocKy : ConnectionString
    {
        public DAO_HocKy() : base() { }
        public DataTable GetTatCaHocKy()
        {
            DataTable result = null;
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand command = new SqlCommand("SELECT_TATCAHK", conn);
                command.CommandType = CommandType.StoredProcedure;
                try
                {
                    command.Connection.Open();
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    result = new DataTable();
                    da.Fill(result);
                    command.Connection.Close();
                }
                catch
                {
                    command.Connection.Close();
                }
            }
            return result;
        }
    }
}
