using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class TableMenuDAO
    {
            private static TableMenuDAO instance;
            public static TableMenuDAO Instance
            {
                get { if (instance == null) instance = new TableMenuDAO(); return TableMenuDAO.instance; }
                private set { TableMenuDAO.instance = value; }
            }

            private TableMenuDAO()
            {

            }

            public List<TableMenu> GetListTableMenu()
            {
                List<TableMenu> list = new List<TableMenu>();
                string query = string.Format("Select * from BANAN a, VITRI b where a.VITRI = b.MAVITRI and a.XOA = 0");
                DataTable data = DataProvider.ExcecuteSelectCommand(query, null);

                foreach (DataRow item in data.Rows)
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

            public List<TableMenu> SearchTableFoodByTableName(string tableName)
            {
                List<TableMenu> listTable = new List<TableMenu>();
                string query = string.Format("Select * from BANAN a, VITRI b where a.VITRI = b.MAVITRI and a.XOA = 0 and  a.TENBAN like N'%{0}%' ", tableName);
                DataTable data = DataProvider.ExcecuteSelectCommand(query, null);
                foreach (DataRow item in data.Rows)
                {
                    TableMenu table = new TableMenu(item);
                    listTable.Add(table);
                }

                return listTable;
            }

            public List<TableMenu> FillTableFood(int maViTri)
            {
                List<TableMenu> listTable = new List<TableMenu>();
                string query = string.Format("Select * from BANAN a, VITRI b where a.VITRI = b.MAVITRI and a.XOA = 0 and a.VITRI = {0}", maViTri);
                DataTable data = DataProvider.ExcecuteSelectCommand(query, null);
                foreach (DataRow item in data.Rows)
                {
                    TableMenu table = new TableMenu(item);
                    listTable.Add(table);
                }

                return listTable;
            }

            public List<TableMenu> SortListTableMenuByTableName()
            {
                List<TableMenu> list = new List<TableMenu>();
                string query = string.Format("Select * from BANAN a, VITRI b where a.VITRI = b.MAVITRI and a.XOA = 0 order by a.TENBAN ");
                DataTable data = DataProvider.ExcecuteSelectCommand(query, null);

                foreach (DataRow item in data.Rows)
                {
                    TableMenu table = new TableMenu(item);
                    list.Add(table);
                }
                return list;
            }

            public List<TableMenu> SortListTableMenuByLocation()
            {
                List<TableMenu> list = new List<TableMenu>();
                string query = string.Format("Select * from BANAN a, VITRI b where a.VITRI = b.MAVITRI and a.XOA = 0 order by a.VITRI ");
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
