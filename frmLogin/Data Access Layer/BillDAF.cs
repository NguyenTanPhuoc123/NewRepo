using frmLogin.Data_Tranfer_Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace frmLogin.Data_Access_Layer
{
    class BillDAF
    {
        private static BillDAF instance;

        public static BillDAF Instance
        {
            get { if (instance == null) instance = new BillDAF(); return BillDAF.instance; }
            private set { BillDAF.instance = value; }
        }

        private BillDAF()
        {

        }
    }
}
