using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
namespace DAO
{
    public class DiscountDAO
    {
        private static DiscountDAO instance;
        public static DiscountDAO Instance
        {
            get { if (instance == null) instance = new DiscountDAO(); return DiscountDAO.instance; }
            private set { DiscountDAO.instance = value; }
        }

        private DiscountDAO()
        {

        }

        public List<Discount> GetListDiscount()
        {
            List<Discount> list = new List<Discount>();
            string query = "SELECT * FROM GIAMGIA WHERE TRANGTHAI = 1";
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);

            foreach (DataRow item in data.Rows)
            {
                Discount discount = new Discount(item);
                list.Add(discount);
            }
            return list;
        }

        public List<Discount> GetListDiscountDeleted()
        {
            List<Discount> list = new List<Discount>();
            string query = "SELECT * FROM GIAMGIA WHERE TRANGTHAI = 0";
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);

            foreach (DataRow item in data.Rows)
            {
                Discount discount = new Discount(item);
                list.Add(discount);
            }
            return list;
        }

        public int AddNewDiscount(string discountName, string startDay, string endDay, float price, float limit)
        {
            int row;
            string query = string.Format("CREATE_NEW_DISCOUNT   N'{0}','{1}','{2}',{3},{4}", discountName, startDay, endDay, price,limit);
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

        public int EditDiscount(string discountID, string discountName, string startDay, string endDay, float price, int available, float limit)
        {
            int row;
            string query = string.Format("UPDATE GIAMGIA SET TENGIAMGIA = N'{0}' , NgayBatDau = '{1}' , NgayKetThuc = '{2}' , DONGIA = {3} , Hoatdong = {5} , HANMUC = {6} WHERE MAGIAM = '{4}' ", discountName, startDay, endDay, price, discountID, available,limit);
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

        public int DeleteDiscount(string discountID)
        {
            int row;
            string query = string.Format("UPDATE GIAMGIA SET TrangThai = 0  WHERE MAGIAM = '{0}' ", discountID);
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

        public int DeleteAllDiscount()
        {
            int row;
            string query = string.Format("UPDATE GIAMGIA SET TrangThai = 0  ");
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

        public int RestoreDiscount(string discountID)
        {
            int row;
            string query = string.Format("UPDATE GIAMGIA SET TrangThai = 1  WHERE MAGIAM = '{0}' ", discountID);
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

        public int RestoreAllDiscount()
        {
            int row;
            string query = string.Format("UPDATE GIAMGIA SET TrangThai = 1  ");
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

        public Discount GetDiscountForID(string ID)
        {
            string query = string.Format("Select * from giamgia where magiam='{0}' and trangthai=1 ", ID);
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);

            foreach (DataRow item in data.Rows)
            {
                return new Discount(item);
            }
            
            return null;
        }

        public List<Discount> GetListDiscountAvailable()
        {
            List<Discount> list = new List<Discount>();
            string query = "SELECT * FROM GIAMGIA WHERE TRANGTHAI = 1  and HOATDONG=1";
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);

            foreach (DataRow item in data.Rows)
            {
                Discount discount = new Discount(item);
                list.Add(discount);
            }
            return list;
        }

        public List<Discount> GetListDiscountForID(string DiscountID)
        {
            List<Discount> list = new List<Discount>();
            string query = string.Format("SELECT * FROM GIAMGIA WHERE TRANGTHAI = 1 and MAGIAM='{0}'",DiscountID);
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);

            foreach (DataRow item in data.Rows)
            {
                Discount discount = new Discount(item);
                list.Add(discount);
            }
            return list;
        }
        public bool checkNameExist(string discountName)
        {
            string query = string.Format("Select count(*) from GIAMGIA where TENGIAMGIA='{0}'", discountName);
            int data = DataProvider.ExecuteScalarCommand(query, null);
            return data > 0 ? false : true;
        }
        public bool CheckNameExistToEdit(string discountName ,string discountID)
        {
            string query = string.Format("Select count(*) from GIAMGIA where TENGIAMGIA= N'{0}' and MAGIAM != '{1}' ", discountName,discountID);
            int data = DataProvider.ExecuteScalarCommand(query, null);
            return data > 0 ? false : true;
        }
    }
}
