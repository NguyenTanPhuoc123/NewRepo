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
        public int ExecuteInsertCommand(ProductDTO product)
        {
            return ProductDAO.Instance.ExecuteInsertCommand(product);
        }
        public int DeleteProduct(string Masp)
        {
            return ProductDAO.Instance.DeleteProduct(Masp);
        }
        public int UpdateProduct(ProductDTO product)
        {
            return ProductDAO.Instance.UpdateProduct(product);
        }
        public DataTable GetListFillProduct(string tendanhmuc)
        {
            return ProductDAO.Instance.GetListFillProduct(tendanhmuc);
        }
        public DataTable GetListFindProduct(string tensanpham)
        {
            return ProductDAO.Instance.GetListFindProduct(tensanpham);
        }
        public DataTable SortProductName(string tendanhmuc)
        {
            return ProductDAO.Instance.SortProductName(tendanhmuc);
        }
        public DataTable SortSoLuongASC(string tendanhmuc)
        {
            return ProductDAO.Instance.SortSoLuongASC(tendanhmuc);
        }
        public DataTable SortSoLuongDESC(string tendanhmuc)
        {
            return ProductDAO.Instance.SortSoLuongDESC(tendanhmuc);
        }
        public DataTable SortDonGiaASC(string tendanhmuc)
        {
            return ProductDAO.Instance.SortDonGiaASC(tendanhmuc);
        }
        public DataTable SortDonGiaDESC(string tendanhmuc)
        {
            return ProductDAO.Instance.SortDonGiaDESC(tendanhmuc);
        }
    }
}
