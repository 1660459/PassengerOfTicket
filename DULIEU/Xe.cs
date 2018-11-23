
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DULIEU
{
    public class Xe
    {
        //    xe_id int, 
        //ten_xe nvarchar(4000),
        //so_dang_ky varchar(4000),
        //loaixe_id_loaixe int,
        string _xe_id, _ten_xe, _so_dang_ky, _loaixe_id_loaixe;

        public string loaixe_id_loaixe
        {
            get { return _loaixe_id_loaixe; }
            set { _loaixe_id_loaixe = value; }
        }

        public string so_dang_ky
        {
            get { return _so_dang_ky; }
            set { _so_dang_ky = value; }
        }

        public string ten_xe
        {
            get { return _ten_xe; }
            set { _ten_xe = value; }
        }

        public string xe_id
        {
            get { return _xe_id; }
            set { _xe_id = value; }
        }
    }
}
