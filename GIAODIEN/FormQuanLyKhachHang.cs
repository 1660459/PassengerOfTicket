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
    public partial class frmQuanLyKhachHang : Form
    {
        public frmQuanLyKhachHang()
        {
            InitializeComponent();
        }
        public string MaKHTuTang()
        {
            int dem = 0;
            string temp = "KH01";
            dem = dgvQuanLyKhachHang.RowCount;
            if (dem == 0)
            {
                return temp;
            }
            else
            {
                temp = dgvQuanLyKhachHang.Rows[dem - 1].Cells[0].Value.ToString();
                int p = int.Parse(temp.Substring(2)) + 1;
                temp = "KH" + p.ToString("00");
                return temp;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            FormTTKhachHang frm4 = new FormTTKhachHang();
            frm4.txtIDKhachHang.Text = MaKHTuTang();
            frm4.Show();
            LoadQLKhachHang();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            LoadQLKhachHang();
        }
        public void LoadQLKhachHang()
        {
            BUS_KhachHang kh = new BUS_KhachHang();
            dgvQuanLyKhachHang.DataSource = kh.LoadKH();
        }
        static string IDDangChon = null;
        private void dgvQuanLyKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int num;
            num = e.RowIndex;
            IDDangChon = dgvQuanLyKhachHang.Rows[num].Cells[0].Value.ToString();
        }

        private void btnXoaQLKH_Click(object sender, EventArgs e)
        {
            BUS_KhachHang kh = new BUS_KhachHang();
            if (kh.XoaKhachHang(IDDangChon) == 1)
            {
                MessageBox.Show("Xoa Thanh Cong");
                LoadQLKhachHang();
            }
            else
            {
                MessageBox.Show("Không Xoá Được");
            }
        }

        private void btnSuaQLKH_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IDDangChon))
            {
                MessageBox.Show("Click Vào Dòng Muốn Sửa");
                return;
            }
            FormTTKhachHang frm4 = new FormTTKhachHang();
            frm4.txtIDKhachHang.Text = IDDangChon;
            frm4.txtIDKhachHang.Enabled = false;
            frm4.Show();
            LoadQLKhachHang();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            LoadQLKhachHang();
        }

        

        

        
        
    }
}
