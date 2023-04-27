using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
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

        public List<CustomerMenu> GetListCustomerMenuDeleted()
        {
            List<CustomerMenu> list = new List<CustomerMenu>();
            string query = "SELECT * FROM KHACHHANG a, LoaiKhachHang b WHERE a.LoaiKH = b.MaLoai and a.TrangThai = 0";
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);

            foreach (DataRow item in data.Rows)
            {
                CustomerMenu customerMenu = new CustomerMenu(item);
                list.Add(customerMenu);
            }
            return list;
        }

        public List<CustomerMenu> SearchCustomerByName(string name)
        {
            List<CustomerMenu> list = new List<CustomerMenu>();
            string query = string.Format("SELECT * FROM KHACHHANG a, LOAIKHACHHANG b WHERE a.LoaiKH = b.MaLoai and a.TrangThai = 1 and   dbo.fChuyenCoDauThanhKhongDau(a.TenKH) LIKE dbo.fChuyenCoDauThanhKhongDau(N'%{0}%')", name);
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);

            foreach (DataRow item in data.Rows)
            {
                CustomerMenu customerMenu = new CustomerMenu(item);
                list.Add(customerMenu);
            }
            return list;
        }

        
    }
}
