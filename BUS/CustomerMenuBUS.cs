using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class CustomerMenuBUS
    {
        private static CustomerMenuBUS instance;
 
        public static CustomerMenuBUS Instance
        {
            get { if (instance == null) instance = new CustomerMenuBUS(); return CustomerMenuBUS.instance; }
            private set { CustomerMenuBUS.instance = value; }
        }

        private CustomerMenuBUS()
        {

        }

        public List<CustomerMenu> GetListCustomerMenu()
        {
            return CustomerMenuDAO.Instance.GetListCustomerMenu();
        }

        public List<CustomerMenu> GetListCustomerMenuDeleted()
        {
            return CustomerMenuDAO.Instance.GetListCustomerMenuDeleted();
        }

        public List<CustomerMenu> SearchCustomerByName(string name)
        {
            return CustomerMenuDAO.Instance.SearchCustomerByName(name);
        }

<<<<<<< HEAD
       
=======
        public List<CustomerMenu> SortCustomerByID(int typeID)
        {
            return CustomerMenuDAO.Instance.SortCustomerByID(typeID);
        }

        public List<CustomerMenu> SortCustomerByIDDecrease(int typeID)
        {
            return CustomerMenuDAO.Instance.SortCustomerByIDDecrease(typeID);
        }

        public List<CustomerMenu> SortCustomerByName(int typeID)
        {
            return CustomerMenuDAO.Instance.SortCustomerByName(typeID);
        }

        public List<CustomerMenu> SortCustomerByNameDecrease(int typeID)
        {
            return CustomerMenuDAO.Instance.SortCustomerByNameDecrease(typeID);
        }

        public List<CustomerMenu> FillListCustomerMenu(int typeID)
        {
            return CustomerMenuDAO.Instance.FillListCustomerMenu(typeID);
        }
>>>>>>> 48c3914ddd7f5b16947abace3ded29db95a6cf44
    }
}
