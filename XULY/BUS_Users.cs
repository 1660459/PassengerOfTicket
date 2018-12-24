using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DULIEU;
namespace XULY
{
    public class BUS_Users
    {
       public int User_Authen(TextBox id,TextBox pass)
        {
            DAO_Users user = new DAO_Users();
            return user.Authenticate(id.Text, pass.Text);
        }
        public int User_AuthenDoiMK(string id,TextBox pass)
        {
            DAO_Users user = new DAO_Users();
            return user.Authenticate(id, pass.Text);
        }
        public void User_ChangePass(TextBox MkMoi,int ID)
        {
            DAO_Users daUser = new DAO_Users();
            daUser.UpdateMatKhau(ID, MkMoi.Text);
        }
        public int User_FindID(string tk,TextBox MkCu)
        {
            DAO_Users daUser = new DAO_Users();
            return daUser.FindIDUser(tk, MkCu.Text);
        }
    }
}
