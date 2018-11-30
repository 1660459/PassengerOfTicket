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
    public partial class FormQLXe : Form
    {
        public FormQLXe()
        {
            InitializeComponent();
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    FormXe frm = new FormXe();
        //    frm.Show();            
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormQLXe_Load(object sender, EventArgs e)
        {
            LoadQLXe();
        }
        public void LoadQLXe()
        {
            BUS_Xe xe = new BUS_Xe();
            dgvDanhSachXe.DataSource = xe.LoadXe();
        }
        static string IDDangChon = null;
        private void dgvDanhSachXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int num;
            num = e.RowIndex;
            IDDangChon = dgvDanhSachXe.Rows[num].Cells[0].Value.ToString();
        }


        private void btnSuaDSXe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IDDangChon))
            {
                MessageBox.Show("Click Vào Dòng Muốn Sửa");
                return;
            }
            FormXe frm4 = new FormXe();
            frm4.txtIDXe.Text = IDDangChon;
            frm4.txtIDXe.Enabled = false;
            frm4.Show();
            
            LoadQLXe();
        }

        private void btnXoaDSXe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IDDangChon))
            {
                MessageBox.Show("Click Vào Dòng muốn Xoá");
                return;
            }
            BUS_Xe kh = new BUS_Xe();
            if (kh.XoaXe(IDDangChon) == 1)
            {
                MessageBox.Show("Xoa Thanh Cong");
                LoadQLXe();
            }
            else
            {
                MessageBox.Show("Không Xoá Được");
            }
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            LoadQLXe();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        public string MaXeTuTang()
        {
            int dem = 0;
            string temp = "KH01";
            dem = dgvDanhSachXe.RowCount;
            if (dem == 0)
            {
                return temp;
            }
            else
            {
                temp = dgvDanhSachXe.Rows[dem - 1].Cells[0].Value.ToString();
                int p = int.Parse(temp.Substring(1)) + 1;
                temp = "X" + p.ToString("00");
                return temp;
            }
        }
        private void ThemChuyenXe(object sender, EventArgs e)
        {
            FormXe frm = new FormXe();
            frm.txtIDXe.Text = MaXeTuTang();
            frm.Show();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            LoadQLXe();
        }

        

       
        

     
        
    }
}
