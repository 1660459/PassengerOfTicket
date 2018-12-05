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
    public partial class FormQLGiaVe : Form
    {
        public FormQLGiaVe()
        {
            InitializeComponent();
        }

        private void Thoat(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Them_GiaVe(object sender, EventArgs e)
        {
            FormGiaVe frm = new FormGiaVe();
            frm.Show();
        }
    }
}
