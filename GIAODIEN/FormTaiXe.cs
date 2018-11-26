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
    public partial class FormTaiXe : Form
    {
        public FormTaiXe()
        {
            InitializeComponent();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            TaiXe tai_xe = new TaiXe();
            tai_xe.id_taixe = txtId.Text;
            tai_xe.tentaixe = txtHT.Text;
            tai_xe.banglai = txtBL.Text;
            BUS_TaiXe busTx = new BUS_TaiXe();

            if (txtId.Enabled == true)
            {
                if (busTx.ThemTaiXe(tai_xe) == 1)
                {
                    FormTaiXe qltx = new FormTaiXe();
                    busTx.LoadTaiXe();
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
                if (busTx.SuaTaiXe(tai_xe) == 1)
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
            txtId.Enabled = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
