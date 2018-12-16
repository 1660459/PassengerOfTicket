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
    public partial class FormNguoiDat : Form
    {
        public FormNguoiDat()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void FormNguoiDat_Load(object sender, EventArgs e)
        {
            LoadFromNguoiDat();
        }
        public void LoadFromNguoiDat()
        {
            BUS_NguoiDat nd = new BUS_NguoiDat();
            dgvNguoiDat.DataSource = nd.LoadNguoiDat();
        }

        private void btnXuatVe_Click(object sender, EventArgs e)
        {
            FormQuanLiVeXe qlve = new FormQuanLiVeXe();
            IDDangChon.id_ve = qlve.VeTuTang();
            IDDangChon.khachhang_id_khachhang = "KH00";
            BUS_Ve ve = new BUS_Ve();
            if (ve.ThemVe(IDDangChon) == 1)
            {
                MessageBox.Show("Mua Vé Thành Công !!");
            }
            else
            {
                MessageBox.Show("Vé đã tồn tại");
                return;
            }

        }
        static public Ve IDDangChon = new Ve() ;
        static public int SOTT = 1;
        private void dgvNguoiDat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int num;
            num = e.RowIndex;
            if (num < 0)
            {
                return;
            }
            IDDangChon.id_ve = dgvNguoiDat.Rows[num].Cells[0].Value.ToString();
            SOTT = int.Parse(dgvNguoiDat.Rows[num].Cells[1].Value.ToString());
            IDDangChon.ghe_id_ghe = dgvNguoiDat.Rows[num].Cells[4].Value.ToString();
            IDDangChon.chuyen_id_chuyen = dgvNguoiDat.Rows[num].Cells[5].Value.ToString();
            IDDangChon.tinhtrang = 1;
            IDDangChon.giatien = double.Parse(dgvNguoiDat.Rows[num].Cells[7].Value.ToString());
            IDDangChon.ngayxuatve = DateTime.Parse(dgvNguoiDat.Rows[num].Cells[8].Value.ToString());
            IDDangChon.ghichu = dgvNguoiDat.Rows[num].Cells[9].Value.ToString();
        }
        //public string MaKHTuTang()
        //{

        //    BUS_KhachHang kh = new BUS_KhachHang();
        //    string MAKH = "";
        //    MAKH = kh.MaKHTutang();
        //    return MAKH;
        //}
        private void btnXoaNguoiDat_Click(object sender, EventArgs e)
        {
            BUS_NguoiDat nd = new BUS_NguoiDat();
            if(nd.XoaNguoiDat(IDDangChon.id_ve , SOTT) == 1)
            {
                MessageBox.Show("Xoá Thành Công");
                LoadFromNguoiDat();
            }
        }
    }
}
