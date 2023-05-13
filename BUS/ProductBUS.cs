using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class ProductBUS
    {
        private static ProductBUS instance;
        public static ProductBUS Instance
        {
            get { if (instance == null) instance = new ProductBUS(); return ProductBUS.instance; }
            private set { ProductBUS.instance = value; }
        }
        public DataTable GetListProduct()
        {
            return ProductDAO.Instance.GetListProduct();
        }
        public string GetProductID()
        {
            return ProductDAO.Instance.GetProductID();
        }
        public bool CheckNameProduct(string productName)
        {
            return ProductDAO.Instance.CheckNameProduct(productName);
        }
        public DataTable GetProductDeleted()
        {
            return ProductDAO.Instance.GetProductDeleted();
        }
        public List<Product> GetProduct()
        {
            return ProductDAO.Instance.GetProduct();
        }
        public int ExecuteInsertCommand(Product product)
        {
            return ProductDAO.Instance.ExecuteInsertCommand(product);
        }
        public int DeleteProduct(string ProductID)
        {
            return ProductDAO.Instance.DeleteProduct(ProductID);
        }
        public int UpdateProduct(Product product)
        {
            return ProductDAO.Instance.UpdateProduct(product);
        }
        public DataTable GetListFillProduct(string CategoryName)
        {
            return ProductDAO.Instance.GetListFillProduct(CategoryName);
        }
        public DataTable GetListFindProduct(string productName)
        {
            return ProductDAO.Instance.GetListFindProduct(productName);
        }
        public DataTable SortProductName(string CategoryName)
        {
            return ProductDAO.Instance.SortProductName(CategoryName);
        }
        public DataTable SortSoLuongASC(string CategoryName)
        {
            return ProductDAO.Instance.SortSoLuongASC(CategoryName);
        }
        public DataTable SortSoLuongDESC(string CategoryName)
        {
            return ProductDAO.Instance.SortSoLuongDESC(CategoryName);
        }
        public DataTable SortDonGiaASC(string CategoryName)
        {
            return ProductDAO.Instance.SortDonGiaASC(CategoryName);
        }
        public DataTable SortDonGiaDESC(string CategoryName)
        {
            return ProductDAO.Instance.SortDonGiaDESC(CategoryName);
        }
        public int RestoreProduct(string PricductID)
        {
            return ProductDAO.Instance.RestoreProduct(PricductID);
        }
        public int RestoreProductAll()
        {
            return ProductDAO.Instance.RestoreProductAll();
        }
        public List<Product> GetListFillProductSelectDish(string CategoryName)
        {
            return ProductDAO.Instance.GetListFillProductSelectDish(CategoryName);
        }
        public List<Product> GetListFindProductSelectDish(string ProductName)
        {
            return ProductDAO.Instance.GetListFindProductSelectDish(ProductName);
        }
        public string ProductID(string ProductName)
        {
            return ProductDAO.Instance.ProductID(ProductName);
        }
        public int ProductCount(string ProductName)
        {
            return ProductDAO.Instance.ProductCount(ProductName);
        }
        public int UpdateProductCount(string ProductID, string count)
        {
            return ProductDAO.Instance.UpdateProductCount(ProductID, count);
        }
        
    }
}
