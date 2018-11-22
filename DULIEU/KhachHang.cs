using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DULIEU
{
    public class KhachHang
    {
        int _loai;

        public int loai
        {
            get { return _loai; }
            set { _loai = value; }
        }
        string _hoten, _dienthoai, _email, _id_khachhang;

        public string id_khachhang
        {
            get { return _id_khachhang; }
            set { _id_khachhang = value; }
        }

        public string email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string dienthoai
        {
            get { return _dienthoai; }
            set { _dienthoai = value; }
        }

        public string hoten
        {
            get { return _hoten; }
            set { _hoten = value; }
        }
    //    id_khachhang int ,
    //hoten nvarchar(4000),
    //dienthoai varchar(4000),
    //email varchar(4000),
    //loai int
    }
}
