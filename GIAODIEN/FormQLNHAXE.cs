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
    public partial class FormQLNHAXE : Form
    {
        public FormQLNHAXE()
        {
            InitializeComponent();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            FormLoaiXe frm2 = new FormLoaiXe();
            frm2.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            FormTram frm = new FormTram();
            frm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FormAdMin frm3 = new FormAdMin();
            frm3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormTaiXe frm4 = new FormTaiXe();
            frm4.ShowDialog();
        }
    }
}
