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
            return TableDAO.Instance.EditTable(maBan,tenBan,maViTri);
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
        public int UpdateTableNull(int tableid)
        {
            return TableDAO.Instance.UpdateTable(tableid);
        }
        public List<Table> GetListTablesTrong()
        {
            return TableDAO.Instance.GetListTablesTrong();
        }
        public int UpdateTable(string maBAN)
        {
            return TableDAO.Instance.UpdateTable1(maBAN);
        }

        public int UpdateTablePay(int TableID)
        {
            return TableDAO.Instance.UpdateTablePay(TableID);
        }
    }
}
