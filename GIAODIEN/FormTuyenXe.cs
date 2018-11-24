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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLuuTTTuyenXe_Click(object sender, EventArgs e)
        {
            TuyenXe tx = new TuyenXe();
            tx.id_tuyen = txtIDTuyen.Text;
            tx.khoang_cach = float.Parse(txtKhoangCach.Text);
            tx.thoigianchay = int.Parse(txtThoiGianChay.Text);
            tx.tram_id_tram = txtIDTram1.Text;
            tx.tram_id_tram1 = txtIDTram2.Text;
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
}
