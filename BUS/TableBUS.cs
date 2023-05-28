using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class TableBUS
    {
        private static TableBUS instance;

        public static TableBUS Instance
        {
            get { if (instance == null) instance = new TableBUS(); return TableBUS.instance; }
            private set { TableBUS.instance = value; }
        }

        private TableBUS()
        {

        }
        public List<Table> GetListTables()
        {
            return TableDAO.Instance.GetListTables();
        }

        public List<Table> GetListTableByLocationID(int locationid)
        {
            return TableDAO.Instance.GetListTableByLocationID(locationid);
        }

        public int GetTableIDMax()
        {
            return TableDAO.Instance.GetTableIDMax();
        }

        public int AddTable(string tenBan, int maVitri)
        {
            return TableDAO.Instance.AddTable(tenBan, maVitri);
        }

        public int EditTable(int maBan, string tenBan, int maViTri)
        {
            return TableDAO.Instance.EditTable(maBan, tenBan, maViTri);
        }

        public int DeleteTable(int maBan)
        {
            return TableDAO.Instance.DeleteTable(maBan);
        }

        public int DeleteAllTable()
        {
            return TableDAO.Instance.DeleteAllTable();
        }

        public int RestoreTable(int maBan)
        {
            return TableDAO.Instance.RestoreTable(maBan);
        }

        public int RestoreAllTable()
        {
            return TableDAO.Instance.RestoreAllTable();
        }
        public int UpdateStatusTable(int tableID)
        {
            return TableDAO.Instance.UpdateStatusTable(tableID);
        }
       
        public int UpdateTablePay(int tableID)
        {
            return TableDAO.Instance.UpdateTablePay(tableID);
        }
        public bool CheckTableNameExist(string tableName)
        {
            return TableDAO.Instance.CheckTableNameExist(tableName);
        }
        public bool CheckTableNameExist(string tenban, string maban)
        {
            return TableDAO.Instance.CheckTableNameExist(tenban, maban);
        }
        public bool CheckExistDelete(string tableID)
        {
            return TableDAO.Instance.CheckExistDelete(tableID);
        }

        public int SwitchTable(int tableIdOld, int tableIdNew)
        {
            return TableDAO.Instance.SwitchTable(tableIdOld, tableIdNew);
        }

        public bool CheckBillInfoForTable(int tableID)
        {
            return TableDAO.Instance.CheckBillInfoForTable(tableID);
        }
    }
}
