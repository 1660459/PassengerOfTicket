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
    public partial class frmHOTRO_Xe : Form
    {
        public frmHOTRO_Xe()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BUS_Xe xe = new BUS_Xe();
            dgvTraCuuChuyen.DataSource = xe.TimXe(txtTraCuu.Text);
        }

        private void frmHOTRO_Xe_Load(object sender, EventArgs e)
        {
            BUS_Xe xe = new BUS_Xe();
            dgvTraCuuChuyen.DataSource = xe.TimXe(" ");
        }
    }
}
