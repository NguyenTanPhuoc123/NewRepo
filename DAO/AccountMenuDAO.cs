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

        public List<AccountMenu> SortListAccountByUsername(int typeAccount)
        {
            List<AccountMenu> lst = new List<AccountMenu>();
            string query = "";
            if (typeAccount > 0)
                query = string.Format("select * from TAIKHOAN a, NHANVIEN b, LOAITAIKHOAN c where a.trangthai=1 and a.MANV = b.MANV and a.LOAITAIKHOAN = {0} order by a.TENDANGNHAP", typeAccount);
            else
                query = "select * from TAIKHOAN a, NHANVIEN b, LOAITAIKHOAN c where a.trangthai=1 and a.MANV = b.MANV order by a.TENDANGNHAP";
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);
            foreach (DataRow item in data.Rows)
            {
                AccountMenu acc = new AccountMenu(item);
                lst.Add(acc);
            }
            return lst;
        }

        public List<AccountMenu> SortListAccountByEmployeeName(int typeAccount)
        {
            List<AccountMenu> lst = new List<AccountMenu>();
            string query = "";
            if (typeAccount > 0)
                query = string.Format("select * from TAIKHOAN a, NHANVIEN b, LOAITAIKHOAN c where a.trangthai=1 and a.MANV = b.MANV and a.LOAITAIKHOAN = {0} order by LTRIM(RIGHT (TENNV, CHARINDEX(CHAR(32), REVERSE(TENNV))))", typeAccount);
            else
                query = "select * from TAIKHOAN a, NHANVIEN b, LOAITAIKHOAN c where a.trangthai=1 and a.MANV = b.MANV order by LTRIM(RIGHT (TENNV, CHARINDEX(CHAR(32), REVERSE(TENNV))))";
            
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);
            foreach (DataRow item in data.Rows)
            {
                AccountMenu acc = new AccountMenu(item);
                lst.Add(acc);
            }
            return lst;
        }

        public List<AccountMenu> FillListAccount(int typeAccount)
        {
            List<AccountMenu> lst = new List<AccountMenu>();
            string query = "";
            if (typeAccount > 0)
                query = string.Format("select * from TAIKHOAN a, NHANVIEN b, LOAITAIKHOAN c where a.trangthai=1 and a.MANV = b.MANV and c.MALOAI={0}", typeAccount);
            else
                query = "select * from TAIKHOAN a, NHANVIEN b, LOAITAIKHOAN c where a.trangthai=1 and a.MANV = b.MANV";
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
