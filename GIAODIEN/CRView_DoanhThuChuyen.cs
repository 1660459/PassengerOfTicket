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
    public partial class CRView_DoanhThuChuyen : Form
    {
        public CRView_DoanhThuChuyen()
        {
            InitializeComponent();
        }

        private void CRView_DoanhThuChuyen_Load(object sender, EventArgs e)
        {
            LoadCRView();
            LoadComboBox();
        }
        void LoadCRView()
        {
            BUS_Ve ve = new BUS_Ve();
            DataTable dt = ve.LoadVe();
            CR_Ve crVe = new CR_Ve();
            crVe.SetDataSource(dt);
            CRV_CX.ReportSource = crVe;
        }
        void LoadComboBox()
        {
            List<string> list = new List<string>();
            BUS_ChuyenXe cx = new BUS_ChuyenXe();
            list = cx.LoadIDChuyenXe();
            list.Insert(0,"ALL");
            cbChuyenXe.DataSource = list;
        }
        void LoadCRViewTheoChuyen(string idchuyen)
        {
            BUS_Ve ve = new BUS_Ve();
            DataTable dt = ve.LoadVeTheoChuyen(idchuyen);
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
                BUS_Ve ve = new BUS_Ve();
                DataTable dt = ve.LoadVeTheoTG(cbChuyenXe.SelectedItem.ToString(), dpBatDau.Value, dpKetThuc.Value);
                CR_Ve crVe = new CR_Ve();
                crVe.SetDataSource(dt);
                CRV_CX.ReportSource = crVe;
            }
        }
        private void cbChuyenXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbChuyenXe.SelectedItem.ToString() == "ALL")
            {
                LoadCRView();
            }
            else
            {
                LoadCRViewTheoChuyen(cbChuyenXe.SelectedItem.ToString());
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            LoadCRViewTheoTG();
        }
    }
}
