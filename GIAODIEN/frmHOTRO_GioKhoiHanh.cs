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
    public partial class frmHOTRO_GioKhoiHanh : Form
    {
        public frmHOTRO_GioKhoiHanh()
        {
            InitializeComponent();
        }

        private void frmHOTRO_GioKhoiHanh_Load(object sender, EventArgs e)
        {
            BUS_ChuyenXe cx = new BUS_ChuyenXe();
            dgvTraCuu.DataSource = cx.LoadGioKhoiHanh();
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            BUS_ChuyenXe tx = new BUS_ChuyenXe();
            if (string.IsNullOrEmpty(txtTim.Text))
            {
                dgvTraCuu.DataSource = tx.LoadGioKhoiHanh();
            }
            else
                dgvTraCuu.DataSource = tx.TimGioKhoiHanh(txtTim.Text);
        }
    }
}
