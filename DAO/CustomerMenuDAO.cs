using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class CustomerMenuDAO
    {
        private static CustomerMenuDAO instance;
   
        public static CustomerMenuDAO Instance
        {
            get { if (instance == null) instance = new CustomerMenuDAO(); return CustomerMenuDAO.instance; }
            private set { CustomerMenuDAO.instance = value; }
        }

        private CustomerMenuDAO()
        {
                
        }

        public List<CustomerMenu> GetListCustomerMenu()
        {
            List<CustomerMenu> list = new List<CustomerMenu>();
            string query = "SELECT * FROM KHACHHANG a, LoaiKhachHang b WHERE a.LoaiKH = b.MaLoai and a.TrangThai = 1";
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);

            foreach(DataRow item in data.Rows)
            {
                CustomerMenu customerMenu = new CustomerMenu(item);
                list.Add(customerMenu);
            }
            return list;
        }
    }
}
