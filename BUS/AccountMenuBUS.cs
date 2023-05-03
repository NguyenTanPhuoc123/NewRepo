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

        public List<AccountMenu> SortListAccountByUsername()
        {
            return AccountMenuDAO.Instance.SortListAccountByUsername();
        }

        public List<AccountMenu> SortListAccountByEmployeeName()
        {
            return AccountMenuDAO.Instance.SortListAccountByEmployeeName();
        }

        public List<AccountMenu> FillListAccountIsSeller()
        {
            return AccountMenuDAO.Instance.FillListAccountIsSeller();
        }

        public List<AccountMenu> FillListAccountIsManager()
        {
            return AccountMenuDAO.Instance.FillListAccountIsManager();
        }
    }
}
