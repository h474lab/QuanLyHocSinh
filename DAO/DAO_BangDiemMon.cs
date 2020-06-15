using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_BangDiemMon : ConnectionString
    {
        public DAO_BangDiemMon() : base() { }
        public double GetDiemTBMon(string mahs, string mahk, string manh, string mamh)
        {
            double result = -1;
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand command = new SqlCommand("SELECT_SISO", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MAHOCSINH", SqlDbType.Decimal).Value = long.Parse(mahs);
                command.Parameters.Add("@MAHOCKY", SqlDbType.Decimal).Value = long.Parse(mahk);
                command.Parameters.Add("@MANAMHOC", SqlDbType.Decimal).Value = long.Parse(manh);
                command.Parameters.Add("@MAMONHOC", SqlDbType.Decimal).Value = long.Parse(mamh);

                command.Parameters.Add("@ReturnValue", SqlDbType.Float).Direction = ParameterDirection.ReturnValue;

                try
                {
                    command.Connection.Open();
                    command.ExecuteNonQuery();

                    result = (double)command.Parameters["ReturnValue"].Value;

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
