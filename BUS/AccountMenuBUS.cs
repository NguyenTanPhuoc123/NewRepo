using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class AccountMenuBUS
    {
        private static AccountMenuBUS instance;
        public static AccountMenuBUS Instance
        {
            get { if (instance == null) instance = new AccountMenuBUS(); return AccountMenuBUS.instance; }
            private set { AccountMenuBUS.instance = value; }
        }

        public List<AccountMenu> GetListAccount()
        {
            return AccountMenuDAO.Instance.GetListAccount();
        }

        public List<AccountMenu> SearchAccountByEmloyeeName(string employeeName)
        {
            return AccountMenuDAO.Instance.SearchAccountByEmloyeeName(employeeName);
        }

        public List<AccountMenu> SortListAccountByUsername(int typeAccount)
        {
            return AccountMenuDAO.Instance.SortListAccountByUsername(typeAccount);
        }

        public List<AccountMenu> SortListAccountByEmployeeName(int typeAccount)
        {
            return AccountMenuDAO.Instance.SortListAccountByEmployeeName(typeAccount);
        }

        public List<AccountMenu> FillListAccount(int typeAccount)
        {
            return AccountMenuDAO.Instance.FillListAccount(typeAccount);
        }
    }
}
