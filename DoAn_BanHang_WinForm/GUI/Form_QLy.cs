using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GUI
{
    public partial class Form_QLy : Form
    {
        public Form_QLy()
        {
            InitializeComponent();
        }

        private void Form_QLy_Load(object sender, EventArgs e)
        {
            OpenChildForm(new Form_TongQuan());

        }

        // Tạo đối tượng Form con để trỏ vào các form con muốn mở
        private Form curentFormChild;
        private void OpenChildForm(Form ChildForm)
        {
            
            if (curentFormChild != null)
            {
                curentFormChild.Close();
            }
           
            curentFormChild = ChildForm;
            ChildForm.TopLevel = false;
           
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;

            ChildForm.Anchor = AnchorStyles.Top;
            
            Form_QLy form_QLy = new Form_QLy();
            

            grb_Form_QLy.Controls.Add(ChildForm);
            grb_Form_QLy.Tag = ChildForm;

            
            //panel1.Controls.Add(ChildForm);
            //panel1.Tag = ChildForm;
            
            ChildForm.BringToFront();
            ChildForm.Show();
        
        }

        
        // Mở form con tổng quan trong Form_QLy
        private void tongQuan_toolStrip_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_TongQuan());
            grb_Form_QLy.Text = "Tổng Quan";
            
            
        }

        // Mở form con quản lý mặt hàng trong Form_QLy
        private void qlyMatHang_ToolStripMenu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_QLy_MatHang());
            grb_Form_QLy.Text = "Quản Lý Mặt Hàng";
        }

        // Mở form con thống kê trong Form_QLy
        private void thongKe_toolStripMenu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_ThongKe());
            grb_Form_QLy.Text = "Thống kê";
        }

        // Mở form con tiền mặt trong Form_QLy
        private void tienMat_ToolStripMenu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_TienMat());
            grb_Form_QLy.Text = "Tiền Mặt";
        }

        // Mở form con chuyển khoản trong Form_QLy
        private void chuyenKhoan_ToolStripMenu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_ChuyenKhoan());
            grb_Form_QLy.Text = "Chuyển Khoản";
        }

        // Mở form con tổng kết cuối ngày trong Form_QLy
        private void tongKet_toolStripMenu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_TongKet());
            grb_Form_QLy.Text = "Tổng Kết Cuối Ngày";
        }

        // Mở form con báo cáo bán hàng trong Form_QLy
        private void baoCaoBan_toolStripMenu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_BaoCaoBan());
            grb_Form_QLy.Text = "Báo Cáo Bán Hàng";
        }

        // Mở form con kết quả kinh doanh trong Form_QLy
        private void ketQuaKD_toolStripMenu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_KetQuaKD());
            grb_Form_QLy.Text = "Kết Quả Kinh Doanh";
        }

        // Mở form con Quản lý tài khoản trong Form_QLy
        private void quanLyTaiKhoanToolStripMenu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_QLy_TaiKhoan());
            grb_Form_QLy.Text = "Quản Lý Tài Khoản";
        }

        private void MauXanh_Click(object sender, EventArgs e)
        {
            if (MauXanh.CanSelect)
            {
                panel_Form_QuanLy.BackColor = Color.LightGreen;
            }
        }
        private void MauDo_Click(object sender, EventArgs e)
        {
            if (MauDo.CanSelect)
            {
                panel_Form_QuanLy.BackColor = Color.OrangeRed;
            }
        }
        private void MauVang_Click(object sender, EventArgs e)
        {
            if (MauVang.CanSelect)
            {
                panel_Form_QuanLy.BackColor = Color.LightYellow;
            }
        }
        private void MauDaTroi_Click(object sender, EventArgs e)
        {
            if (MauDaTroi.CanSelect)
            {
                panel_Form_QuanLy.BackColor = Color.LightSkyBlue;
            }
        }
        private void MauCam_Click(object sender, EventArgs e)
        {
            if (MauCam.CanSelect)
            {
                panel_Form_QuanLy.BackColor = Color.Orange;
            }
        }

        private void panel_Form_QuanLy_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolsVeTrangDH_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Main form_Main = new Form_Main();
            form_Main.ShowDialog();
        }

        private void picShop_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Main form_Main = new Form_Main();
            form_Main.ShowDialog();
            
        }

        
    }
}
