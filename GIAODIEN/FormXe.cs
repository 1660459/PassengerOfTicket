using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DULIEU;
using XULY;
namespace GIAODIEN
{
    public partial class FormXe : Form
    {
        public FormXe()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemXe_Click(object sender, EventArgs e)
        {
            Xe tempXe = new Xe();
            tempXe.xe_id = txtIDXe.Text;
            tempXe.ten_xe = txtTenXe.Text;
            tempXe.so_dang_ky = txtSoDangKy.Text;
            tempXe.loaixe_id_loaixe = txtLoaiXe.Text;
            BUS_Xe xe = new BUS_Xe();
            if (txtIDXe.Enabled == true)
            {
                if (xe.ThemXe(tempXe) == 1)
                {
                    
                    FormQLXe qlXe = new FormQLXe();
                    qlXe.LoadQLXe();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không Thêm Được");
                    return;
                }
            }
            else
            {
                if (xe.SuaXe(tempXe) == 1)
                {
                  
                    FormQLXe qlXe = new FormQLXe();
                    qlXe.LoadQLXe();  
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không Sửa Được");
                    return;
                }
            }
            txtIDXe.Enabled = true;
        }
    }
}
