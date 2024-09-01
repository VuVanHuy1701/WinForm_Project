using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using BLL;
using DTO;
using System.IO;


namespace GUI
{
    public partial class Form_QLy_MatHang : Form
    {
        SqlConnection connection;
        SqlCommand SqlCommand;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        DataTable tableOrder = new DataTable();
        
        string strCon = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=QLY_Pos;Integrated Security=True";
        void load()
        {
            SqlCommand = connection.CreateCommand();
            SqlCommand.CommandText = @"Select   MatHang.MaMatHang, MatHang.TenMon, MatHang.MaTheLoai, MatHang.Gia, MatHang.HinhAnh
                                       From     MatHang";
            adapter.SelectCommand = SqlCommand;
            table.Clear();
            adapter.Fill(table);
            dtgv_MatHang.DataSource = table;
            dtgv_MatHang.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv_MatHang.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10);

            dtgv_MatHang.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv_MatHang.DefaultCellStyle.Font = new Font("Arial", 10);
            
        }
        public Form_QLy_MatHang()
        {
            InitializeComponent();
        }

        private void Form_QLy_MatHang_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(strCon);
            connection.Open();
            load();
        }

        private void dtgv_MatHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtgv_MatHang.CurrentRow.Index;
            txtMaMH.Text = dtgv_MatHang.Rows[i].Cells[0].Value.ToString();
            txtTenMatHang.Text = dtgv_MatHang.Rows[i].Cells[1].Value.ToString();
            txtMaLoai.Text = dtgv_MatHang.Rows[i].Cells[2].Value.ToString();
            txtGiaTien.Text = dtgv_MatHang.Rows[i].Cells[3].Value.ToString();

        }
        private void btnThemHangHoa_Click(object sender, EventArgs e)
        {
            if (txtMaMH.Text == "" || txtTenMatHang.Text == "" || txtMaLoai.Text == "" || txtGiaTien.Text == "")
            {
                MessageBox.Show("Chưa nhập đầy đủ thông tin", "Thông báo");
            }
            else
            {
                SqlCommand = connection.CreateCommand();
                SqlCommand.CommandText = "Insert into MatHang Values('" + txtMaMH.Text + "', N'" + txtTenMatHang.Text + "', '" + txtMaLoai.Text + "', '" + txtHinhAnh.Text + "', '" + txtGiaTien.Text + "')";
                SqlCommand.ExecuteNonQuery();
                load();
                lammoiText();
                MessageBox.Show("Thêm mặt hàng thành công!", "Thông báo!");
            }
        }

        public void lammoiText()
        {
            txtMaMH.Clear();
            txtTenMatHang.Clear();
            txtMaLoai.Clear();  
            txtGiaTien.Clear();
        }

        private void btnXoaHangHoa_Click(object sender, EventArgs e)
        {
            if (txtMaMH.Text == "" || txtTenMatHang.Text == "" || txtMaLoai.Text == "" || txtGiaTien.Text == "")
            {
                MessageBox.Show("Chưa có thông tin muốn xóa", "Thông báo");
            }
            else
            {
                SqlCommand = connection.CreateCommand();
                SqlCommand.CommandText = "delete From MatHang where MaMatHang = '" + txtMaMH.Text + "'";
                SqlCommand.ExecuteNonQuery();
                load();
                lammoiText();
                MessageBox.Show("Xóa mặt hàng thành công!", "Thông báo!");
            }
        }

        private void btnSuaHangHoa_Click(object sender, EventArgs e)
        {
            if (txtMaMH.Text == "" || txtTenMatHang.Text == "" || txtMaLoai.Text == "" || txtGiaTien.Text == "")
            {
                MessageBox.Show("Ô chứa thông tin trống", "Thông báo");
            }
            else
            {
                SqlCommand = connection.CreateCommand();
                SqlCommand.CommandText = @"Update MatHang set TenMon = '" + txtTenMatHang.Text + "', " +
                    "                                         MaTheLoai = '" + txtMaLoai.Text + "', Gia = '" + txtGiaTien.Text + "' " +
                    "                     Where MaMatHang = '" + txtMaMH.Text + "'";

                SqlCommand.ExecuteNonQuery();
                load();
                lammoiText();
                MessageBox.Show("Sửa mặt hàng thành công!", "Thông báo!");
            }
        }
        private void btn_ThemHinhAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {

                txtHinhAnh.Text = openFile.FileName;

            }

        }
        private byte[] converImgToByte()
        {
            FileStream fs;
            fs = new FileStream(txtHinhAnh.Text, FileMode.Open, FileAccess.Read);
            byte[] picbyte = new byte[fs.Length];
            fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return picbyte;
        }

        private void btnChuyenDoi_Click(object sender, EventArgs e)
        {
           
        }

        

        private void lsv_MatHang_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            lammoiText();
        }
    }
}
