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
    public partial class frmHOTRO_Tuyen : Form
    {
        public frmHOTRO_Tuyen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmHOTRO_Tuyen_Load(object sender, EventArgs e)
        {
            BUS_TuyenXe tx = new BUS_TuyenXe();
            dgvTimTuyen.DataSource = tx.LoadTuyenXe();
        }
    }
}
