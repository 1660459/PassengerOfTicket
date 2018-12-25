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
    public partial class FormGiaVe : Form
    {
        public FormGiaVe()
        {
            InitializeComponent();
        }

        private void FormGiaVe_Load(object sender, EventArgs e)
        {
            LoadCBTuyenXe();
            FormQLGiaVe qlgv = new FormQLGiaVe();
            qlgv.eGiaVe += qlgv_eGiaVe;

        }
        void qlgv_eGiaVe(string a)
        {
            cbIDTuyenXe.SelectedItem = a;
        }
        void LoadCBTuyenXe()
        {
            BUS_ChuyenXe tx = new BUS_ChuyenXe();
            cbIDTuyenXe.DataSource = tx.LoadIDTuyenFromChuyen();
        }

        private void Thoat(object sender, EventArgs e)
        {
            this.Close();
        }

          bool KTRONG()
        {
            if (string.IsNullOrEmpty(txtIDVe.Text))
            {
                MessageBox.Show("hãy điền vào ID vé ");
                return false;
            }
            if (string.IsNullOrEmpty(txtGiaTienVe.Text))
            {
                MessageBox.Show("hãy điền vào giá vé");
                return false;
            }
            if (string.IsNullOrEmpty(cbIDTuyenXe.SelectedItem.ToString()))
            {
                MessageBox.Show("hãy chọn tuyến xe");
                return false;
            }
            return true;
        }
         
          private void btnThemXe_Click(object sender, EventArgs e)
          {
              if (KTRONG() == false)
              {
                  return;
              }
              else
              {
                  GiaVe tempVe = new GiaVe();
                  tempVe.stt = int.Parse(txtIDVe.Text);
                  tempVe.gia_ve = float.Parse(txtGiaTienVe.Text);
                  tempVe.id_tuyen_id = cbIDTuyenXe.SelectedItem.ToString();
                  BUS_Ve ve = new BUS_Ve();
                  if (txtIDVe.Enabled == true)
                  {
                      if (ve.ThemGiaVe(tempVe) == 1)
                      {
                          this.Close();
                      }
                      else if (ve.ThemGiaVe(tempVe) == -1)
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
                      if (ve.SuaGiaVe(tempVe) == 1)
                      {
                          this.Close();
                      }
                      else
                      {
                          return;
                      }
                  }
                  txtIDVe.Enabled = true;
                  cbIDTuyenXe.Enabled = true;
              }
          }
        private void txtGiaTienVe_KeyPress(object sender, KeyPressEventArgs e)
        {
            //THAM KHAO GG
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmHOTRO_Tuyen htt = new frmHOTRO_Tuyen();
            htt.Show();
        }

        private void cbIDTuyenXe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
