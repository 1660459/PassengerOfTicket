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
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XULY.BUS_Users bususer = new XULY.BUS_Users();
            if (bususer.User_Authen(txtTaiKhoang,txtMatKhau) != 0 )
            {
                FormAdMin frm = new FormAdMin();
                this.Hide();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Sai Mật Khẩu");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
