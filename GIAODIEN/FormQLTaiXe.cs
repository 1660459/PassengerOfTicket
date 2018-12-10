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
using GIAODIEN;

namespace GIAODIEN
{
    public partial class FormQLTaiXe : Form
    {
        public FormQLTaiXe()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormTaiXe frm = new FormTaiXe();
            frm.txtId.Text = MaTaiXeTuTang();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormQLTaiXe_Load(object sender, EventArgs e)
        {
            LoadQLTX();
        }
        public void LoadQLTX()
        {
            BUS_TaiXe tai_xe = new BUS_TaiXe();
            dgvQLTX.DataSource = tai_xe.LoadTaiXe();
        }

        static string IDDangChon = null;
        private void dgvQLTX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int num;
            num = e.RowIndex;
            if (num < 0)
            {
                return;
            }
            IDDangChon = dgvQLTX.Rows[num].Cells[0].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        { 
            if (string.IsNullOrEmpty(IDDangChon))
            {
                MessageBox.Show("Click Vào Dòng muốn Xoá");
                return;
            }
            BUS_TaiXe tx = new BUS_TaiXe();
            if (tx.XoaTaiXe(IDDangChon) == 1)
            {
                MessageBox.Show("Xoa Thanh Cong");
                LoadQLTX();
            }
            else
            {
                MessageBox.Show("Không Xoá Được");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IDDangChon))
            {
                MessageBox.Show("Click Vào Dòng Muốn Sửa");
                return;
            }

            FormTaiXe ftx = new FormTaiXe();
            ftx.txtId.Text = IDDangChon;
            ftx.txtId.Enabled = false;
            ftx.Show();

            //LoadQLTX();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void splitContainer1_Panel1_Click(object sender, EventArgs e)
        {
            LoadQLTX();
        }
        public string MaTaiXeTuTang()
        {
            int dem = 0;
            string temp = "TX01";
            dem = dgvQLTX.RowCount;
            if (dem == 0)
            {
                return temp;
            }
            else
            {
                int p = 0, n = 0;
                foreach (DataGridViewRow row in dgvQLTX.Rows)
                {
                    temp = row.Cells[0].Value.ToString();
                    p = int.Parse(temp.Substring(2));
                    if (n < p)
                    {
                        n = p;
                    }
                }
                n += 1;
                temp = "TX" + n.ToString("00");
                return temp;
            }
        }
       
       

    }
}
