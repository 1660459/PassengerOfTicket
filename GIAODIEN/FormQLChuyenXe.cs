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
    public partial class FormQLChuyenXe : Form
    {
        public FormQLChuyenXe()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormChuyenXe frm = new FormChuyenXe();
            frm.txtIDChuyenXe.Text = MaChuyenXeTuTang();
            frm.Show();
        }

        private void FormQLChuyenXe_Load(object sender, EventArgs e)
        {
            LoadQLChuyenXe();
        }
        public void LoadQLChuyenXe()
        {
            BUS_ChuyenXe xeee = new BUS_ChuyenXe();
            dgvChuyenXe.DataSource = xeee.LoadChuyenXe();
        }

        private void btnSuaChuyenXe_Click(object sender, EventArgs e)
        {
            FormChuyenXe frm = new FormChuyenXe();
            frm.txtIDChuyenXe.Text = IDDangChon;
            frm.txtIDChuyenXe.Enabled = false;
            frm.Show();
        }
        static string IDDangChon = null;
        private void dgvChuyenXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int num;
            num = e.RowIndex;
            if (num < 0)
            {
                return;
            }
            IDDangChon = dgvChuyenXe.Rows[num].Cells[0].Value.ToString();
        }

        private void btnXoaChuyenXe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IDDangChon))
            {
                MessageBox.Show("Click Vào Dòng muốn Xoá");
                return;
            }
            BUS_ChuyenXe kh = new BUS_ChuyenXe();
            if (kh.XoaChuyenXe(IDDangChon) == 1)
            {
                MessageBox.Show("Xoa Thanh Cong");
                LoadQLChuyenXe();
            }
            else
            {
                MessageBox.Show("Không Xoá Được");
            }
        }
      
        public string MaChuyenXeTuTang()
        {
            int dem = 0;
            string temp = "C01";
            dem = dgvChuyenXe.RowCount;
            if (dem == 0)
            {
                return temp;
            }
            else
            {
                int p = 0, n = 0;
                foreach (DataGridViewRow row in dgvChuyenXe.Rows)
                {
                    temp = row.Cells[0].Value.ToString();
                    p = int.Parse(temp.Substring(1));
                    if (n < p)
                    {
                        n = p;
                    }
                }
                n += 1;
                temp = "C" + n.ToString("00");
                return temp;
            }
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            LoadQLChuyenXe();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            LoadQLChuyenXe();
        }
        
    }
}
