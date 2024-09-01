using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAL
{
    public class MatHang_DAL : Data2
    {

        public List<MatHang> HienThiDanhSachMatHang()
        {
            List<MatHang> ds = new List<MatHang>();
            OpenConnection();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select * from MatHang";
            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                string ma = reader.GetString(0);
                string ten = reader.GetString(1);
                string maloai = reader.GetString(2);
                string hinhanh = reader.GetString(3);
                double gia = (double)reader.GetDouble(4);
                MatHang mh = new MatHang();
                mh.MaMatHang = ma;
                mh.TenMon = ten;
                mh.MaTheLoai = maloai;
                mh.HinhAnh = hinhanh;
                mh.Gia = gia;
                ds.Add(mh);
            }
            reader.Close();
            return ds;
        }
        public bool ThemMH(MatHang mh)
        {
            OpenConnection();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "insert into MatHang values (@ma, @ten, @maloai, @hinhanh, @gia)";

            SqlParameter parMa = new SqlParameter("@ma", SqlDbType.VarChar);
            parMa.Value = mh.MaMatHang;
            sqlCmd.Parameters.Add(parMa);

            SqlParameter parTen = new SqlParameter("@ten", SqlDbType.NVarChar);
            parTen.Value = mh.TenMon;
            sqlCmd.Parameters.Add(parTen);

            SqlParameter parMaLoai = new SqlParameter("@maloai", SqlDbType.Char);
            parMaLoai.Value = mh.MaTheLoai;
            sqlCmd.Parameters.Add(parMaLoai);

            SqlParameter parHinhAnh = new SqlParameter("@hinhanh", SqlDbType.Char);
            parHinhAnh.Value = mh.HinhAnh;
            sqlCmd.Parameters.Add(parHinhAnh);

            SqlParameter parGia = new SqlParameter("@gia", SqlDbType.Real);
            parGia.Value = mh.Gia;
            sqlCmd.Parameters.Add(parGia);

            sqlCmd.Connection = sqlCon;
            int kt = sqlCmd.ExecuteNonQuery();
            if (kt > 0)
            {
                return true;
            }
            else
            {
                return false;
            }  
        }
        
        public bool XoaMH(MatHang mh)
        {
            OpenConnection();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "delete from MatHang where MaMatHang = @ma ";
            SqlParameter parMa = new SqlParameter("@ma", SqlDbType.Char);
            parMa.Value = mh.MaMatHang;
            sqlCmd.Parameters.Add(parMa);

            sqlCmd.Connection = sqlCon;
            int kt = sqlCmd.ExecuteNonQuery();
            if (kt > 0)
            {
                return true;
            }
            else
            {
                return false;

            }
        }
        public bool SuaMH(MatHang mh)
        {
            OpenConnection();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "update MatHang set MaMatHang = @ma, TenMon = @ten, MaTheLoai = @maloai, Gia = @gia where MaMatHang = @ma ";

            SqlParameter parMa = new SqlParameter("@ma", SqlDbType.Char);
            parMa.Value = mh.MaMatHang;
            sqlCmd.Parameters.Add(parMa);

            SqlParameter parTen = new SqlParameter("@ten", SqlDbType.NVarChar);
            parTen.Value = mh.TenMon;
            sqlCmd.Parameters.Add(parTen);

            SqlParameter parMaLoai = new SqlParameter("@maloai", SqlDbType.NVarChar);
            parMaLoai.Value = mh.MaTheLoai;
            sqlCmd.Parameters.Add(parMaLoai);

            SqlParameter parGia = new SqlParameter("@gia", SqlDbType.Real);
            parGia.Value = mh.Gia;
            sqlCmd.Parameters.Add(parGia);

            sqlCmd.Connection = sqlCon;
            int kt = sqlCmd.ExecuteNonQuery();
            if (kt > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
