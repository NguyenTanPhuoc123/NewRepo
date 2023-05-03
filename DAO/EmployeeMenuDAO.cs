using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class EmployeeMenuDAO
    {
        private static EmployeeMenuDAO instance;
        public static EmployeeMenuDAO Instance
        {
            get { if (instance == null) instance = new EmployeeMenuDAO(); return EmployeeMenuDAO.instance; }
            private set { EmployeeMenuDAO.instance = value; }
        }

        private EmployeeMenuDAO()
        {

        }
        public List<EmployeeMenu> GetListEmployee()
        {
            List<EmployeeMenu> lst = new List<EmployeeMenu>();
            string query = "select * from CHUCVU a, NHANVIEN b where b.trangthai=1 and a.MACHUCVU = b.MACHUCVU";
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);
            foreach (DataRow item in data.Rows)
            {
                EmployeeMenu acc = new EmployeeMenu(item);
                lst.Add(acc);
            }
            return lst;
        }

        public List<EmployeeMenu> GetListEmployeeDeleted()
        {
            List<EmployeeMenu> lst = new List<EmployeeMenu>();
            string query = "select * from CHUCVU a, NHANVIEN b where b.trangthai=0 and a.MACHUCVU = b.MACHUCVU";
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);
            foreach (DataRow item in data.Rows)
            {
                EmployeeMenu acc = new EmployeeMenu(item);
                lst.Add(acc);
            }
            return lst;
        }

        public List<Position> GetListPosition()
        {
            List<Position> listPosition = new List<Position>();
            string query = string.Format("Select * from CHUCVU");
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);

            foreach (DataRow item in data.Rows)
            {
                Position employee = new Position(item);
                listPosition.Add(employee);
            }
            return listPosition;
        }

        public List<EmployeeMenu> SearchEmloyeeName(string employeeName)
        {
            List<EmployeeMenu> lst = new List<EmployeeMenu>();
            string query = string.Format("select * from CHUCVU a, NHANVIEN b where b.trangthai=1 and a.MACHUCVU = b.MACHUCVU and dbo.fChuyenCoDauThanhKhongDau(b.TENNV) like dbo.fChuyenCoDauThanhKhongDau(N'%{0}%')", employeeName);
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);
            foreach (DataRow item in data.Rows)
            {
                EmployeeMenu acc = new EmployeeMenu(item);
                lst.Add(acc);
            }
            return lst;
        }

        public List<EmployeeMenu> SortListEmployeeByEmployeeID(int positionID)
        {
            List<EmployeeMenu> lst = new List<EmployeeMenu>();
            string query = string.Format("select * from CHUCVU a, NHANVIEN b where b.trangthai=1 and a.MACHUCVU = b.MACHUCVU and a.MACHUCVU = {0} order by b.manv", positionID);
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);
            foreach (DataRow item in data.Rows)
            {
                EmployeeMenu acc = new EmployeeMenu(item);
                lst.Add(acc);
            }
            return lst;
        }

        public List<EmployeeMenu> SortListEmployeeByEmployeeName(int positionID)
        {
            List<EmployeeMenu> lst = new List<EmployeeMenu>();
            string query = string.Format("select * from CHUCVU a, NHANVIEN b where b.trangthai=1 and a.MACHUCVU = b.MACHUCVU and a.MACHUCVU = {0} order by LTRIM(RIGHT (TENNV, CHARINDEX(CHAR(32), REVERSE(TENNV))))", positionID);
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);
            foreach (DataRow item in data.Rows)
            {
                EmployeeMenu acc = new EmployeeMenu(item);
                lst.Add(acc);
            }
            return lst;
        }

        public List<EmployeeMenu> FillEmployeeByPosition(int positionID)
        {
            List<EmployeeMenu> lst = new List<EmployeeMenu>();
            string query = string.Format("select * from CHUCVU a, NHANVIEN b where b.trangthai=1 and a.MACHUCVU = b.MACHUCVU and a.MACHUCVU = {0}", positionID);
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);
            foreach (DataRow item in data.Rows)
            {
                EmployeeMenu acc = new EmployeeMenu(item);
                lst.Add(acc);
            }
            return lst;
        }

        public List<EmployeeMenu> FillEmployee()
        {
            List<EmployeeMenu> lst = new List<EmployeeMenu>();
            string query = "select * from CHUCVU a, NHANVIEN b where b.trangthai=1 and a.MACHUCVU = b.MACHUCVU";
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);
            foreach (DataRow item in data.Rows)
            {
                EmployeeMenu acc = new EmployeeMenu(item);
                lst.Add(acc);
            }
            return lst;
        }
    }
}
