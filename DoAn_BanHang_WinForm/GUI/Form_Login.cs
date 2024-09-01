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

namespace GUI
{
    public partial class Form_Login : Form
    {
        bool Hided;
        public Form_Login()
        {
            InitializeComponent();
            Hided = true;
        }
        private void Form_Login_Load(object sender, EventArgs e)
        {

        }

        //Tạo timer để di chuyển panel Login về bên phải để hiện ra panle quên Pass
        private void timer_Tick(object sender, EventArgs e)
        {
            //nếu panel quên Pass đang đóng. thì khi bấm vào quên mật khẩu sẽ mở ra
            if (Hided)
            {

                panel_Login.Left = panel_Login.Left + 126;
                timer_Form_Login.Stop();
                Hided = false;
                this.Refresh();
             

            }
            // panle quên pass đang mở. thì khi bấm quên mật khẩu sẽ đóng lại
            else
            {
                panel_Login.Left = panel_Login.Left - 126;
                timer_Form_Login.Stop();
                Hided = true;
                panel_QuenPass.Visible = false; //tắt panle quên mật khẩu
                this.Refresh();

            }
        }
        private void link_lblQuenPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblKetqua.Text = "";
            timer_Form_Login.Start();
            panel_QuenPass.Visible = true;// khi bấm quên mật khẩu. panel quên mật khẩu sẽ được hiện ra 
            //panel_Login.Left = 430;
        }

        private void ct_btnDangNhap_Click(object sender, EventArgs e)
        {
            
            //MessageBox.Show("Đăng Nhập Thành Công!","Thông báo");
            

            string tentk = txtUsername.Text;
            string pass = txtPass.Text;
            if(tentk.Trim() == "")
            {
                MessageBox.Show("Vui Lòng Nhập Tài Khoản!", "Thông Báo!"); 
            }
            else if (pass.Trim() == "")
            {
                MessageBox.Show("Vui Lòng Nhập Mật Khẩu!", "Thông Báo!");
            }
            else
            {
                string query = "Select * from TaiKhoan where UserName ='" + tentk + "' and Pass = '"+pass+"' ";
                TaiKhoan_DAL modify = new TaiKhoan_DAL();

                if(modify.TaiKhoans(query).Count !=0 )
                {

                    MessageBox.Show("Đăng Nhâp Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    panel_Login.Left = 334;
                    Form_Main formMain = new Form_Main();
                    formMain.ShowDialog();
                    panel_QuenPass.Visible = false;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên Tài Khoản Hoặc Mật Khẩu Không Chính Xác!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void panel_Login_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void ct_btnLayLaiPass_Click(object sender, EventArgs e)
        {
            
            string username = txtUser_QuenPas.Text;
            if( username .Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản đăng nhập!");
            }

            else
            {
                string query = "Select * From TaiKhoan Where UserName = N'" + txtUser_QuenPas.Text + "'";
                TaiKhoan_DAL modify = new TaiKhoan_DAL();
                if (modify.TaiKhoans(query).Count != 0)
                {
                    lblKetqua.ForeColor = Color.LightGreen;
                    lblKetqua.Text = "Mật khẩu: " + modify.TaiKhoans(query)[0].Pass1;
                }
                else
                {
                    lblKetqua.ForeColor = Color.Red;
                    lblKetqua.Text = "Tài khoản này chưa được đăng ký!";
                }
            }
        }
    }
}
