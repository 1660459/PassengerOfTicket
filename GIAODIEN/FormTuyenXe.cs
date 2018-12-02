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
    public partial class FormTuyenXe : Form
    {
        public FormTuyenXe()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            txtIDTuyen.Enabled = true;
        }

       

        private void label3_Click(object sender, EventArgs e)
        {

        }
        bool KTRONG()
        {
            if (string.IsNullOrEmpty(txtIDTuyen.Text))
            {
                MessageBox.Show("hãy điền vào ID tuyến xe ");
                return false;
            }
            if (string.IsNullOrEmpty(txtKhoangCach.Text))
            {
                MessageBox.Show("hãy điền vào khoảng cách");
                return false;
            }

            if (string.IsNullOrEmpty(txtThoiGianChay.Text))
            {
                MessageBox.Show("hãy điền thời gian chạy");
                return false;
            }
            if (string.IsNullOrEmpty(cbTram01.SelectedItem.ToString()))
            {
                MessageBox.Show("hãy chọn trạm xe 1");
                return false;
            }
            if (string.IsNullOrEmpty(cbTram02.SelectedItem.ToString()))
            {
                MessageBox.Show("hãy chọn trạm xe 2");
                return false;
            }
            return true;
        }
        private void btnLuuTTTuyenXe_Click(object sender, EventArgs e)
        {
            if (KTRONG() == false)
            {
                return;
            }
            else
            {
                TuyenXe tx = new TuyenXe();
                tx.id_tuyen = txtIDTuyen.Text;
                tx.khoang_cach = float.Parse(txtKhoangCach.Text);
                tx.thoigianchay = int.Parse(txtThoiGianChay.Text);
                tx.tram_id_tram = cbTram01.SelectedItem.ToString();
                tx.tram_id_tram1 = cbTram02.SelectedItem.ToString();
                BUS_TuyenXe TuyenX = new BUS_TuyenXe();
                if (txtIDTuyen.Enabled == true)
                {
                    if (TuyenX.ThemTuyenXe(tx) == 1)
                    {
                        MessageBox.Show("Thêm thành công");
                        FormQLTuyenXe qlTXe = new FormQLTuyenXe();
                        qlTXe.LoadQLTuyenXe();
                        this.Close();
                    }
                    else if (TuyenX.ThemTuyenXe(tx) == -1)
                    {
                        MessageBox.Show("Không Được Trùng ID");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Không Thêm Được");
                        return;
                    }
                }
                else
                {
                    if (TuyenX.SuaTuyenXe(tx) == 1)
                    {
                        MessageBox.Show("Sửa thành công");
                        FormQLTuyenXe qlTXe = new FormQLTuyenXe();
                        qlTXe.LoadQLTuyenXe();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Không Sửa Được");
                        return;
                    }
                }

                txtIDTuyen.Enabled = true;
            }
        }

        private void FormTuyenXe_Load(object sender, EventArgs e)
        {
            BUS_TuyenXe tx = new BUS_TuyenXe();
            cbTram01.DataSource = tx.LoadIDTram();
            cbTram02.DataSource = tx.LoadIDTram();
        }

        
    }
}
