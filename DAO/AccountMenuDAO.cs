using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class AccountMenuDAO
    {

        private static AccountMenuDAO instance;
        public static AccountMenuDAO Instance
        {
            get { if (instance == null) instance = new AccountMenuDAO(); return instance; }
            private set { AccountMenuDAO.instance = value; }
        }

        private AccountMenuDAO()
        {

        }

        public List<AccountMenu> GetListAccount()
        {
            List<AccountMenu> lst = new List<AccountMenu>();
            string query = "select * from TAIKHOAN a, NHANVIEN b, LOAITAIKHOAN c where a.trangthai=1 and a.MANV = b.MANV and a.LOAITAIKHOAN = c.MALOAI";
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);
            foreach (DataRow item in data.Rows)
            {
                AccountMenu acc = new AccountMenu(item);
                lst.Add(acc);
            }
            return lst;
        }

        public List<AccountMenu> SearchAccountByEmloyeeName(string employeeName)
        {
            List<AccountMenu> lst = new List<AccountMenu>();
            string query = string.Format("select * from TAIKHOAN a, NHANVIEN b, LOAITAIKHOAN c where a.trangthai=1 and a.MANV = b.MANV and a.LOAITAIKHOAN = c.MALOAI and dbo.fChuyenCoDauThanhKhongDau(b.TENNV) like dbo.fChuyenCoDauThanhKhongDau(N'%{0}%')", employeeName);
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);
            foreach (DataRow item in data.Rows)
            {
                AccountMenu acc = new AccountMenu(item);
                lst.Add(acc);
            }
            return lst;
        }

        public List<AccountMenu> SortListAccountByUsername()
        {
            List<AccountMenu> lst = new List<AccountMenu>();
            string query = "select * from TAIKHOAN a, NHANVIEN b, LOAITAIKHOAN c where a.trangthai=1 and a.MANV = b.MANV and a.LOAITAIKHOAN = c.MALOAI order by a.TENDANGNHAP";
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);
            foreach (DataRow item in data.Rows)
            {
                AccountMenu acc = new AccountMenu(item);
                lst.Add(acc);
            }
            return lst;
        }

        public List<AccountMenu> SortListAccountByEmployeeName()
        {
            List<AccountMenu> lst = new List<AccountMenu>();
            string query = "select * from TAIKHOAN a, NHANVIEN b, LOAITAIKHOAN c where a.trangthai=1 and a.MANV = b.MANV and a.LOAITAIKHOAN = c.MALOAI order by LTRIM(RIGHT (TENNV, CHARINDEX(CHAR(32), REVERSE(TENNV))))";
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);
            foreach (DataRow item in data.Rows)
            {
                AccountMenu acc = new AccountMenu(item);
                lst.Add(acc);
            }
            return lst;
        }

        public List<AccountMenu> FillListAccountIsSeller()
        {
            List<AccountMenu> lst = new List<AccountMenu>();
            string query = "select * from TAIKHOAN a, NHANVIEN b, LOAITAIKHOAN c where a.trangthai=1 and a.MANV = b.MANV and a.LOAITAIKHOAN = c.MALOAI and a.LOAITAIKHOAN=2";
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);
            foreach (DataRow item in data.Rows)
            {
                AccountMenu acc = new AccountMenu(item);
                lst.Add(acc);
            }
            return lst;
        }

        public List<AccountMenu> FillListAccountIsManager()
        {
            List<AccountMenu> lst = new List<AccountMenu>();
            string query = "select * from TAIKHOAN a, NHANVIEN b, LOAITAIKHOAN c where a.trangthai=1 and a.MANV = b.MANV and a.LOAITAIKHOAN = c.MALOAI and a.LOAITAIKHOAN=1";
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);
            foreach (DataRow item in data.Rows)
            {
                AccountMenu acc = new AccountMenu(item);
                lst.Add(acc);
            }
            return lst;
        }
    }
}
