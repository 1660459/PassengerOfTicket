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
using DULIEU;
namespace GIAODIEN
{
    public partial class FormTTKhachHang : Form
    {
        public FormTTKhachHang()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool KTRONG()
        {
            if (string.IsNullOrEmpty(txtIDKhachHang.Text))
            {
                MessageBox.Show("hãy điền vào ID khách hàng ");
                return false;
            }
            if (string.IsNullOrEmpty(txtHoTenKhachHang.Text))
            {
                MessageBox.Show("hãy điền vào họ tên khách hàng");
                return false;
            }
            if (string.IsNullOrEmpty(cbLoaiKH.SelectedItem.ToString()))
            {
                MessageBox.Show("hãy Chọn Loại Khách Hàng");
                return false;
            }
            if (string.IsNullOrEmpty(txtSDTKH.Text))
            {
                MessageBox.Show("hãy điền vào số điện thoại khách");
                return false;
            }
            if (string.IsNullOrEmpty(txtEmailKH.Text))
            {
                MessageBox.Show("hãy điền vào email khách hàng");
                return false;
            }
            return true;
        }
        //public string MaKHTuTang()
        //{
        //    int dem = 0;
        //    string temp = "KH01";
        //    frmQuanLyKhachHang qlkh = new frmQuanLyKhachHang();
        //    dem = qlkh.dgvQuanLyKhachHang.RowCount;
        //    if (dem == 0)
        //    {
        //        return temp;
        //    }
        //    else
        //    {
        //        temp = qlkh.dgvQuanLyKhachHang.Rows[dem - 1].Cells[0].Value.ToString();
        //        int p = int.Parse(temp.Substring(2)) + 1;
        //        temp = "KH" + p.ToString("00");
        //        return temp;
        //    }
        //}
        private void btnLuuTTKH_Click(object sender, EventArgs e)
        {
            if (KTRONG() == false)
            {
                return;
            }
            else
            {
                BUS_KhachHang kh = new BUS_KhachHang();
                KhachHang khach = new KhachHang();
                khach.id_khachhang = txtIDKhachHang.Text;
                khach.hoten = txtHoTenKhachHang.Text;
                khach.email = txtEmailKH.Text;
                khach.dienthoai = txtSDTKH.Text;
                khach.loai = int.Parse(cbLoaiKH.SelectedItem.ToString());
                if (txtIDKhachHang.Enabled == true)
                {
                    if (kh.ThemKhachHang(khach) == 1)
                    {
                        this.Close();
                        frmQuanLyKhachHang qlkh = new frmQuanLyKhachHang();
                        qlkh.LoadQLKhachHang();
                    }
                    else if (kh.ThemKhachHang(khach)  == -1)
                    {
                        MessageBox.Show("Không Được Trùng ID");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Không Thêm Được");
                        return;
                    }
                }
                else
                {
                    if (kh.SuaKhachHang(khach) == 1)
                    {
                        this.Close();
                        frmQuanLyKhachHang qlkh = new frmQuanLyKhachHang();
                        qlkh.LoadQLKhachHang();
                    }
                    else
                    {
                        MessageBox.Show("Không Sửa Được");
                        return;
                    }
                }
                txtIDKhachHang.Enabled = true;
            }
        }

        

       
    }
}
