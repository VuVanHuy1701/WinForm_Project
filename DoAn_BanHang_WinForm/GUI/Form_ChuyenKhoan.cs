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

namespace GUI
{
    public partial class Form_ChuyenKhoan : Form
    {
        SqlConnection connection;
        SqlCommand SqlCommand;
        string strCon = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=QLY_Pos;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void load()
        {
            SqlCommand = connection.CreateCommand();
            SqlCommand.CommandText = "Select ChuyenKhoan From DoanhThu";
            adapter.SelectCommand = SqlCommand;
            table.Clear();
            adapter.Fill(table);
            dtgv_ChuyenKhoan.DataSource = table;

            dtgv_ChuyenKhoan.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv_ChuyenKhoan.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10);

            dtgv_ChuyenKhoan.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv_ChuyenKhoan.DefaultCellStyle.Font = new Font("Arial", 10);
        }
        public Form_ChuyenKhoan()
        {
            InitializeComponent();
        }

        private void Form_ChuyenKhoan_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(strCon);
            connection.Open();
            load();
        }
    }
}
