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
            cbChuyenXe1.DataSource = qlve.LoadGCChuyenXe();
            cbChuyenXe2.DataSource = qlve.LoadGCChuyenXe();
        }

        private void btnMaGhe1_Click(object sender, EventArgs e)
        {
            if(  cbLoaiXe1.SelectedItem.ToString() == "30 CHỖ")
            {
                FormGhe30 frm30 = new FormGhe30();
                frm30.eMaGhe += eMaGhe1_Event;
                frm30.Show();

            }
            else if (cbLoaiXe1.SelectedItem.ToString() == "45 CHỖ")
            {
                FormGhe45 frm45 = new FormGhe45();
                frm45.eMaGhe += eMaGhe1_Event;
                frm45.Show();
            }
            else
            {
                FormGN frmGN = new FormGN();
                frmGN.eMaGhe += eMaGhe1_Event;
                frmGN.Show();
            }

        }
        void eMaGhe1_Event(string a)
        {
            txtMaGhe1.Text = a;
        }
        private void btnMaGhe2_Click(object sender, EventArgs e)
        {
            if (cbLoaiXe2.SelectedItem.ToString() == "30 CHỖ")
            {
                FormGhe30 frm30 = new FormGhe30();
                frm30.eMaGhe += eMaGhe2_Event;
                frm30.Show();
            }
            else if (cbLoaiXe2.SelectedItem.ToString() == "45 CHỖ")
            {
                FormGhe45 frm45 = new FormGhe45();
                frm45.eMaGhe += eMaGhe2_Event;
                frm45.Show();
            }
            else
            {
                FormGN frmGN = new FormGN();
                frmGN.eMaGhe += eMaGhe2_Event;
                frmGN.Show();
            }
           
        }
        void eMaGhe2_Event(string a)
        {
            txtMaGhe2.Text = a;
        }

        private void cbLoaiXe1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaGhe1.Text = null;
        }
        
        private void cbLoaiXe2_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaGhe2.Text = null;
        }
       
    }
}