using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DULIEU
{
    public class ChuyenXe
    {
    //    id_chuyen int,
    //tuyen_id_tuyen int,
    //giokhoihanh datetime,
    //ghichu nvarchar(4000),
    //xe_xeid int,
    //tai_xe_id_taixe int,
        string _id_chuyen, _tuyen_id_tuyen, _ghichu, _xe_xeid, _tai_xe_id_taixe;

        public string tai_xe_id_taixe
        {
            get { return _tai_xe_id_taixe; }
            set { _tai_xe_id_taixe = value; }
        }

        public string xe_xeid
        {
            get { return _xe_xeid; }
            set { _xe_xeid = value; }
        }

        public string ghichu
        {
            get { return _ghichu; }
            set { _ghichu = value; }
        }

        public string tuyen_id_tuyen
        {
            get { return _tuyen_id_tuyen; }
            set { _tuyen_id_tuyen = value; }
        }

        public string id_chuyen
        {
            get { return _id_chuyen; }
            set { _id_chuyen = value; }
        }
        DateTime _giokhoihanh;

        public DateTime giokhoihanh
        {
            get { return _giokhoihanh; }
            set { _giokhoihanh = value; }
        } 
    }
}
