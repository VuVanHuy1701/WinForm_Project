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
    public partial class Form_TienMat : Form
    {
        SqlConnection connection;
        SqlCommand SqlCommand;
        string strCon = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=QLY_Pos;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void load()
        {
            SqlCommand = connection.CreateCommand();
            SqlCommand.CommandText = "Select TienMat From DoanhThu";
            adapter.SelectCommand = SqlCommand;
            table.Clear();
            adapter.Fill(table);
            dtgv_TienMat.DataSource = table;

            dtgv_TienMat.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv_TienMat.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10);

            dtgv_TienMat.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv_TienMat.DefaultCellStyle.Font = new Font("Arial", 10);
        }

        public Form_TienMat()
        {
            InitializeComponent();
        }

        private void Form_TienMat_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(strCon);
            connection.Open();
            load();
        }
    }
}
