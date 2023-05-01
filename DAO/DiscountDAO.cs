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

            foreach(DataRow item in data.Rows)
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

        public int AddNewDiscount(string discountName, string startDay, string endDay, float price)
        {
            int row;
            string query = string.Format("CREATE_NEW_DISCOUNT   N'{0}','{1}','{2}',{3}",discountName,startDay,endDay,price);
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

        public int EditDiscount(string discountID, string discountName, string startDay, string endDay, float price)
        {
            int row;
            string query = string.Format("UPDATE GIAMGIA SET TENGIAMGIA = N'{0}' , NgayBatDau = '{1}' , NgayKetThuc = '{2}' , DONGIA = {3} WHERE MAGIAM = '{4}' ", discountName, startDay, endDay, price, discountID);
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
            string query = string.Format("UPDATE GIAMGIA SET TrangThai = 0  WHERE MAGIAM = '{0}' ",discountID);
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

    }
}
