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
    public partial class CRView_DoanhThuTuyen : Form
    {
        public CRView_DoanhThuTuyen()
        {
            InitializeComponent();
        }

        private void CRView_DoanhThuChuyen_Load(object sender, EventArgs e)
        {
            LoadCRView();
            LoadComboBox();
        }
        void LoadComboBox()
        {
            List<string> list = new List<string>();
            BUS_QuanLiVeXe qlve = new BUS_QuanLiVeXe();
            list = qlve.LoadGCChuyenXe();
            list.Add("ALL");
            list.Reverse();
            cbChuyenXe.DataSource = list;
        }
        void LoadCRView()
        {
            BUS_Ve ve = new BUS_Ve();
            DataTable dt = ve.LoadVe();
            CR_Ve crVe = new CR_Ve();
            crVe.SetDataSource(dt);
            CRV_CX.ReportSource = crVe;
        }
        void LoadCRViewTheoChuyen(string a)
        {
            BUS_Ve ve = new BUS_Ve();
            DataTable dt = ve.LoadVeTheoChuyen(a);
            CR_Ve crVe = new CR_Ve();
            crVe.SetDataSource(dt);
            CRV_CX.ReportSource = crVe;
        }
        void LoadCRViewTheoTG()
        {
            if (cbChuyenXe.SelectedItem.ToString() == "ALL")
            {
                MessageBox.Show("Chọn Chuyến Cụ Thể Để Report Theo Ngày");
                return;
            }
            else
            {
                BUS_ChuyenXe cx = new BUS_ChuyenXe();
                List<string> list = cx.GetIDChuyen(cbChuyenXe.SelectedItem.ToString());
                string idchuyen = list[0].ToString();
                BUS_Ve ve = new BUS_Ve();
                DataTable dt = ve.LoadVeTheoTG(idchuyen, dpBatDau.Value, dpKetThuc.Value);
                CR_Ve crVe = new CR_Ve();
                crVe.SetDataSource(dt);
                CRV_CX.ReportSource = crVe;
            }
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            LoadCRViewTheoTG();
        }

        private void cbChuyenXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbChuyenXe.SelectedItem.ToString() == "ALL")
            {
                LoadCRView();
            }
            else
            {
                BUS_ChuyenXe cx = new BUS_ChuyenXe();
                List<string> list = cx.GetIDChuyen(cbChuyenXe.SelectedItem.ToString());
                string idchuyen = list[0].ToString();
                LoadCRViewTheoChuyen(idchuyen);
            }
        }
    }
}
