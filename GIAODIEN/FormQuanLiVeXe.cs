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
            LoadTuyenXe();
            LoadKhachHang();
        }
        void LoadKhachHang()
        {
            BUS_KhachHang kh = new BUS_KhachHang();
            cbTenKH.DataSource = kh.LoadTenKH();
        }
        void LoadLoaiXe()
        {
            BUS_QuanLiVeXe qlve = new BUS_QuanLiVeXe();
            cbLoaiXe1.DataSource = qlve.LoadTenLoaiXe();
            cbLoaiXe2.DataSource = qlve.LoadTenLoaiXe();
        }
        void LoadTuyenXe()
        {
            BUS_QuanLiVeXe qlve = new BUS_QuanLiVeXe();
            cbTuyenXe1.DataSource = qlve.LoadGCChuyenXe();
            cbTuyenXe2.DataSource = qlve.LoadGCChuyenXe();
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
        public string MaVe()
        {
            BUS_Ve ve = new BUS_Ve();
            string MaVe = "";
            MaVe = ve.VeTuTang();
            return MaVe;
        }
        private void cbTuyenXe1_SelectedIndexChanged(object sender, EventArgs e)
        {
            BUS_Ve ve = new BUS_Ve();
            txtGiaTien1.Text = ve.GetGiaVe(cbTuyenXe1.SelectedItem.ToString());
            BUS_ChuyenXe c = new BUS_ChuyenXe();
            cbChuyenXe1.DataSource = c.GetIDChuyen(cbTuyenXe1.SelectedItem.ToString());
        }
        private void cbTuyenXe2_SelectedIndexChanged(object sender, EventArgs e)
        {
            BUS_Ve ve = new BUS_Ve();
            txtGiaTien2.Text = ve.GetGiaVe(cbTuyenXe2.SelectedItem.ToString());
            BUS_ChuyenXe c = new BUS_ChuyenXe();
            cbChuyenXe2.DataSource = c.GetIDChuyen(cbTuyenXe2.SelectedItem.ToString());
        }
        bool KTRONG()
        {
            if (string.IsNullOrEmpty(txtTenKH1.Text))
            {
                MessageBox.Show("hãy điền vào tên khách hàng ");
                return false;
            } 
            if (string.IsNullOrEmpty(txtSDTKH1.Text))
            {
                MessageBox.Show("hãy điền sđt khách hàng");
                return false;
            }
            if (string.IsNullOrEmpty(txtMaGhe1.Text))
            {
                MessageBox.Show("hãy điền chọn ghế");
                return false;
            }
            if (string.IsNullOrEmpty(cbTuyenXe1.SelectedItem.ToString()))
            {
                MessageBox.Show("hãy chọn chuyến xe");
                return false;
            }
            if (string.IsNullOrEmpty(dateTimePicker1.Value.ToString()))
            {
                MessageBox.Show("hãy chọn ngày xuất vé");
                return false;
            } 
            if (string.IsNullOrEmpty(txtGhiChu.Text))
            {
                MessageBox.Show("hãy điền vào ghi chú");
                return false;
            }
            return true;
        }
        bool KTRONG2()
        {
            
            if (string.IsNullOrEmpty(txtMaGhe2.Text))
            {
                MessageBox.Show("hãy điền chọn ghế");
                return false;
            }
            if (string.IsNullOrEmpty(cbTuyenXe2.SelectedItem.ToString()))
            {
                MessageBox.Show("hãy chọn chuyến xe");
                return false;
            }
            if (string.IsNullOrEmpty(cbTenKH.SelectedItem.ToString()))
            {
                MessageBox.Show("hãy chọn khach hang");
                return false;
            }
            if (string.IsNullOrEmpty(dateTimePicker2.Value.ToString()))
            {
                MessageBox.Show("hãy chọn ngày xuất vé");
                return false;
            }
            if (string.IsNullOrEmpty(txtGhiChu2.Text))
            {
                MessageBox.Show("hãy điền vào ghi chú");
                return false;
            }
            return true;
        }
        private void btnDatVe_Click(object sender, EventArgs e)
        {
            if (KTRONG() == false)
            {
                return;
            }
            BUS_NguoiDat NguoiD = new BUS_NguoiDat();
            NguoiDat nd = new NguoiDat();
            nd.id_ve = MaVeNDTuTang();
            nd.stt = SttTang();
            nd.ten_khach_hang = txtTenKH1.Text;
            nd.so_dt = txtSDTKH1.Text;
            nd.ghe_id_ghe = txtMaGhe1.Text;
            BUS_ChuyenXe cx = new BUS_ChuyenXe();
            nd.chuyen_id_chuyen = cbChuyenXe1.SelectedItem.ToString();
            nd.tinhtrang = 0;
            nd.giatien = float.Parse(txtGiaTien1.Text);
            nd.ngayxuatve = dateTimePicker1.Value;
            nd.ghi_chu = txtGhiChu.Text;
            if (NguoiD.ThemNguoiDat(nd) == 1)
            {
                MessageBox.Show("Đặt vé Thành Công !!");
            }
            else
            {
                MessageBox.Show("Không Thêm Được");
                return;
            }

        }
        int SttTang()
        {
            int dem = 0;
            int temp = 1;
            FormNguoiDat frmND = new FormNguoiDat();
            dem = frmND.dgvNguoiDat.RowCount;
            if (dem == 0)
            {
                return temp;
            }
            else
            {
                foreach (DataGridViewRow row in frmND.dgvNguoiDat.Rows)
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
        string MaVeNDTuTang()
        {
            BUS_Ve ve = new BUS_Ve();
            string MaVe = "";
            MaVe = ve.MaVeNDMoi();
            return MaVe;
        }

        private void btnXuatVe_Click(object sender, EventArgs e)
        {
            if (KTRONG2() == false)
            {
                return;
            }
            BUS_Ve NguoiD = new BUS_Ve();
            Ve nd = new Ve();
            nd.id_ve = VeTuTang();
            nd.ghe_id_ghe = txtMaGhe2.Text;
            BUS_ChuyenXe cx = new BUS_ChuyenXe();
            nd.chuyen_id_chuyen = cbChuyenXe2.SelectedItem.ToString();
            nd.khachhang_id_khachhang = cbTenKH.SelectedItem.ToString();
            nd.tinhtrang = 1;
            nd.giatien = float.Parse(txtGiaTien2.Text);
            nd.ngayxuatve = dateTimePicker2.Value;
            nd.ghichu = txtGhiChu2.Text;
            if (NguoiD.ThemVe(nd) == 1)
            {
                MessageBox.Show("Mua Vé Thành Công !!");
            }
            else if (NguoiD.ThemVe(nd) == -2)
            {
                MessageBox.Show("Đã Có Người Đặt Ghế này trong Chuyến này !! ");
            }
            else
            {
                MessageBox.Show("Vé đã tồn tại");
                return;
            }
        }
        public string VeTuTang()
        {
            BUS_Ve ve = new BUS_Ve();
            string MaVe = "";
            MaVe = ve.VeTuTang();
            return MaVe;
        }

        private void btnXenTenKH_Click(object sender, EventArgs e)
        {
            frmHOTRO_TenKH frm = new frmHOTRO_TenKH();
            frm.Show();
        }

        private void btnGKH1_Click(object sender, EventArgs e)
        {
            frmHOTRO_GioKhoiHanh frm = new frmHOTRO_GioKhoiHanh();
            frm.Show();
        }

      
    }
}