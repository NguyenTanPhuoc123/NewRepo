using System;
using System.Collections.Generic;
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
        public List<ProductDTO> GetListProduct()
        {
            return ProductDAO.Instance.GetListProduct();
        }
        public  int ExecuteInsertCommand(ProductDTO product)
        {
            return ProductDAO.Instance.ExecuteInsertCommand(product);
        }
        public int DeleteProduct(string Masp)
        {
            return ProductDAO.Instance.DeleteProduct(Masp);
        }
        public  int UpdateProduct(ProductDTO product, byte[] hinhAnh)
        {
            return ProductDAO.Instance.UpdateProduct(product, hinhAnh);
        }
        public List<ProductDTO> GetListFillProduct(string tendanhmuc)
        {
            return ProductDAO.Instance.GetListFillProduct(tendanhmuc);
        }
        public List<ProductDTO> GetListFindProduct(string tensanpham)
        {
            return ProductDAO.Instance.GetListFindProduct(tensanpham);
        }
        public List<ProductDTO> SortProductName(string tendanhmuc)
        {
            return ProductDAO.Instance.SortProductName(tendanhmuc);
        }
        public List<ProductDTO> SortSoLuongASC(string tendanhmuc)
        {
            return ProductDAO.Instance.SortSoLuongASC(tendanhmuc);
        }
        public List<ProductDTO> SortSoLuongDESC(string tendanhmuc)
        {
            return ProductDAO.Instance.SortSoLuongDESC(tendanhmuc);
        }
        public List<ProductDTO> SortDonGiaASC(string tendanhmuc)
        {
            return ProductDAO.Instance.SortDonGiaASC(tendanhmuc);
        }
        public List<ProductDTO> SortDonGiaDESC(string tendanhmuc)
        {
            return ProductDAO.Instance.SortDonGiaDESC(tendanhmuc);
        }
    }
}
