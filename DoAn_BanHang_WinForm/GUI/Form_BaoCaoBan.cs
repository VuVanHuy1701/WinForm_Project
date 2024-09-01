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
    public partial class Form_BaoCaoBan : Form
    {
        public Form_BaoCaoBan()
        {
            InitializeComponent();
        }

        private void Form_BaoCaoBan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet_BaoCao.HoaDon' table. You can move, or remove it, as needed.
            this.HoaDonTableAdapter.Fill(this.DataSet_BaoCao.HoaDon);

            this.reportViewer1.RefreshReport();
        }
    }
}
