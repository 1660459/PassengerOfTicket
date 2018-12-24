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
    public partial class FormDoiMK : Form
    {
        string Tk;
        public FormDoiMK(string tenTK)
        {
            InitializeComponent();
            Tk = tenTK;
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            XULY.BUS_Users bususer = new XULY.BUS_Users();
            if (bususer.User_AuthenDoiMK(Tk, txtMKCu) != 0)
            {
              if(txtMKMoi.Text != txtXacNhan.Text)
              {
                  MessageBox.Show("Mật khẩu nhập lại không chính xác");
              }
              else
              {
                  int id = bususer.User_FindID(Tk,txtMKCu);
                  bususer.User_ChangePass(txtMKMoi, id);
                  MessageBox.Show("Đổi mật khẩu thành công");
              }
            }
            else
            {
                MessageBox.Show("Sai Mật Khẩu cũ");
                return;
            }
        }
    }
}
