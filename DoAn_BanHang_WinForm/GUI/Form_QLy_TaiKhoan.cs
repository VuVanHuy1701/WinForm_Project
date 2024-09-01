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
using DAL;
using System.IO;
namespace GUI
{
    public partial class Form_QLy_TaiKhoan : Form
    {
        SqlConnection connection;
        SqlCommand SqlCommand;
        string strCon = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=QLY_Pos;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void load()
        {
            SqlCommand = connection.CreateCommand();
            SqlCommand.CommandText = "Select * From TaiKhoan";
            adapter.SelectCommand = SqlCommand;
            table.Clear();
            adapter.Fill(table);
            dtgv_TaiKhoan.DataSource = table;
        }


        public Form_QLy_TaiKhoan()
        {
            InitializeComponent();
            
        }

        private void Form_QLy_TaiKhoan_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(strCon);
            connection.Open();
            load();
        }

        private void dtgv_TaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtgv_TaiKhoan.CurrentRow.Index;
            txtId.Text = dtgv_TaiKhoan.Rows[i].Cells[0].Value.ToString();
            txtUserName.Text = dtgv_TaiKhoan.Rows[i].Cells[1].Value.ToString();
            txtPass.Text = dtgv_TaiKhoan.Rows[i].Cells[2].Value.ToString();
            txtName.Text = dtgv_TaiKhoan.Rows[i].Cells[3].Value.ToString();
            txtPhone.Text = dtgv_TaiKhoan.Rows[i].Cells[4].Value.ToString();
            txtEmail.Text = dtgv_TaiKhoan.Rows[i].Cells[5].Value.ToString();
            txtCC_CM.Text = dtgv_TaiKhoan.Rows[i].Cells[6].Value.ToString();
        }

        private void btnThem_TK_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtUserName.Text == "" || txtPass.Text == "" || txtPhone.Text == "" || txtName.Text == ""|| txtEmail.Text == "" || txtCC_CM.Text == "")
            {
                MessageBox.Show("Chưa nhập đầy đủ thông tin", "Thông báo");
            }
            else
            {
                SqlCommand = connection.CreateCommand();
                SqlCommand.CommandText = "Insert into TaiKhoan Values('" + txtId.Text + "', '" + txtUserName.Text + "', '" + txtPass.Text + "', N'" + txtName.Text + "', '" + txtPhone.Text + "', '" + txtEmail.Text + "', '" + txtCC_CM.Text + "')";
                SqlCommand.ExecuteNonQuery();
                load();
                lammoiText();
            }
        }

        private void btnXoa_TK_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtUserName.Text == "" || txtPass.Text == "" || txtPhone.Text == "" || txtName.Text == "" || txtEmail.Text == "" || txtCC_CM.Text == "")
            {
                MessageBox.Show("Chưa có thông tin muốn xóa", "Thông báo");
            }
            else
            {
                SqlCommand = connection.CreateCommand();
                SqlCommand.CommandText = "delete From TaiKhoan where ID = '" + txtId.Text + "'";
                SqlCommand.ExecuteNonQuery();
                load();
                lammoiText();
            }
        }

        private void btnSua_TK_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtUserName.Text == "" || txtPass.Text == "" || txtPhone.Text == "" || txtName.Text == "" || txtEmail.Text == "" || txtCC_CM.Text == "")
            {
                MessageBox.Show("Ô chứa thông tin trống", "Thông báo");
            }
            else
            {
                SqlCommand = connection.CreateCommand();
                SqlCommand.CommandText = "Update TaiKhoan set Pass = '" + txtPass.Text + "', Phone = '" + txtPhone.Text + "', Email = '" + txtEmail.Text + "' Where ID = '" + txtId.Text + "'";

                SqlCommand.ExecuteNonQuery();

                String strMessage, strPass, strPhone, strEmail;
                strPass = txtPass.Text;
                strPhone = txtPhone.Text;
                strEmail = txtEmail.Text;

                strMessage = "Bạn đã sửa những thông tin:\n Mật Khẩu: " + strPass + " \n Số điện thoại: " + strPhone + " \n Email: " + strEmail;

                MessageBox.Show(strMessage);
                load();
                lammoiText();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            lammoiText();
        }
        public void lammoiText()
        {
            txtId.Text = "";
            txtUserName.Text = "";
            txtPass.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtCC_CM.Text = "";
        }
    }
}
