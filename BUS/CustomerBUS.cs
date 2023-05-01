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

        public int AddNewCustomer(string name, string phone, int type,string gender)
        {
            return CustomerDAO.Instance.AddNewCustomer(name, phone, type,gender);
        }

        public int EditCustomer(string id, string name, string phone, int type, string gender)
        {
            return CustomerDAO.Instance.EditCustomer(id,name, phone, type,gender);
        }

        public int DeleteCustomer(string id)
        {
            return CustomerDAO.Instance.DeleteCustomer(id);
        }

        public int DeleteAllCustomer()
        {
            return CustomerDAO.Instance.DeleteAllCustomer();
        }

        public string GetCustomerID()
        {
            return CustomerDAO.Instance.GetCustomerID();
        }

       
        public int RestoreCustomer(string id)
        {
            return CustomerDAO.Instance.RestoreCustomer(id);
        }

        public int RestoreAllCustomer()
        {
            return CustomerDAO.Instance.RestoreAllCustomer();
        }

        public bool CheckNumberPhone(string phone,string customerID)
        {
            return CustomerDAO.Instance.CheckNumberPhone(phone,customerID);
        }
    }
}
