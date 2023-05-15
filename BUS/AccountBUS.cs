using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class AccountBUS
    {
        private static AccountBUS instance;
        public static AccountBUS Instance
        {
            get { if (instance == null) instance = new AccountBUS(); return AccountBUS.instance; }
            private set { AccountBUS.instance = value; }
        }

        public bool CheckLogin(string username, string password)
        {
            return AccountDAO.Instance.CheckLogin(username, password);
        }

        public bool CheckUsername(string userName)
        {
            return AccountDAO.Instance.CheckUsername(userName);
        }

        public bool CheckExistEmployee(int employeeID)
        {
            return AccountDAO.Instance.CheckExistEmployee(employeeID);
        }

        public List<Account> GetListAccount()
        {
            return AccountDAO.Instance.GetListAccount();
        }

        public List<Account> GetListAccountDeleted()
        {
            return AccountDAO.Instance.GetListAccountDeleted();
        }

        public Account GetAccountForUsername(string username)
        {
            return AccountDAO.Instance.GetAccountForUsername(username);
        }

        public int UpdatePassword(string passwordNew, string username)
        {
            return AccountDAO.Instance.UpdatePassword(passwordNew, username);
        }

        public int DeleteAllAccount()
        {
            return AccountDAO.Instance.DeleteAllAccount();
        }

        public int RestoreAllAccount()
        {
            return AccountDAO.Instance.RestoreAllAccount();
        }

        public int DeleteAccountByUserName(string username)
        {
            return AccountDAO.Instance.DeleteAccountByUserName(username);
        }

        public int RestoreAccountByUserName(string username)
        {
            return AccountDAO.Instance.RestoreAccountByUserName(username);
        }

        public int AddAccount(string username, string password, string employeeID, string typeEmployID)
        {
            return AccountDAO.Instance.AddAccount(username, password, employeeID, typeEmployID);
        }

        public int EditAccount(string username, string employeeID, string typeEmployID)
        {
            return AccountDAO.Instance.EditAccount(username, employeeID, typeEmployID);
        }

        public string GetMD5(string password)
        {
            return AccountDAO.Instance.GetMD5(password);
        }
    }
}
