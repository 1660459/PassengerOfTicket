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
        void KTRONG()
        {

        }
        private void btnLuuTTKH_Click(object sender, EventArgs e)
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
