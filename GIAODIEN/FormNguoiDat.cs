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
    public partial class FormNguoiDat : Form
    {
        public FormNguoiDat()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void FormNguoiDat_Load(object sender, EventArgs e)
        {
            LoadFromNguoiDat();
        }
        public void LoadFromNguoiDat()
        {
            BUS_NguoiDat nd = new BUS_NguoiDat();
            dgvNguoiDat.DataSource = nd.LoadNguoiDat();
        }
    }
}
