using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIAODIEN
{
    public partial class FormQLReport : Form
    {
        public FormQLReport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChuyenXe_Click(object sender, EventArgs e)
        {
            CRView_ChuyenXe frm = new CRView_ChuyenXe();
            frm.Show();
        }
    }
}
