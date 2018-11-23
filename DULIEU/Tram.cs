using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DULIEU
{
    public class Tram
    {
    //    id_tram varchar(10),
    //ten_tram nvarchar(4000),
    //dia_diem nvarchar(4000),
        string _id_tram, _ten_tram, _dia_diem;

        public string dia_diem
        {
            get { return _dia_diem; }
            set { _dia_diem = value; }
        }

        public string ten_tram
        {
            get { return _ten_tram; }
            set { _ten_tram = value; }
        }

        public string id_tram
        {
            get { return _id_tram; }
            set { _id_tram = value; }
        }
    }
}
