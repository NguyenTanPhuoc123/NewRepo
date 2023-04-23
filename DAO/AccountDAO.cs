using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return AccountDAO.instance; }
            private set { AccountDAO.instance = value; }
        }

        private AccountDAO()
        {

        }

        public bool CheckLogin(string username, string password)
        {
            string sql = "select count(*) from taikhoan where TENDANGNHAP = @username AND MATKHAU = @password and trangthai = 1";
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@username", username);
            parameters[1] = new SqlParameter("@password", Utils.GetMD5(password));
            if (DataProvider.ExecuteScalarCommand(sql, parameters) == 1)
            {
                return true;
            }
            return false;
        }

        public List<Account> GetListAccount()
        {
            List<Account> lst = new List<Account>();
            string query = "select a.tendangnhap ,a.matkhau,a.manv,a.loaitaikhoan,b.tennv,c.tenloai  from taikhoan a ,nhanvien  b,loaitaikhoan c where a.trangthai=1 and a.MANV = b.MANV and a.LOAITAIKHOAN = c.MALOAI";
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);
            foreach (DataRow item in data.Rows)
            {
                Account acc = new Account(item);
                lst.Add(acc);
            }
            return lst;
        }


        public List<Account> GetListAccountDeleted()
        {
            List<Account> lst = new List<Account>();
            string query = "select * from taikhoan where trangthai=0";
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);
            foreach (DataRow item in data.Rows)
            {
                Account acc = new Account(item);
                lst.Add(acc);
            }
            return lst;
        }

        public Account GetAccountForUsername(string username)
        {
            DataTable data = DataProvider.ExcecuteSelectCommand("Select * from TAIKHOAN where TENDANGNHAP = '" + username + "'", null);

            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }

            return null;
        }
        public int UpdatePassword(string passwordNew, string username)
        {
            string query = string.Format("UPDATE TAIKHOAN SET MATKHAU = '{0}' WHERE TENDANGNHAP='{1}'", Utils.GetMD5(passwordNew), username);
            int data = DataProvider.ExecuteInsertCommand(query, null);
            return data;
        }

        public int DeleteAllAccount()
        {
            string query = "update taikhoan set trangthai = 0";
            int data = DataProvider.ExecuteInsertCommand(query, null);
            return data;
        }

        public int RestoreAllAccount()
        {
            string query = "update taikhoan set trangthai = 1";
            int data = DataProvider.ExecuteInsertCommand(query, null);
            return data;
        }

        public int DeleteAccountByUserName(string username)
        {
            string query = string.Format("update taikhoan set trangthai = 0 where tendangnhap = '{0}'", username);
            int data = DataProvider.ExecuteInsertCommand(query, null);
            return data;
        }

        public int RestoreAccountByUserName(string username)
        {
            string query = string.Format("update taikhoan set trangthai = 1 where tendangnhap = '{0}'", username);
            int data = DataProvider.ExecuteInsertCommand(query, null);
            return data;
        }

        public int AddAccount(string username, string password, string employeeID, string typeEmployID)
        {
            string query = string.Format("insert taikhoan values('{0}' , '{1}', {2} , {3} , 1)", username, Utils.GetMD5(password), employeeID, typeEmployID);
            int data = DataProvider.ExecuteInsertCommand(query, null);
            return data;
        }

        public int EditAccount(string username, string employeeID, string typeEmployID)
        {
            string query = string.Format("update taikhoan set manv={0}, loaitaikhoan={1} where tendangnhap='{2}'", employeeID, typeEmployID, username);
            int data = DataProvider.ExecuteInsertCommand(query, null);
            return data;
        }
    }
}
