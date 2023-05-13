using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class DiscountBUS
    {
        private static DiscountBUS instance;
        public static DiscountBUS Instance
        {
            get { if (instance == null) instance = new DiscountBUS(); return DiscountBUS.instance; }
            private set { DiscountBUS.instance = value; }
        }

        private DiscountBUS()
        {

        }

        public List<Discount> GetListDiscount()
        {
            return DiscountDAO.Instance.GetListDiscount();
        }

        public int AddNewDiscount(string discountName, string startDay, string endDay, float price)
        {
            return DiscountDAO.Instance.AddNewDiscount(discountName, startDay, endDay, price);
        }

        public int EditDiscount(string discountID, string discountName, string startDay, string endDay, float price, int available)
        {
            return DiscountDAO.Instance.EditDiscount(discountID, discountName, startDay, endDay, price, available);
        }

        public int DeleteDiscount(string discountID)
        {
            return DiscountDAO.Instance.DeleteDiscount(discountID);
        }

        public int DeleteAllDiscount()
        {
            return DiscountDAO.Instance.DeleteAllDiscount();
        }

        public List<Discount> GetListDiscountDeleted()
        {
            return DiscountDAO.Instance.GetListDiscountDeleted();
        }

        public int RestoreDiscount(string discountID)
        {
            return DiscountDAO.Instance.RestoreDiscount(discountID);
        }

        public int RestoreAllDiscount()
        {
            return DiscountDAO.Instance.RestoreAllDiscount();
        }

        public Discount GetDiscountForID(string ID)
        {
            return DiscountDAO.Instance.GetDiscountForID(ID);
        }

        public List<Discount> GetListDiscountAvailable()
        {
            return DiscountDAO.Instance.GetListDiscountAvailable();
        }
    }
}
