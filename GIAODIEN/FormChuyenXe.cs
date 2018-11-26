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

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuuChuyenXe_Click(object sender, EventArgs e)
        {
            ChuyenXe cx = new ChuyenXe();
            cx.id_chuyen = txtIDTuyen.Text;
            cx.tuyen_id_tuyen = txtIDTuyen.Text;
            cx.giokhoihanh = DtpChuyenXe.Value;
            cx.ghichu = txtGhiChu.Text;
            cx.xe_xeid = txtIDXe.Text;
            cx.tai_xe_id_taixe = txtIDTaiXe.Text;
            BUS_ChuyenXe chuyenx = new BUS_ChuyenXe();
            if (txtIDXe.Enabled == true)
            {
                if (chuyenx.ThemChuyenXe(cx) == 1)
                {
                    FormQLChuyenXe qlCXe = new FormQLChuyenXe();
                    qlCXe.LoadQLChuyenXe();
                    this.Close();
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
                    txtIDTuyen.Enabled = true;
                    FormQLChuyenXe qlCXe = new FormQLChuyenXe();
                    qlCXe.LoadQLChuyenXe();
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
}
