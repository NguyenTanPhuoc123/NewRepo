using frmLogin.Data_Tranfer_Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace frmLogin.Data_Access_Layer
{
    class CustomerDAF
    {
        private static CustomerDAF instance;

        public static CustomerDAF Instance
        {
            get { if (instance == null) instance = new CustomerDAF(); return CustomerDAF.instance; }
            private set { CustomerDAF.instance = value; }
        }

        private CustomerDAF()
        {

        }

    }
}
