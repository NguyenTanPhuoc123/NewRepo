using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using frmLogin.Data_Tranfer_Object;

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
        public List<Table> GetListTables()
        {

            List<Table> listTable = new List<Table>();
            string query = "select * from BANAN";
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);
            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                listTable.Add(table);
            }
            return listTable;
        }
    }
}
