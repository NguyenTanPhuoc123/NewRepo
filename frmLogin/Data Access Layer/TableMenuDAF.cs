using frmLogin.Data_Tranfer_Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmLogin.Data_Access_Layer
{
    public class TableMenuDAF
    {
        private static TableMenuDAF instance;
        public static TableMenuDAF Instance
        {
            get { if (instance == null) instance = new TableMenuDAF(); return TableMenuDAF.instance; }
            private set { TableMenuDAF.instance = value; }
        }

        private TableMenuDAF()
        {

        }

        public List<TableMenu> GetListTableMenu()
        {
            List<TableMenu> list = new List<TableMenu>();
            string query = string.Format("Select * from BANAN a, VITRI b where a.VITRI = b.MAVITRI and a.XOA = 0");
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);

            foreach(DataRow item in data.Rows)
            {
                TableMenu table = new TableMenu(item);
                list.Add(table);
            }
            return list;
        }

        public List<TableMenu> GetListTableMenuDeleted()
        {
            List<TableMenu> list = new List<TableMenu>();
            string query = string.Format("Select * from BANAN a, VITRI b where a.VITRI = b.MAVITRI and a.XOA = 1");
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);

            foreach (DataRow item in data.Rows)
            {
                TableMenu table = new TableMenu(item);
                list.Add(table);
            }
            return list;
        }
    }
}
