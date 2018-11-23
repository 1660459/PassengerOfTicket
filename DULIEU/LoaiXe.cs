using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DULIEU
{
    public class LoaiXe
    {
    //    id_loaixe varchar(10),
    //tenloai nvarchar(4000)
        string _id_loaixe, _tenloai;

        public string tenloai
        {
            get { return _tenloai; }
            set { _tenloai = value; }
        }

        public string id_loaixe
        {
            get { return _id_loaixe; }
            set { _id_loaixe = value; }
        }
    }
}
