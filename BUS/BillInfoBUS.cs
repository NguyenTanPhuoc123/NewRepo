using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class BillInfoBUS
    {
        private static BillInfoBUS instance;
        public static BillInfoBUS Instance
        {
            get { if (instance == null) instance = new BillInfoBUS(); return BillInfoBUS.instance; }
            private set { BillInfoBUS.instance = value; }
        }

        private BillInfoBUS()
        {

        }

        public List<BillInfo> GetListBill()
        {
            return BillInfoDAO.Instance.GetListBillInfo();
        }

        public int InsertNewBillInfo(string billID, string productID, float price, string count, float total)
        {
            return BillInfoDAO.Instance.InsertNewBillInfo(billID, productID, price,count, total);
        }


        public int DeleteBillInfo(string billID, string productID)
        {
            return BillInfoDAO.Instance.DeleteBillInfo(billID, productID);
        }

        public int DeleteAllBillInfo()
        {
            return BillInfoDAO.Instance.DeleteAllBillInfo();
        }

        public int RestoreBillInfo(string billID, string productID)
        {
            return BillInfoDAO.Instance.RestoreBillInfo(billID, productID);
        }

        public int RestoreAllBillInfo()
        {
            return BillInfoDAO.Instance.RestoreAllBillInfo();
        }


        public bool CheckProduct(string ProductID,string BillID)
        {
            return BillInfoDAO.Instance.CheckProduct(ProductID,BillID);
        }
        public void UpdateCount(string soluong, string ProductID,string BillID)
        {
            BillInfoDAO.Instance.UpdateCount(soluong, ProductID,BillID);
        }
        public bool CheckProductDeleted(string ProductID, string mahd)
        {
           return BillInfoDAO.Instance.CheckProductDeleted(ProductID, mahd);
        }
        public void UpdateProduct(string soluong, string ProductID, string mahd, float thanhtien)
        {
            BillInfoDAO.Instance.UpdateProduct(soluong, ProductID, mahd, thanhtien);
        }
        public bool CheckProduct(string ProductID)
        {
            return BillInfoDAO.Instance.CheckProduct(ProductID);
        }

        public bool CheckProduct()
        {
            return BillInfoDAO.Instance.CheckProduct();
        }
    }
}