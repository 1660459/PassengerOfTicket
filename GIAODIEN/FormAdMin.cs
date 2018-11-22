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
    public partial class FormAdMin : Form
    {
        public FormAdMin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //private void pictureBox1_Click_1(object sender, EventArgs e)
        //{

        //}

        private void button5_Click(object sender, EventArgs e)
        {
            FormQLTaiXe frm0 = new FormQLTaiXe();

            frm0.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormQLTuyenXe frm = new FormQLTuyenXe();

            frm.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormQLChuyenXe frm1 = new FormQLChuyenXe();

            frm1.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormQLXe frm2 = new FormQLXe();

            frm2.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormQLTram frm3 = new FormQLTram();

            frm3.Show();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }


    }
}
