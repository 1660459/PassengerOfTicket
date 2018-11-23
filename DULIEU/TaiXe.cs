using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DULIEU
{
    public class TaiXe
    {
    //    id_taixe varchar(10),
    //tentaixe nvarchar(100),
    //banglai Nvarchar(100),
        string _id_taixe, _tentaixe, _banglai;

        public string banglai
        {
            get { return _banglai; }
            set { _banglai = value; }
        }

        public string tentaixe
        {
            get { return _tentaixe; }
            set { _tentaixe = value; }
        }

        public string id_taixe
        {
            get { return _id_taixe; }
            set { _id_taixe = value; }
        }
    }
}
