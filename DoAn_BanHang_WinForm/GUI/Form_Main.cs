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
    public partial class Form_Main : Form
    {
        SqlConnection connection;
        SqlCommand SqlCommand;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        DataTable tableOrder = new DataTable();
        string Lenh;
        SqlDataReader DocDuLieu;
        string strCon = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=QLY_Pos;Integrated Security=True";
        void load()
        {
            SqlCommand = connection.CreateCommand();
            SqlCommand.CommandText = @"Select   MatHang.MaMatHang, MatHang.TenMon, MatHang.Gia, MatHang.HinhAnh
                                       From     MatHang";
            adapter.SelectCommand = SqlCommand;
            table.Clear();
            adapter.Fill(table);
            dtgv_SanPham.DataSource = table;
            dtgv_SanPham.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv_SanPham.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10);

            dtgv_SanPham.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv_SanPham.DefaultCellStyle.Font = new Font("Arial", 10);
            
        }
        void loadOrder()
        {
            SqlCommand = connection.CreateCommand();
            SqlCommand.CommandText = "Select * From Oder";
            adapter.SelectCommand = SqlCommand;
            tableOrder.Clear();
            adapter.Fill(tableOrder);
            dtgv_Order.DataSource = tableOrder;
            dtgv_Order.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv_Order.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10);

            dtgv_Order.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv_Order.DefaultCellStyle.Font = new Font("Arial", 10);

        }
        public Form_Main()
        {
            InitializeComponent();
            loadTheLoai();
            
        }
        public void loadTheLoai()
        {
            cbbTheLoai.Items.Clear();
            connection = new SqlConnection(strCon);
            Lenh = @"Select TenTheLoai From TheLoai";
            connection.Open();
            SqlCommand = new SqlCommand(Lenh, connection);
            DocDuLieu = SqlCommand.ExecuteReader();
            while (DocDuLieu.Read())
            {
                cbbTheLoai.Items.Add(DocDuLieu[0].ToString());
            }
            connection.Close();
        }
        private void cbbTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand = connection.CreateCommand();
            SqlCommand.CommandText = @"SELECT   MatHang.MaMatHang, MatHang.TenMon, MatHang.Gia, MatHang.HinhAnh
                                       FROM     MatHang INNER JOIN
                                                TheLoai ON MatHang.MaTheLoai = TheLoai.MaTheloai
                                       WHERE    (TheLoai.TenTheLoai = N'" + cbbTheLoai.Text + "')";
            adapter.SelectCommand = SqlCommand;
            table.Clear();
            adapter.Fill(table);
            dtgv_SanPham.DataSource = table;

        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_HangHoa.TheLoai' table. You can move, or remove it, as needed.
          
            
            connection = new SqlConnection(strCon);
            connection.Open();
            load();
            loadOrder();

            
           
        }
        
        //tạo form con
        private Form curentFormChild;
        private void OpenChildForm(Form ChildForm)
        {
            if(curentFormChild != null)
            {
                curentFormChild.Close();
            }
            curentFormChild = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Right;

            ChildForm.Anchor = AnchorStyles.Top;
            ChildForm.Anchor = AnchorStyles.Right;
            
            grbSanPham.Controls.Add(ChildForm);
            grbSanPham.Tag = ChildForm;
            //panel1.Controls.Add(ChildForm);
            //panel1.Tag = ChildForm;
            
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void btnTongTien_Click(object sender, EventArgs e)
        {
            
            OpenChildForm(new Form_TongTien(txtSum.Text));

           
            
        }

        private void toolsMauXanh_Click(object sender, EventArgs e)
        {
            if (toolsMauXanh.CanSelect)
            {
                panel1.BackColor = Color.LightGreen; //Đổi màu panelmenu Form_Main

                //Đổi màu các nút bấm Form_Main
                btnCheBien.BackColor = Color.LightGreen;
                btnTongTien.BackColor = Color.LightGreen;
                btnTamTinh.BackColor = Color.LightGreen;
                btnXoaHet.BackColor = Color.LightGreen;
                btnThanhToan.BackColor = Color.LightGreen;

                btn_NuocUong.BackColor = Color.LightGreen;
                btn_Banh.BackColor = Color.LightGreen;
                btnHienThi.BackColor = Color.LightGreen;
                btn_Order.BackColor = Color.LightGreen;
            }
        }

        private void toolsMauDo_Click(object sender, EventArgs e)
        {
            if (toolsMauDo.CanSelect)
            {
                panel1.BackColor = Color.OrangeRed;

                btnCheBien.BackColor = Color.OrangeRed;
                btnTongTien.BackColor = Color.OrangeRed;
                btnTamTinh.BackColor = Color.OrangeRed;
                btnXoaHet.BackColor = Color.OrangeRed;
                btnThanhToan.BackColor = Color.OrangeRed;

                btn_NuocUong.BackColor = Color.OrangeRed;
                btn_Banh.BackColor = Color.OrangeRed;
                btnHienThi.BackColor = Color.OrangeRed;
                btn_Order.BackColor = Color.OrangeRed;
            }
        }

        private void toolsMauVang_Click(object sender, EventArgs e)
        {
            if (toolsMauVang.CanSelect)
            {
                panel1.BackColor = Color.LightYellow;

                btnCheBien.BackColor = Color.LightYellow;
                btnTongTien.BackColor = Color.LightYellow;
                btnTamTinh.BackColor = Color.LightYellow;
                btnXoaHet.BackColor = Color.LightYellow;
                btnThanhToan.BackColor = Color.LightYellow;

                btn_NuocUong.BackColor = Color.LightYellow;
                btn_Banh.BackColor = Color.LightYellow;
                btnHienThi.BackColor = Color.LightYellow;
                btn_Order.BackColor = Color.LightYellow;

                btnCheBien.ForeColor = Color.Black;
                btnTongTien.ForeColor = Color.Black;
                btnTamTinh.ForeColor = Color.Black;
                btnXoaHet.ForeColor = Color.Black;
                btn_NuocUong.ForeColor = Color.Black;
                btn_Banh.ForeColor = Color.Black;
                btnHienThi.ForeColor = Color.Black;
                btn_Order.ForeColor = Color.Black;
                btnThanhToan.ForeColor = Color.Black;
            }
        }

        private void toolsDaTroi_Click(object sender, EventArgs e)
        {
            if (toolsDaTroi.CanSelect)
            {
                panel1.BackColor = Color.LightSkyBlue;

                btnCheBien.BackColor = Color.LightSkyBlue;
                btnTongTien.BackColor = Color.LightSkyBlue;
                btnTamTinh.BackColor = Color.LightSkyBlue;
                btnXoaHet.BackColor = Color.LightSkyBlue;
                btnThanhToan.BackColor = Color.LightSkyBlue;

                btn_NuocUong.BackColor = Color.LightSkyBlue;
                btn_Banh.BackColor = Color.LightSkyBlue;
                btnHienThi.BackColor = Color.LightSkyBlue;
                btn_Order.BackColor = Color.LightSkyBlue;
            }
        }
     
        private void toolsMauCam_Click(object sender, EventArgs e)
        {
            if (toolsMauCam.CanSelect)
            {
                panel1.BackColor = Color.Orange;

                btnCheBien.BackColor = Color.Orange;
                btnTongTien.BackColor = Color.Orange;
                btnTamTinh.BackColor = Color.Orange;
                btnXoaHet.BackColor = Color.Orange;
                btnThanhToan.BackColor = Color.Orange;

                btn_NuocUong.BackColor = Color.Orange;
                btn_Banh.BackColor = Color.Orange;
                btnHienThi.BackColor = Color.Orange;
                btn_Order.BackColor = Color.Orange;
            }
        }

        private void trangQuanLyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_QLy formQLy = new Form_QLy();
            formQLy.ShowDialog();
        }

        private void picShopping_Click(object sender, EventArgs e)
        {
            lblPos.Text = "Pos";
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolsDoiMau_Click(object sender, EventArgs e)
        {

        }

        private void toolsDangXuat_FMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Login form_Login = new Form_Login();
            form_Login.ShowDialog();
            this.Close();
        }

        //Hiển thị danh sách nước uống
        private void btn_NuocUong_Click(object sender, EventArgs e)
        {
            SqlCommand = connection.CreateCommand();
            SqlCommand.CommandText = @"Select   MatHang.MaMatHang, MatHang.TenMon, MatHang.Gia
                                       From     MatHang
                                       WHERE    MatHang.MaTheLoai Like '1%' ";
            adapter.SelectCommand = SqlCommand;
            table.Clear();
            adapter.Fill(table);
            dtgv_SanPham.DataSource = table;
        }

        //Hiển thị danh sách bánh
        private void btn_Banh_Click(object sender, EventArgs e)
        {
            SqlCommand = connection.CreateCommand();
            SqlCommand.CommandText = @"Select   MatHang.MaMatHang, MatHang.TenMon, MatHang.Gia
                                       From     MatHang 
                                       WHERE    MatHang.MaTheLoai Like '2%' ";
            adapter.SelectCommand = SqlCommand;
            table.Clear();
            adapter.Fill(table);
            dtgv_SanPham.DataSource = table;
        }

        //Hiển thị tất cả sản phẩm
        private void btnHienThi_Click(object sender, EventArgs e)
        {
            load();
        }
        private void dtgv_SanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtgv_SanPham.CurrentRow.Index;
            txtTenMon_Order.Text = dtgv_SanPham.Rows[i].Cells[1].Value.ToString();
            txtGia_Order.Text = dtgv_SanPham.Rows[i].Cells[2].Value.ToString();
            txtSoLuong.Text = "1";
        }


        private void btn_Order_Click_1(object sender, EventArgs e)
        {

            

            if (txtTenMon_Order.Text == "" || txtGia_Order.Text == "" || txtSoLuong.Text == "" )
            {
                MessageBox.Show("Chưa nhập món", "Thông báo");
            }
            else
            {
                SqlCommand = connection.CreateCommand();
                SqlCommand.CommandText = "Insert into Oder Values( N'" + txtTenMon_Order.Text + "', '" + txtGia_Order.Text + "', '" + txtSoLuong.Text + "')";
                SqlCommand.ExecuteNonQuery();
                loadOrder();
            }

            //Tính tổng tiền sản phẩm order
            txtSum.Text = (from DataGridViewRow row in dtgv_Order.Rows
                           where row.Cells[0].FormattedValue.ToString() != string.Empty
                           select Convert.ToDouble(row.Cells[1].FormattedValue)).Sum().ToString();
            //Tính tổng sổ lượng sản phẩm order
            txtSum_SoLuong.Text = (from DataGridViewRow row in dtgv_Order.Rows
                           where row.Cells[0].FormattedValue.ToString() != string.Empty
                           select Convert.ToDouble(row.Cells[2].FormattedValue)).Sum().ToString();

            txtTenMon_Order.Clear();
            txtGia_Order.Clear();
            txtSoLuong.Clear();
        }

        //Phương thức thanh toán 
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            SqlCommand = connection.CreateCommand();
            SqlCommand.CommandText = @"delete Oder";
            adapter.SelectCommand = SqlCommand;
            tableOrder.Clear();
            adapter.Fill(tableOrder);
            dtgv_Order.DataSource = tableOrder;

            
            SqlCommand.CommandText = "Insert into DoanhThu Values('" + txtSum.Text + "', '" + txtSum.Text + "', '" + txtSum.Text + "') ";
            
            SqlCommand.ExecuteNonQuery(); 
            
            txtSum.Clear();
            txtSum_SoLuong.Clear();

            MessageBox.Show("Thanh toán thành công", "Thông báo!");
        }

        //Chức năng xóa hết sản phẩm
        private void btnXoaHet_Click(object sender, EventArgs e)
        {
            SqlCommand = connection.CreateCommand();
            SqlCommand.CommandText = @"delete Oder";
            adapter.SelectCommand = SqlCommand;
            tableOrder.Clear();
            adapter.Fill(tableOrder);
            dtgv_Order.DataSource = tableOrder;

            txtSum.Clear();
            txtSum_SoLuong.Clear();
        }

        //Chức năng tìm kiếm click
        private void picTimKiem_Click(object sender, EventArgs e)
        {
            SqlCommand = connection.CreateCommand();
            SqlCommand.CommandText = @"SELECT   MatHang.TenMon, MatHang.Gia, Mathang.HinhAnh 
                                       FROM     MatHang
                                       WHERE    (MatHang.TenMon Like '%" + txtTimKiem.Text + "%')";
            adapter.SelectCommand = SqlCommand;
            table.Clear();
            adapter.Fill(table);
            dtgv_SanPham.DataSource = table;
        }

        //Chức năng tìm kiếm trực tiếp trên thanh textbox
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            SqlCommand = connection.CreateCommand();
            SqlCommand.CommandText = @"SELECT   MatHang.TenMon, MatHang.Gia, Mathang.HinhAnh 
                                       FROM     MatHang 
                                       WHERE    (MatHang.TenMon Like '%" + txtTimKiem.Text + "%')";
            adapter.SelectCommand = SqlCommand;
            table.Clear();
            adapter.Fill(table);
            dtgv_SanPham.DataSource = table;

        }
        private void groupBox_Enter(object sender, EventArgs e)
        {

        }

        private void btnCheBien_Click(object sender, EventArgs e)
        {
            
        }

     
        private void dtgv_Order_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtSum_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
