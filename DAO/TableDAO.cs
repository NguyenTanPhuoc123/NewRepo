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
            int max;           
            string query = "Select MAX(MABANAN) from BANAN";
            try
            {
                max = DataProvider.ExecuteScalarCommand(query, null);
            }
            catch
            {
                max = 0;
            }
            return max + 1;
        }

        public int AddTable(string tenBan, int maVitri)
        {
            string query = string.Format("Insert BANAN(TENBAN,VITRI,TRANGTHAI) values(N'{0}',{1},N'Trống')", tenBan, maVitri);
            int row = 0;
            try
            {
                row = DataProvider.ExecuteInsertCommand(query, null);
            }
            catch
            {
                row = 0;
            }
            return row;
        }

        public int EditTable(int maBan, string tenBan, int maViTri)
        {
            string query = string.Format("Update BANAN SET TENBAN = N'{0}' , VITRI = {1} where MABANAN = {2}", tenBan, maViTri, maBan);
            int row;
            try
            {
                row = DataProvider.ExecuteInsertCommand(query, null);
            }
            catch
            {
                row = 0;
            }
            return row;
        }

        public int DeleteTable(int maBan)
        {
            string query = string.Format("Update BANAN SET XOA = 1 where MABANAN = {0}", maBan);
            int row;
            try
            {
                row = DataProvider.ExecuteInsertCommand(query, null);
            }
            catch
            {
                row = 0;
            }
            return row;
        }

        public int DeleteAllTable()
        {
            string query = string.Format("Update BANAN SET XOA = 1 ");
            int row;
            try
            {
                row = DataProvider.ExecuteInsertCommand(query, null);
            }
            catch
            {
                row = 0;
            }
            return row;
        }

        public int RestoreTable(int maBan)
        {
            string query = string.Format("Update BANAN SET XOA = 0 where MABANAN = {0}", maBan);
            int row;
            try { 
            row = DataProvider.ExecuteInsertCommand(query, null);
            }
            catch
            {
                row = 0;
            }
            return row;
        }

        public int RestoreAllTable()
        {
            string query = string.Format("Update BANAN SET XOA = 0 ");
            int row;
            try
            {
                row = DataProvider.ExecuteInsertCommand(query, null);
            }
            catch
            {
                row = 0;
            }
            return row;
        }

        public int UpdateTable(int maBAN)
        {
            string query = string.Format("Update BANAN SET TRANGTHAI = N'Trống' where MABANAN = {0}",maBAN);
            int row = 0;
            row = DataProvider.ExecuteInsertCommand(query, null);
            return row;
        }
        public List<Table> GetListTablesTrong()
        {
            string query = "";
            List<Table> listTable = new List<Table>();
            query = string.Format("select * from BANAN where XOA = 0 and TrangThai = N'Trống'");

            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);
            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                listTable.Add(table);
            }

            return listTable;
        }
        public int UpdateTable1(string maBAN)
        {
            string query = string.Format("Update BANAN SET TRANGTHAI = N'Có Người' where MABANAN = {0}", maBAN);
            int row = 0;
            row = DataProvider.ExecuteInsertCommand(query, null);
            return row;
        }

        public int UpdateTablePay(int TableID)
        {
            string query = string.Format("Update BANAN SET TRANGTHAI = N'Trống' where MABANAN = {0} and TRANGTHAI=N'Có người'", TableID);
            int row = DataProvider.ExecuteInsertCommand(query, null);
            return row;
        }
        public bool CheckTableNameExist(string tenban)
        {
            string query = string.Format("Select count(*) from BanAn where TENBAN = N'{0}' ",  tenban);
            int data = DataProvider.ExecuteScalarCommand(query, null);
            return data == 0 ? true : false;
        }
        public bool CheckTableNameExist(string tenban,string maban)
        {
            string query = string.Format("Select count(*) from BanAn where TENBAN = N'{0}' and mabanan !={1} ", tenban,maban);
            int data = DataProvider.ExecuteScalarCommand(query, null);
            return data == 0 ? true : false;
        }
        public bool CheckExistDelete(string TableID)
        {
            string sql = string.Format("Select count(*) from BanAn where MABANAN ={0} And TRANGTHAI =N'Có người'", TableID);
            int data = DataProvider.ExecuteScalarCommand(sql, null);
            return data > 0 ? false : true;
        }
    }
}
