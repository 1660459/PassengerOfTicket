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
    public partial class FormQLGiamGia : Form
    {
        public FormQLGiamGia()
        {
            InitializeComponent();
        }
        public delegate void dGiamGia(double phantram);
        public event dGiamGia eGiamGia;
        void TruyenPhanTram(double a)
        {
            double PT = a;
            if (eGiamGia != null)
            {
                eGiamGia(PT);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            TruyenPhanTram(0.05);
            this.Close();
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            TruyenPhanTram(0.1);
            this.Close();
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            TruyenPhanTram(0.15);
            this.Close();
        }
    }
}
