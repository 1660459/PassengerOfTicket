using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DULIEU
{
    public class Ve
    {
    //    id_ve int,
    //ghe_id_ghe int,
    //chuyen_id_chuyen int,
    //tinhtrang int,
    //giatien smallmoney,
    //khachhang_id_khachhang int,
    //ngayxuatve datetime,
    //ghichu varchar(40),
        string _id_ve, _chuyen_id_chuyen, _ghe_id_ghe, _khachhang_id_khachhang, _ghichu;

        public string ghichu
        {
            get { return _ghichu; }
            set { _ghichu = value; }
        }

        public string khachhang_id_khachhang
        {
            get { return _khachhang_id_khachhang; }
            set { _khachhang_id_khachhang = value; }
        }

        public string ghe_id_ghe
        {
            get { return _ghe_id_ghe; }
            set { _ghe_id_ghe = value; }
        }

        public string chuyen_id_chuyen
        {
            get { return _chuyen_id_chuyen; }
            set { _chuyen_id_chuyen = value; }
        }

        public string id_ve
        {
            get { return _id_ve; }
            set { _id_ve = value; }
        }
        double _giatien;

        public double giatien
        {
            get { return _giatien; }
            set { _giatien = value; }
        }
        int _tinhtrang;

        public int tinhtrang
        {
            get { return _tinhtrang; }
            set { _tinhtrang = value; }
        }
        DateTime _ngayxuatve;

        public DateTime ngayxuatve
        {
            get { return _ngayxuatve; }
            set { _ngayxuatve = value; }
        }
    }
}
