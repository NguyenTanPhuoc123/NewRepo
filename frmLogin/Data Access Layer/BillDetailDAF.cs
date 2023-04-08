using frmLogin.Data_Tranfer_Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmLogin.Data_Access_Layer
{

    class BillDetailDAF
    {
        private static BillDetailDAF instance;

        public static BillDetailDAF Instance
        {
            get { if (instance == null) instance = new BillDetailDAF(); return BillDetailDAF.instance; }
            private set { BillDetailDAF.instance = value; }
        }

        private BillDetailDAF()
        {

        }

        
    }
}
