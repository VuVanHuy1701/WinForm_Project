using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class TaiKhoan_DAL: Database
    {
       
        SqlCommand sqlCommand; // dùng để truy vấn câu lệnh 
        SqlDataReader dataReader; // dùng để đọc dữ liệu trong bảng
        public List<TaiKhoan> TaiKhoans (string query)
        {
            List<TaiKhoan> taiKhoans = new List<TaiKhoan>();
            
            using ( SqlConnection sqlConnection = TaiKhoan_DAL.GetSqlConnection())
            {
                sqlConnection.Open();

                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    taiKhoans.Add(new TaiKhoan(dataReader.GetString(0), dataReader.GetString(1)));
                }

                sqlConnection.Close();
            }

            return taiKhoans;
        }
    }
}
