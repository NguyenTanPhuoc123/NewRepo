using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
namespace DAO
{
    public class CustomerDAO
    {
        private static CustomerDAO instance;
        
        public static CustomerDAO Instance
        {
            get { if (instance == null) instance = new CustomerDAO(); return CustomerDAO.instance; }
            private set { CustomerDAO.instance = value; }
        }

        private CustomerDAO()
        {

        }

        public List<Customer> GetListCustomer()
        {
            List<Customer> list = new List<Customer>();
            string query = "SELECT * FROM Customer WHERE TrangThai = 1";
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);
            foreach(DataRow item in data.Rows)
            {
                Customer customer = new Customer(item);
                list.Add(customer);
                
            }
            return list;
        }

        public List<Customer> GetListAllCustomer()
        {
            List<Customer> list = new List<Customer>();
            string query = "SELECT * FROM Customer";
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);
            foreach (DataRow item in data.Rows)
            {
                Customer customer = new Customer(item);
                list.Add(customer);

            }
            return list;
        }

        public int AddNewCustomer(string name, string phone, int type)
        {
<<<<<<< HEAD
            string id = string.Format("KH{0}", GetListAllCustomer().Count+1);
=======

            string id = string.Format("KH{0}", count + 1);
>>>>>>> e6a619c7aafe457ca087e59e2c4851fe5e5443df
            string query = String.Format("INSERT KHACHHANG VALUES('{0}',N'{1}','{2}',1,{3})",id, name, phone, type);
            int row = DataProvider.ExecuteInsertCommand(query, null);
            return row;
        }

        public int EditCustomer(string id, string name, string phone, int type)
        {
            string query = String.Format("UPDATE KHACHHANG SET TENKH = {1} , SODIENTHOAI = {2} , LOAIKH = {3} WHERE MAKH = {0}", id, name, phone, type);
            int row = DataProvider.ExecuteInsertCommand(query, null);
            return row;
        }

        public int DeleteCustomer(string id)
        {
            string query = String.Format("UPDATE KHACHHANG SET TRANGTHAI = 0 WHERE MAKH = {0}", id);
            int row = DataProvider.ExecuteInsertCommand(query, null);
            return row;
        }

        public int DeleteAllCustomer()
        {
            string query = String.Format("UPDATE KHACHHANG SET TRANGTHAI = 0 ");
            int row = DataProvider.ExecuteInsertCommand(query, null);
            return row;
        }
    }
}
