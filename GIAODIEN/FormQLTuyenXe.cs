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
    public partial class FormQLTuyenXe : Form
    {
        public FormQLTuyenXe()
        {
            InitializeComponent();
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
            FormTuyenXe frm = new FormTuyenXe();
            frm.txtIDTuyen.Text = MaTXeTuTang();
            frm.ShowDialog();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSuaQLTuyenXe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IDDangChon))
            {
                MessageBox.Show("Click Vào Dòng muốn Sửa");
                return;
            }
            FormTuyenXe frm = new FormTuyenXe();
            frm.txtIDTuyen.Text = IDDangChon;
            frm.txtIDTuyen.Enabled = false;
            frm.ShowDialog();
        }

        private void btnXoaQLTuyenXe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IDDangChon))
            {
                MessageBox.Show("Click Vào Dòng muốn Xoá");
                return;
            }
            BUS_TuyenXe kh = new BUS_TuyenXe();
            if (kh.XoaTuyenXe(IDDangChon) == 1)
            {
                MessageBox.Show("Xoa Thanh Cong");
                LoadQLTuyenXe();
            }
            else
            {
                MessageBox.Show("Không Xoá Được");
            }
        }
        static string IDDangChon = null;
        private void dgvQLTuyenXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int num;
            num = e.RowIndex;
            IDDangChon = dgvQLTuyenXe.Rows[num].Cells[0].Value.ToString();
        }

        private void FormQLTuyenXe_Load(object sender, EventArgs e)
        {
            LoadQLTuyenXe();
        }
        public void LoadQLTuyenXe()
        {
            BUS_TuyenXe tx = new BUS_TuyenXe();
            dgvQLTuyenXe.DataSource = tx.LoadTuyenXe();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            LoadQLTuyenXe();
        }
        public string MaTXeTuTang()
        {
            int dem = 0;
            string temp = "T01";
            dem = dgvQLTuyenXe.RowCount;
            if (dem == 0)
            {
                return temp;
            }
            else
            {
                temp = dgvQLTuyenXe.Rows[dem - 1].Cells[0].Value.ToString();
                int p = int.Parse(temp.Substring(1)) + 1;
                temp = "T" + p.ToString("00");
                return temp;
            }
        }
    }
}
