using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class CustomerBUS
    {
        private static CustomerBUS instance;

        public static CustomerBUS Instance
        {
            get { if (instance == null) instance = new CustomerBUS(); return CustomerBUS.instance; }
            private set { CustomerBUS.instance = value; }
        }

        private CustomerBUS()
        {

        }

        public List<Customer> GetListCustomer()
        {
            return CustomerDAO.Instance.GetListCustomer();
        }

        public List<Customer> GetListAllCustomer()
        {
            return CustomerDAO.Instance.GetListAllCustomer();
        }

        public int AddNewCustomer(string name, string phone, int type)
        {
            return CustomerDAO.Instance.AddNewCustomer(name, phone, type);
        }

        public int EditCustomer(string id, string name, string phone, int type)
        {
            return CustomerDAO.Instance.EditCustomer(id,name, phone, type);
        }

        public int DeleteCustomer(string id)
        {
            return CustomerDAO.Instance.DeleteCustomer(id);
        }

        public int DeleteAllCustomer()
        {
            return CustomerDAO.Instance.DeleteAllCustomer();
        }
    }
}
