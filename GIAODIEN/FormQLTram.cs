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
    public partial class FormQLTram : Form
    {
        public FormQLTram()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void LoadQLTram()
        {
            BUS_Tram tram = new BUS_Tram();
            dgvDSTram.DataSource = tram.LoadTram();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
             if (string.IsNullOrEmpty(IDDangChon))
            {
                MessageBox.Show("Click Vào Dòng Muốn Sửa");
                return;
            }
            FormTram frm5 = new FormTram();
         
            frm5.txtIDTram.Text = IDDangChon;
            frm5.txtIDTram.Enabled = false;
            frm5.Show();

            LoadQLTram();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IDDangChon))
            {
                MessageBox.Show("Click Vào Dòng muốn Xoá");
                return;
            }
            BUS_Tram kh = new BUS_Tram();
            if (kh.XoaTram(IDDangChon) == 1)
            {
                MessageBox.Show("Xoa Thanh Cong");
                LoadQLTram();
            }
            else
            {
                MessageBox.Show("Không Xoá Được");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            LoadQLTram();
        }

        private void ThemTram(object sender, EventArgs e)
        {
            FormTram frm = new FormTram();
            frm.txtIDTram.Text = MaTramTuTang();
            frm.Show();

        }

        private void FormQLTram_Load(object sender, EventArgs e)
        {
            LoadQLTram();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            LoadQLTram();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            LoadQLTram();
        }
        public string MaTramTuTang()
        {
            int dem = 0;
            string temp = "TR01";
            dem = dgvDSTram.RowCount;
            if (dem == 0)
            {
                return temp;
            }
            else
            {
                temp = dgvDSTram.Rows[dem - 1].Cells[0].Value.ToString();
                int p = int.Parse(temp.Substring(2)) + 1;
                temp = "TR" + p.ToString("00");
                return temp;
            }
        }
        static string IDDangChon = null;
        private void dgvDSTram_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int num;
            num = e.RowIndex;
            IDDangChon = dgvDSTram.Rows[num].Cells[0].Value.ToString();
        }
    }
}
