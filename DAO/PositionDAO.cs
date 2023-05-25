using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class PositionDAO
    {
        private static PositionDAO instance;
        public static PositionDAO Instance
        {
            get { if (instance == null) instance = new PositionDAO(); return PositionDAO.instance; }
            private set { PositionDAO.instance = value; }
        }

        private PositionDAO()
        {

        }
        public Position GetPositionName(int id)
        {
            DataTable data = DataProvider.ExcecuteSelectCommand("Select * from CHUCVU where MACHUCVU = " + id, null);

            foreach (DataRow item in data.Rows)
            {
                return new Position(item);
            }

            return null;
        }

        public List<Position> GetListPosition()
        {
            List<Position> listPosition = new List<Position>();
            string query = string.Format("Select * from CHUCVU where xoa = 0");
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);

            foreach (DataRow item in data.Rows)
            {
                Position employee = new Position(item);
                listPosition.Add(employee);
            }
            return listPosition;
        }

        public int AddPosition(string tenchucvu)
        {
            string query = string.Format("insert chucvu(tenchucvu,xoa) values(N'{0}',0)", tenchucvu);
            int data = DataProvider.ExecuteInsertCommand(query, null);
            return data;
        }

        public int GetPositionIDMax()
        {
            int ID = 0;
            int id = DataProvider.ExecuteScalarCommand("select max(MACHUCVU) from chucvu", null);
            if (id != null)
            {
                ID = id;
            }
            return ID + 1;
        }

        public int UpdatePosition(int macv, string tencv)
        {
            string query = string.Format("update chucvu set tenchucvu=N'{0}' where machucvu={1}", tencv, macv);
            int data = DataProvider.ExecuteInsertCommand(query, null);
            return data;
        }

        public int DeletePosition(int macv)
        {
            string query = string.Format("update chucvu set xoa = 1 where machucvu={0}", macv);
            int data = DataProvider.ExecuteInsertCommand(query, null);
            return data;
        }

        public int DeleteAllPosition()
        {
            string query = string.Format("update chucvu set xoa = 1");
            int data = DataProvider.ExecuteInsertCommand(query, null);
            return data;
        }

        public List<Position> GetListPositionDeleted()
        {
            List<Position> listPosition = new List<Position>();
            string query = string.Format("Select * from CHUCVU where xoa = 1");
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);

            foreach (DataRow item in data.Rows)
            {
                Position employee = new Position(item);
                listPosition.Add(employee);
            }
            return listPosition;
        }

        public int RestorePosition(int macv)
        {
            string query = string.Format("update chucvu set xoa = 0 where machucvu={0}", macv);
            int data = DataProvider.ExecuteInsertCommand(query, null);
            return data;
        }

        public int RestoreAllPosition()
        {
            string query = string.Format("update chucvu set xoa = 0");
            int data = DataProvider.ExecuteInsertCommand(query, null);
            return data;
        }
        public bool checkNameExist( string tenloai)
        {
            string query = string.Format("Select count(*) from CHUCVU where  tenchucvu= N'{0}'", tenloai);
            int data = DataProvider.ExecuteScalarCommand(query, null);
            return data > 0 ? false : true;
        }
        public bool checkExistDelete(string maloai)
        {
            string query = string.Format("Select count(*) from NHANVIEN where machucvu={0}", maloai);
            int data = DataProvider.ExecuteScalarCommand(query, null);
            return data > 0 ? false : true;
        }
    }
}
