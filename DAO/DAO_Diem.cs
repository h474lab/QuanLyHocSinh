using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_Diem : ConnectionString
    {
        public DAO_Diem() : base() { }
        public double? GetDiem(string mahs, string mamon, string mahk, string manh, string makt)
        {
            double? result = null;
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand command = new SqlCommand("SELECT_DIEM", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MAHOCSINH", SqlDbType.Decimal).Value = long.Parse(mahs);
                command.Parameters.Add("@MAMONHOC", SqlDbType.Decimal).Value = long.Parse(mamon);
                command.Parameters.Add("@MAHOCKY", SqlDbType.Decimal).Value = long.Parse(mahk);
                command.Parameters.Add("@MANAMHOC", SqlDbType.Decimal).Value = long.Parse(manh);
                command.Parameters.Add("@MALOAIKT", SqlDbType.Decimal).Value = long.Parse(makt);
                try
                {
                    command.Connection.Open();
                    SqlDataReader rd = command.ExecuteReader();
                    if (rd.Read())
                    {
                        if (rd["DiemSo"] != DBNull.Value)
                            result = double.Parse(rd["DiemSo"].ToString());
                        rd.Close();
                    }
                    command.Connection.Close();
                }
                catch
                {
                    command.Connection.Close();
                }
            }
            return result;
        }
        public int? Insert_Diem(string mahs, string malop, string mahk, string manh, string mamh, string makt, double? d)
        {
            int? result = null;
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand command = new SqlCommand("INSERT_DIEM", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MAHOCSINH", SqlDbType.Decimal).Value = long.Parse(mahs);
                command.Parameters.Add("@MALOP", SqlDbType.Decimal).Value = long.Parse(malop);
                command.Parameters.Add("@MAHOCKY", SqlDbType.Decimal).Value = long.Parse(mahk);
                command.Parameters.Add("@MANAMHOC", SqlDbType.Decimal).Value = long.Parse(manh);
                command.Parameters.Add("@MAMONHOC", SqlDbType.Decimal).Value = long.Parse(mamh);
                command.Parameters.Add("@MALOAIKT", SqlDbType.Decimal).Value = long.Parse(makt);
                command.Parameters.Add("@DIEMSO", SqlDbType.Float).Value = d;

                try
                {
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    result = 1;
                    command.Connection.Close();
                }
                catch
                {
                    command.Connection.Close();
                }
            }
            return result;
        }
        public int? Update_Diem(string mahs, string malop, string mahk, string manh, string mamh, string makt, double? d)
        {
            int? result = null;
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand command = new SqlCommand("UPDATE_DIEM", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MAHOCSINH", SqlDbType.Decimal).Value = long.Parse(mahs);
                command.Parameters.Add("@MALOP", SqlDbType.Decimal).Value = long.Parse(malop);
                command.Parameters.Add("@MAHOCKY", SqlDbType.Decimal).Value = long.Parse(mahk);
                command.Parameters.Add("@MANAMHOC", SqlDbType.Decimal).Value = long.Parse(manh);
                command.Parameters.Add("@MAMONHOC", SqlDbType.Decimal).Value = long.Parse(mamh);
                command.Parameters.Add("@MALOAIKT", SqlDbType.Decimal).Value = long.Parse(makt);
                command.Parameters.Add("@DIEMSO", SqlDbType.Float).Value = d;

                try
                {
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    result = 1;
                    command.Connection.Close();
                }
                catch
                {
                    command.Connection.Close();
                }
            }
            return result;
        }
        public int? Delete_Diem(string mahs, string malop, string mahk, string manh, string mamh, string makt)
        {
            int? result = null;
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand command = new SqlCommand("DELETE_DIEM", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MAHOCSINH", SqlDbType.Decimal).Value = long.Parse(mahs);
                command.Parameters.Add("@MALOP", SqlDbType.Decimal).Value = long.Parse(malop);
                command.Parameters.Add("@MAHOCKY", SqlDbType.Decimal).Value = long.Parse(mahk);
                command.Parameters.Add("@MANAMHOC", SqlDbType.Decimal).Value = long.Parse(manh);
                command.Parameters.Add("@MAMONHOC", SqlDbType.Decimal).Value = long.Parse(mamh);
                command.Parameters.Add("@MALOAIKT", SqlDbType.Decimal).Value = long.Parse(makt);

                try
                {
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    result = 1;
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
