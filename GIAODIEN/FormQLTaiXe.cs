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
            IDDangChon = dgvQLTX.Rows[num].Cells[0].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IDDangChon))
            {
                MessageBox.Show("Click Vào Dòng Muốn Sửa");
                return;
            }

            FormTaiXe ftx = new FormTaiXe();
            //ftx.txtId.Text;
            //ftx.txtId.Enabled = false;
            //ftx.Show();

            //LoadQLTX();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
       

    }
}
