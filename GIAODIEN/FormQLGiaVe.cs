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
    public partial class FormQLGiaVe : Form
    {
        public FormQLGiaVe()
        {
            InitializeComponent();
        }

        private void Thoat(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Them_GiaVe(object sender, EventArgs e)
        {
            FormGiaVe frm = new FormGiaVe();
            frm.txtIDVe.Text = SttTang().ToString();
            frm.Show();
        }
        static int STT = -1;
        static string IDDangChon = null;
        private void dgvDanhSachGiaVe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int num;
            num = e.RowIndex;
            if (num < 0)
            {
                return;
            }
            STT = int.Parse(dgvDanhSachGiaVe.Rows[num].Cells[0].Value.ToString());
            IDDangChon = dgvDanhSachGiaVe.Rows[num].Cells[1].Value.ToString();
        }

        private void FormQLGiaVe_Load(object sender, EventArgs e)
        {
            LoadQLGiaVe();
        }
        void LoadQLGiaVe()
        {
            BUS_Ve xe = new BUS_Ve();
            dgvDanhSachGiaVe.DataSource = xe.LoadGiaVe();
        }

        private void btnXoaDSXe_Click(object sender, EventArgs e)
        {
            string temp = STT.ToString();
            if (string.IsNullOrEmpty(IDDangChon) || string.IsNullOrEmpty(temp))
            {
                MessageBox.Show("Click Vào Dòng muốn Xoá");
                return;
            }
            BUS_Ve kh = new BUS_Ve();
            if (kh.XoaGiaVe(STT,IDDangChon) == 1)
            {
                MessageBox.Show("Xoa Thanh Cong");
                LoadQLGiaVe();
            }
            else
            {
                MessageBox.Show("Không Xoá Được");
            }
        }

        private void btnSuaDSXe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IDDangChon) || string.IsNullOrEmpty(STT.ToString()))
            {
                MessageBox.Show("Click Vào Dòng Muốn Sửa");
                return;
            }
            FormGiaVe frm4 = new FormGiaVe();
            frm4.txtIDVe.Text = STT.ToString();
            frm4.txtIDVe.Enabled = false;
            frm4.cbIDTuyenXe.SelectedItem = IDDangChon;
            frm4.cbIDTuyenXe.Enabled = false;
            frm4.Show();
        }
        
        int SttTang()
        {
            int dem = 0;
            int temp = 1;
            dem = dgvDanhSachGiaVe.RowCount;
            if (dem == 0)
            {
                return temp;
            }
            else
            {
                foreach (DataGridViewRow row in dgvDanhSachGiaVe.Rows)
                {
                    if (temp < int.Parse(row.Cells[0].Value.ToString()))
                    {
                        temp = int.Parse(row.Cells[0].Value.ToString());
                    }
                }
                temp += 1;
                return temp;
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            LoadQLGiaVe();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            LoadQLGiaVe();
        }
    }
}
