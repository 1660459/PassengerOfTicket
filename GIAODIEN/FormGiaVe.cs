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
    public partial class FormGiaVe : Form
    {
        public FormGiaVe()
        {
            InitializeComponent();
        }

        private void FormGiaVe_Load(object sender, EventArgs e)
        {

        }

        private void Thoat(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
