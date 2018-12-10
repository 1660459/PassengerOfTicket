using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DULIEU
{
    public class GiaVe
    {
        int _stt;

        public int stt
        {
            get { return _stt; }
            set { _stt = value; }
        }


        string _id_tuyen_id;

        float _gia_ve;

        public float gia_ve
        {
            get { return _gia_ve; }
            set { _gia_ve = value; }
        }

        public string id_tuyen_id
        {
            get { return _id_tuyen_id; }
            set { _id_tuyen_id = value; }
        }
    }
}
