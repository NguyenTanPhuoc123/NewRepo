using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class TypeCustomerDAO
    {
        private static TypeCustomerDAO instance;

        public static TypeCustomerDAO Instance
        {
            get { if (instance == null) instance = new TypeCustomerDAO(); return TypeCustomerDAO.instance; }
            private set { TypeCustomerDAO.instance = value; }
        }

        private TypeCustomerDAO()
        {

        }

        public List<TypeCustomer> GetListTypeCustomer()
        {
            List<TypeCustomer> list = new List<TypeCustomer>();
            string query = "SELECT * FROM LOAIKHACHHANG WHERE TrangThai = 1";
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);

            foreach(DataRow item in data.Rows)
            {
                TypeCustomer typeCus = new TypeCustomer(item);
                list.Add(typeCus);
            }
            return list;
        }

        public int AddTypeCustomer(string typeName)
        {
            int row;
            string query = string.Format("INSERT LOAIKHACHHANG(TENLOAI,TRANGTHAI) VALUES(N'{0}',1)", typeName);
            try
            {
                row = DataProvider.ExecuteInsertCommand(query, null);
            }
            catch
            {
                row = 0;
            }
            return row;
        }

        public int EditTypeCustomer(int typeID,string typeName)
        {
            int row;
            string query = string.Format("UPDATE LOAIKHACHHANG SET TENLOAI = N'{0}' WHERE MALOAI = {1} ", typeName,typeID);
            try
            {
                row = DataProvider.ExecuteInsertCommand(query, null);
            }
            catch
            {
                row = 0;
            }
            return row;
        }

        public int DeleteTypeCustomer(int typeID)
        {
            int row = 0;
            if (!CheckExistTypeCustomer(typeID))
            {
                string query = string.Format("UPDATE LOAIKHACHHANG SET TrangThai = 0  WHERE MALOAI = {0} ", typeID);
                row = DataProvider.ExecuteInsertCommand(query, null);
            }

            return row;
        }

        public int DeleteAllTypeCustomer()
        {
            int count = 0;
            int row = 0;
            List<TypeCustomer> typeCustomers = GetListTypeCustomer();
            List<Customer> customers = CustomerDAO.Instance.GetListCustomer();
            foreach(TypeCustomer typeCustomer in typeCustomers)
            {
                foreach(Customer customer in customers)
                {
                    if (customer.LoaiKH == typeCustomer.TypeID)
                        count++;
                }
            }
            if (count == 0)
            {
                string query = string.Format("UPDATE LOAIKHACHHANG SET TrangThai = 0");
                row = DataProvider.ExecuteInsertCommand(query, null);
            }

            return row;
        }

        public int GetTypeCustomerIDMax()
        {
            string query = "SELECT MAX(MaLoai) from LOAIKHACHHANG";
            int id;
            try
            {
                id = DataProvider.ExecuteScalarCommand(query, null);
            }
            catch (Exception ex)
            {
                id = 0;
            }
            return id + 1;
        }

        public List<TypeCustomer> GetListTypeCustomerDeleted()
        {
            List<TypeCustomer> list = new List<TypeCustomer>();
            string query = "SELECT * FROM LOAIKHACHHANG WHERE TrangThai = 0";
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);

            foreach (DataRow item in data.Rows)
            {
                TypeCustomer typeCus = new TypeCustomer(item);
                list.Add(typeCus);
            }
            return list;
        }

        public bool CheckExistTypeCustomer(int typeID)
        {
            string query = string.Format("SELECT COUNT(MaKH) FROM KhachHang WHERE TrangThai = 1 AND LoaiKH = {0} ", typeID);
            int row = DataProvider.ExecuteScalarCommand(query, null);
            if (row > 0)
                return true;
            return false;
        }

        public int RestoreTypeCustomer(int typeID)
        {
            string query = string.Format("UPDATE LOAIKHACHHANG SET TrangThai = 1  WHERE MALOAI = {0} ", typeID);
            int row = DataProvider.ExecuteInsertCommand(query, null);
            return row;
        }

        public int RestoreAllTypeCustomer()
        {
            string query = string.Format("UPDATE LOAIKHACHHANG SET TrangThai = 1");
            int row = DataProvider.ExecuteInsertCommand(query, null);
            return row;
        }
    }
}
