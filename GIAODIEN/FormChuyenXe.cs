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
    public partial class FormChuyenXe : Form
    {
        public FormChuyenXe()
        {
            InitializeComponent();
        }

       
       

        private void FormChuyenXe_Load(object sender, EventArgs e)
        {
            BUS_ChuyenXe cx = new BUS_ChuyenXe();
            cbIDTuyen.DataSource = cx.LoadIDTuyen();
            cbIDTaiXe.DataSource = cx.LoadIDTaiXe();
            cbIDXe.DataSource = cx.LoadIDXe();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool KTRONG()
        {
            if (string.IsNullOrEmpty(txtIDChuyenXe.Text))
            {
                MessageBox.Show("hãy điền vào ID xe ");
                return false;
            }
            if (string.IsNullOrEmpty(cbIDTuyen.SelectedItem.ToString()))
            {
                MessageBox.Show("hãy chọn id tuyến");
                return false;
            }
            if (string.IsNullOrEmpty(DtpChuyenXe.Value.ToString()))
            {
                MessageBox.Show("hãy điền chọn thời gian chạy");
                return false;
            }
            if (string.IsNullOrEmpty(txtGhiChu.Text))
            {
                MessageBox.Show("hãy điền vào ghi chú ");
                return false;
            }
            if (string.IsNullOrEmpty(cbIDTaiXe.SelectedItem.ToString()))
            {
                MessageBox.Show("hãy chọn tài xế");
                return false;
            }
            if (string.IsNullOrEmpty(cbIDXe.SelectedItem.ToString()))
            {
                MessageBox.Show("hãy chọn id xe");
                return false;
            }
            return true;
        }
        private void btnLuuChuyenXe_Click(object sender, EventArgs e)
        {
            if (KTRONG() == false)
            {
                return;
            }
            else
            {
                ChuyenXe cx = new ChuyenXe();
                cx.id_chuyen = txtIDChuyenXe.Text;
                cx.tuyen_id_tuyen = cbIDTuyen.SelectedItem.ToString();
                cx.giokhoihanh = DtpChuyenXe.Value;
                cx.ghichu = txtGhiChu.Text;
                cx.xe_xeid = cbIDXe.SelectedItem.ToString();
                cx.tai_xe_id_taixe = cbIDTaiXe.SelectedItem.ToString();
                BUS_ChuyenXe chuyenx = new BUS_ChuyenXe();
                if (txtIDChuyenXe.Enabled == true)
                {
                    if (chuyenx.ThemChuyenXe(cx) == 1)
                    {

                        this.Close();
                    }
                    else if (chuyenx.ThemChuyenXe(cx) == -1)
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
                    if (chuyenx.SuaChuyenXe(cx) == 1)
                    {
                        txtIDChuyenXe.Enabled = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Không Sửa Được");
                        return;
                    }
                }
            }

        }

      
        private void btnXemTuyen_Click(object sender, EventArgs e)
        {
            frmHOTRO_Tuyen tx = new frmHOTRO_Tuyen();
            tx.Show();
        }

        private void btnTraXe_Click(object sender, EventArgs e)
        {
            frmHOTRO_Xe frm = new frmHOTRO_Xe();
            frm.Show();
        }

        private void btnTraTaiXe_Click(object sender, EventArgs e)
        {
            frmHOTRO_TaiXe frm = new frmHOTRO_TaiXe();
            frm.Show();
        }
    }
}
