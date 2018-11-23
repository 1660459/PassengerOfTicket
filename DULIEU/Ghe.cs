
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DULIEU
{
    public class Ghe
    {
        //    id_ghe int,
        //dong int,
        //cot int,
        //tang int, 
        //so_ghe int,  
        //Xe_XeID int,
        string _id_ghe, _xe_XeID;
        int _dong, _cot, _tang;
        public string Xe_XeID
        {
            get { return _xe_XeID; }
            set { _xe_XeID = value; }
        }

        public string id_ghe
        {
            get { return _id_ghe; }
            set { _id_ghe = value; }
        }


        public int tang
        {
            get { return _tang; }
            set { _tang = value; }
        }

        public int cot
        {
            get { return _cot; }
            set { _cot = value; }
        }

        public int dong
        {
            get { return _dong; }
            set { _dong = value; }
        }
    }
}
