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
using DAL;
using DTO;
using BLL;

namespace GUI
{

    public partial class Form_TongTien : Form
    {
        private string tien;

        public Form_TongTien()
        {
            InitializeComponent();
        }

        public Form_TongTien(string tien)
        {
            InitializeComponent();
            this.tien = tien;
        }

        private void Form_TongTien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_ThanhToan.ThanhToan' table. You can move, or remove it, as needed.
            this.thanhToanTableAdapter.Fill(this.dataSet_ThanhToan.ThanhToan);
            txtTongCong.Text = tien;        
        }

      

        private void btn100K_Click(object sender, EventArgs e)
        {

        }

        private void btn200K_Click(object sender, EventArgs e)
        {

        }

        private void btn500K_Click(object sender, EventArgs e)
        {

        }

        private void btn50K_Click(object sender, EventArgs e)
        {

        }

        private void btnBackToOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtTongCong_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
