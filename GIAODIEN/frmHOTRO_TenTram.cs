using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XULY;
namespace GIAODIEN
{
    public partial class frmHOTRO_TenTram : Form
    {
        public frmHOTRO_TenTram()
        {
            InitializeComponent();
        }

        private void frmHOTRO_TenTram_Load(object sender, EventArgs e)
        {
            BUS_Tram tram = new BUS_Tram();
            dgvTraCuuTram.DataSource = tram.LoadTram();
        }

        private void txtTraCuu_TextChanged(object sender, EventArgs e)
        {
            BUS_Tram kh = new BUS_Tram();
            if (string.IsNullOrEmpty(txtTraCuu.Text))
            {
                dgvTraCuuTram.DataSource = kh.LoadTram();
            }
            else
                dgvTraCuuTram.DataSource = kh.TraCuuTram(txtTraCuu.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
