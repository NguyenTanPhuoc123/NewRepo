using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class TableDAO
    {
        private static TableDAO instance;

        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; }
            private set { TableDAO.instance = value; }
        }

        private TableDAO()
        {

        }
        public List<Table> GetListTables()
        {
            string query = "";
            List<Table> listTable = new List<Table>();
            query = string.Format("select * from BANAN where XOA = 0");

            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);
            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                listTable.Add(table);
            }

            return listTable;
        }

        public List<Table> GetListTableByLocationID(int locationid)
        {

            List<Table> listTable = new List<Table>();
            string query = string.Format("select * from BANAN Where VITRI = {0} and XOA = 0 ", locationid);

            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);
            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                listTable.Add(table);
            }

            return listTable;
        }

        public int GetTableIDMax()
        {
            int max = 0;
            string query = "Select MAX(MABANAN) from BANAN";
            int data = DataProvider.ExecuteScalarCommand(query, null);
            if (data != null)
                max = data;

            return max + 1;
        }

        public int AddTable(string tenBan, int maVitri)
        {
            string query = string.Format("Insert BANAN(TENBAN,VITRI,TRANGTHAI) values(N'{0}',{1},N'Trống')", tenBan, maVitri);
            int row = 0;
            row = DataProvider.ExecuteInsertCommand(query, null);

            return row;
        }

        public int EditTable(int maBan, string tenBan, int maViTri)
        {
            string query = string.Format("Update BANAN SET TENBAN = N'{0}' , VITRI = {1} where MABANAN = {2}", tenBan, maViTri, maBan);
            int row = 0;
            row = DataProvider.ExecuteInsertCommand(query, null);

            return row;
        }

        public int DeleteTable(int maBan)
        {
            string query = string.Format("Update BANAN SET XOA = 1 where MABANAN = {0}", maBan);
            int row = 0;
            row = DataProvider.ExecuteInsertCommand(query, null);

            return row;
        }

        public int DeleteAllTable()
        {
            string query = string.Format("Update BANAN SET XOA = 1 ");
            int row = 0;
            row = DataProvider.ExecuteInsertCommand(query, null);

            return row;
        }

        public int RestoreTable(int maBan)
        {
            string query = string.Format("Update BANAN SET XOA = 0 where MABANAN = {0}", maBan);
            int row = 0;
            row = DataProvider.ExecuteInsertCommand(query, null);

            return row;
        }

        public int RestoreAllTable()
        {
            string query = string.Format("Update BANAN SET XOA = 0 ");
            int row = 0;
            row = DataProvider.ExecuteInsertCommand(query, null);

            return row;
        }
    }
}
