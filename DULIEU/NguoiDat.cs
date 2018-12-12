using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DULIEU
{
    public class NguoiDat
    {
        string _id_ve, _ten_khach_hang, _so_dt, _ghe_id_ghe, _chuyen_id_chuyen, _ghi_chu;

        public string ghi_chu
        {
            get { return _ghi_chu; }
            set { _ghi_chu = value; }
        }

        public string chuyen_id_chuyen
        {
            get { return _chuyen_id_chuyen; }
            set { _chuyen_id_chuyen = value; }
        }

        public string ghe_id_ghe
        {
            get { return _ghe_id_ghe; }
            set { _ghe_id_ghe = value; }
        }

        public string so_dt
        {
            get { return _so_dt; }
            set { _so_dt = value; }
        }

        public string ten_khach_hang
        {
            get { return _ten_khach_hang; }
            set { _ten_khach_hang = value; }
        }

        public string id_ve
        {
            get { return _id_ve; }
            set { _id_ve = value; }
        }
        int _stt, _tinhtrang;

        public int tinhtrang
        {
            get { return _tinhtrang; }
            set { _tinhtrang = value; }
        }
        public int stt
        {
            get { return _stt; }
            set { _stt = value; }
        }
        double _giatien;

        public double giatien
        {
            get { return _giatien; }
            set { _giatien = value; }
        }
        DateTime _ngayxuatve;

        public DateTime ngayxuatve
        {
            get { return _ngayxuatve; }
            set { _ngayxuatve = value; }
        }
    }
}
