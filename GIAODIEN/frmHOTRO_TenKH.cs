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
    public partial class frmHOTRO_TenKH : Form
    {
        public frmHOTRO_TenKH()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BUS_KhachHang kh = new BUS_KhachHang();
            if (string.IsNullOrEmpty(txtTimKiem.Text))
            {
                dgvTimKH.DataSource = kh.LoadKH();
            }
            else
                dgvTimKH.DataSource = kh.TimKhachHang(txtTimKiem.Text);
        }

        private void frmHOTRO_TenKH_Load(object sender, EventArgs e)
        {
            BUS_KhachHang kh = new BUS_KhachHang();
            dgvTimKH.DataSource = kh.TimKhachHang(" ");
        }

    

        

        
    }
}
