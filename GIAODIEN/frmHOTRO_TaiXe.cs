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
    public partial class frmHOTRO_TaiXe : Form
    {
        public frmHOTRO_TaiXe()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BUS_TaiXe tx = new BUS_TaiXe();
            if (string.IsNullOrEmpty(txtTraCuu.Text))
            {
                dgvTraCuu.DataSource = tx.LoadTaiXe();
            }
            else
                dgvTraCuu.DataSource = tx.TimTaiXe(txtTraCuu.Text);
        }

        private void frmHOTRO_TaiXe_Load(object sender, EventArgs e)
        {
            BUS_TaiXe tx = new BUS_TaiXe();
            dgvTraCuu.DataSource = tx.LoadTaiXe();
        }
    }
}
