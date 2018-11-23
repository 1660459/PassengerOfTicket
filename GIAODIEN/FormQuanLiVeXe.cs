using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XULY;
namespace GIAODIEN
{
    public partial class FormQuanLiVeXe : Form
    {
        public FormQuanLiVeXe()
        {
            InitializeComponent();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormNguoiDat frm = new FormNguoiDat();
            frm.Show();
        }

        private void FormQuanLiVeXe_Load(object sender, EventArgs e)
        {
            LoadLoaiXe();
            LoadChuyenXe();
        }
        void LoadLoaiXe()
        {
            BUS_QuanLiVeXe qlve = new BUS_QuanLiVeXe();
            cbLoaiXe1.DataSource = qlve.LoadTenLoaiXe();
            cbLoaiXe2.DataSource = qlve.LoadTenLoaiXe();
        }
        void LoadChuyenXe()
        {
            BUS_QuanLiVeXe qlve = new BUS_QuanLiVeXe();
            cbLoaiXe1.DataSource = qlve.LoadGCChuyenXe();
            cbLoaiXe2.DataSource = qlve.LoadGCChuyenXe();
        }
    }
}