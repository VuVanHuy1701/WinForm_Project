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
    public class SP_CF_DAL : Data2
    {
        public List<MatHang> HienThiDanhSachSanPham()
        {
            List<MatHang> ds = new List<MatHang>();
            OpenConnection();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select *From MatHang mh, TheLoai tl Where tl.MaTheLoai = '11' and mh.MaTheLoai = tl.MaTheLoai";
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
    }
}
