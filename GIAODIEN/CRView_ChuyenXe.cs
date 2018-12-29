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
    public partial class CRView_ChuyenXe : Form
    {
        public CRView_ChuyenXe()
        {
            InitializeComponent();
        }

        private void CRView_ChuyenXe_Load(object sender, EventArgs e)
        {
            LoadTuyenXe();
            LoadView(cbTuyenXe.SelectedItem.ToString());
        }
        private void cbTuyenXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            BUS_ChuyenXe cx = new BUS_ChuyenXe();
            string idtuyen = cx.GetIDTuyen(cbTuyenXe.SelectedItem.ToString());
            LoadView(idtuyen);
        }
        void LoadTuyenXe()
        {
            BUS_QuanLiVeXe qlve = new BUS_QuanLiVeXe();
            cbTuyenXe.DataSource = qlve.LoadGCChuyenXe();
        }
        void LoadView(string a)
        {
            BUS_ChuyenXe cx = new BUS_ChuyenXe();
            DataTable dt = cx.LoadChuyenXeTheoTuyen(a);
            CR_ChuyenXe crCX = new CR_ChuyenXe();
            crCX.SetDataSource(dt);
            CRV_CX.ReportSource = crCX;
        }
        void LoadViewCoThoiGian(string Tuyen , DateTime a , DateTime b)
        {
            BUS_ChuyenXe cx = new BUS_ChuyenXe();
            DataTable dt = cx.LoadChuyenXeTheoThoiGian(Tuyen, a, b);
            CR_ChuyenXe crCX = new CR_ChuyenXe();
            crCX.SetDataSource(dt);
            CRV_CX.ReportSource = crCX;
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            BUS_ChuyenXe cx = new BUS_ChuyenXe();
            string idtuyen = cx.GetIDTuyen(cbTuyenXe.SelectedItem.ToString());
            LoadViewCoThoiGian(idtuyen, dpBatDau.Value,dpKetThuc.Value);
        }
    }
}
