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
        bool KTRONG()
        {
            if (string.IsNullOrEmpty(txtIDXe.Text))
            {
                MessageBox.Show("hãy điền vào ID xe ");
                return false;
            }
            if (string.IsNullOrEmpty(txtTenXe.Text))
            {
                MessageBox.Show("hãy điền vào tên xe");
                return false;
            }

            if (string.IsNullOrEmpty(txtSoDangKy.Text))
            {
                MessageBox.Show("hãy điền vào số đăng ký");
                return false;
            }
            if (string.IsNullOrEmpty(cbLoaiXe.SelectedItem.ToString()))
            {
                MessageBox.Show("hãy chọn loại xe");
                return false;
            }
            return true;
        }
        private void btnThemXe_Click(object sender, EventArgs e)
        {
            if (KTRONG() == false)
            {
                return;
            }
            else
            {
                Xe tempXe = new Xe();
                tempXe.xe_id = txtIDXe.Text;
                tempXe.ten_xe = txtTenXe.Text;
                tempXe.so_dang_ky = txtSoDangKy.Text;
                tempXe.loaixe_id_loaixe = cbLoaiXe.SelectedItem.ToString();
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormXe_Load(object sender, EventArgs e)
        {
            BUS_Xe xe = new BUS_Xe();
            cbLoaiXe.DataSource = xe.LoadLoaiXe();
        }
    }
}
