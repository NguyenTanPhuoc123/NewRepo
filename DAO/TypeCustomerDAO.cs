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
            string query = string.Format("INSERT LOAIKHACHHANG(TENLOAI,TRANGTHAI) VALUES(N'{0}',1)", typeName);
            int row = DataProvider.ExecuteInsertCommand(query, null);
            return row;
        }

        public int EditTypeCustomer(int typeID,string typeName)
        {
            string query = string.Format("UPDATE LOAIKHACHHANG SET TENLOAI = N'{0}' WHERE MALOAI = {1} ", typeName,typeID);
            int row = DataProvider.ExecuteInsertCommand(query, null);
            return row;
        }

        public int DeleteTypeCustomer(int typeID)
        {
            string query = string.Format("UPDATE LOAIKHACHHANG SET TrangThai = 0  WHERE MALOAI = {0} ", typeID);
            int row = DataProvider.ExecuteInsertCommand(query, null);
            return row;
        }

        public int DeleteAllTypeCustomer()
        {
            string query = string.Format("UPDATE LOAIKHACHHANG SET TrangThai = 0");
            int row = DataProvider.ExecuteInsertCommand(query, null);
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
