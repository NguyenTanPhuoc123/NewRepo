using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace frmLogin.Data_Access_Layer
{
    class TableDAF
    {
        private static TableDAF instance;

        public static TableDAF Instance
        {
            get { if (instance == null) instance = new TableDAF(); return TableDAF.instance; }
            private set { TableDAF.instance = value; }
        }

        private TableDAF()
        {

        }
    }
}
