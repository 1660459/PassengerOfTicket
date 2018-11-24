using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DULIEU
{
    public class TuyenXe
    {
    //    id_tuyen int,
    //khoang_cach float,
    //thoigianchay int,
    //tram_id_tram1 int,
    //tram_id_tram int
        string _id_tuyen, _tram_id_tram, _tram_id_tram1;

        public string tram_id_tram1
        {
            get { return _tram_id_tram1; }
            set { _tram_id_tram1 = value; }
        }

        public string tram_id_tram
        {
            get { return _tram_id_tram; }
            set { _tram_id_tram = value; }
        }

       

        public string id_tuyen
        {
            get { return _id_tuyen; }
            set { _id_tuyen = value; }
        }
        float _khoang_cach;

        public float khoang_cach
        {
            get { return _khoang_cach; }
            set { _khoang_cach = value; }
        }
        int _thoigianchay;

        public int thoigianchay
        {
            get { return _thoigianchay; }
            set { _thoigianchay = value; }
        }
    }
}
