using frmLogin.Data_Tranfer_Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmLogin.Data_Access_Layer
{
    class DiscountDAF
    {
        private static DiscountDAF instance;

        public static DiscountDAF Instance
        {
            get { if (instance == null) instance = new DiscountDAF(); return DiscountDAF.instance; }
            private set { DiscountDAF.instance = value; }
        }

        private DiscountDAF()
        {

        }
    }
}
