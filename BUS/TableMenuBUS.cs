using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class TableMenuBUS
    {
        private static TableMenuBUS instance;
        public static TableMenuBUS Instance
        {
            get { if (instance == null) instance = new TableMenuBUS(); return TableMenuBUS.instance; }
            private set { TableMenuBUS.instance = value; }
        }

        private TableMenuBUS()
        {

        }

        public List<TableMenu> GetListTableMenu()
        {
            return TableMenuDAO.Instance.GetListTableMenu()
;        }

        public List<TableMenu> GetListTableMenuDeleted()
        {
            return TableMenuDAO.Instance.GetListTableMenuDeleted();
        }

        public List<TableMenu> SearchTableFoodByTableName(string tableName)
        {
            return TableMenuDAO.Instance.SearchTableFoodByTableName(tableName);
        }
      

        public List<TableMenu> SortTableByID(int locationID)
        {
            return TableMenuDAO.Instance.SortTableByID(locationID);
        }

        public List<TableMenu> SortTableByIDDecrease(int locationID)
        {
            return TableMenuDAO.Instance.SortTableByIDDecrease(locationID);
        }

        public List<TableMenu> SortTableByLocationID(int locationID)
        {
            return TableMenuDAO.Instance.SortTableByLocationID(locationID);
        }

        public List<TableMenu> SortTableByLocationIDDecrease(int locationID)
        {
            return TableMenuDAO.Instance.SortTableByLocationIDDecrease(locationID);
        }

        public List<TableMenu> FillListTableMenu(int locationID)
        {
            return TableMenuDAO.Instance.FillListTableMenu(locationID);
        }
    }
}
