using frmLogin.Data_Tranfer_Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmLogin.Data_Access_Layer
{
    class ProductDAF
    {
        private static ProductDAF instance;

        public static ProductDAF Instance
        {
            get { if (instance == null) instance = new ProductDAF(); return ProductDAF.instance; }
            private set { ProductDAF.instance = value; }
        }

        private ProductDAF()
        {

        }
    }
}
