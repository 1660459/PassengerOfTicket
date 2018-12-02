
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
    public partial class FormTram : Form
    {
        public FormTram()
        {
            InitializeComponent();
        }



        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        bool KTRONG()
        {
            if (string.IsNullOrEmpty(txtIDTram.Text))
            {
                MessageBox.Show("hãy điền vào ID trạm ");
                return false;
            }
            if (string.IsNullOrEmpty(txtTenTram.Text))
            {
                MessageBox.Show("hãy điền vào tên trạm");
                return false;
            }

            if (string.IsNullOrEmpty(txtDiaDiem.Text))
            {
                MessageBox.Show("hãy điền vào địa điểm");
                return false;
            }
          
            return true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KTRONG() == false)
            {
                return;
            }
            else
            {
                Tram tempTram = new Tram();
                tempTram.id_tram = txtIDTram.Text;
                tempTram.ten_tram = txtTenTram.Text;
                tempTram.dia_diem = txtDiaDiem.Text;
                BUS_Tram tram = new BUS_Tram();

                if (txtIDTram.Enabled == true)
                {
                    if (tram.ThemTram(tempTram) == 1)
                    {
                        FormQLTram qlTram = new FormQLTram();

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
                    if (tram.SuaTram(tempTram) == 1)
                    {

                        FormQLTram qlTram = new FormQLTram();
                        qlTram.LoadQLTram();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Không Sửa Được");
                        return;
                    }
                }
                txtIDTram.Enabled = true;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
