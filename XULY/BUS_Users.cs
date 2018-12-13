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
    }
}
