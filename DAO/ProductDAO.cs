using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class ProductDAO
    {
        private static ProductDAO instance;

        public static ProductDAO Instance
        {
            get { if (instance == null) instance = new ProductDAO(); return ProductDAO.instance; }
            private set { ProductDAO.instance = value; }
        }

        public DataTable GetListProduct()
        {
            DataTable da = new DataTable();
            string query = "Select * from SanPham where TRANGTHAI=1";
            da = DataProvider.ExcecuteSelectCommand(query, null);
            return da;
        }
        public DataTable GetListProductDeleted()
        {
            DataTable da = new DataTable();
            string query = "Select * from SanPham where TRANGTHAI=0";
            da = DataProvider.ExcecuteSelectCommand(query, null);
            return da;
        }
        public List<Product> GetProduct()
        {
            List<Product> lst = new List<Product>();
            string query = "select a.* ,b.tendanhmuc from sanpham a,Danhmuc b where a.danhmuc=b.madanhmuc and TRANGTHAI = 1";
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);
            foreach (DataRow item in data.Rows)
            {
                Product acc = new Product(item);
                lst.Add(acc);
            }
            return lst;
        }
        public int ExecuteInsertCommand(Product product)
        {
            string query = "INSERT INTO SANPHAM(MASANPHAM,TENSANPHAM,DANHMUC,SOLUONG,DONGIA,MOTA,TRANGTHAI,HinhANh) VALUES(@MASP,@TENSP,@DANHMUC,@SOLUONG,@DONGIA,@MOTA,@TRANGTHAI,@HINHANH)";
            int rows = 0;
            SqlParameter[] parameter = new SqlParameter[8];
            parameter[0] = new SqlParameter("@MASP", product.MaSanPham);
            parameter[1] = new SqlParameter("@TENSP", product.TenSanPham);
            parameter[2] = new SqlParameter("@DANHMUC", product.DanhMuc);
            parameter[3] = new SqlParameter("@SOLUONG", product.SoLuong);
            parameter[4] = new SqlParameter("@DONGIA", product.DonGia);
            parameter[5] = new SqlParameter("@TRANGTHAI", product.TrangThai);
            parameter[6] = new SqlParameter("@MOTA", product.MoTa);
            parameter[7] = new SqlParameter("@HINHANH", product.image);
            rows = DataProvider.ExecuteInsertCommand(query, parameter);
            return rows;
        }
        public int DeleteProduct(string Masp)
        {
            string query = "UPDATE SANPHAM SET TRANGTHAI=0 WHERE MASANPHAM=@SANPHAM";
            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@SANPHAM", Masp);
            int row = 0;
            row = DataProvider.ExecuteInsertCommand(query, parameter);
            return row;
        }
        public int RestoreProduct(string Masp)
        {
            string query = "UPDATE SANPHAM SET TRANGTHAI=1 WHERE MASANPHAM=@SANPHAM";
            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@SANPHAM", Masp);
            int row = 0;
            row = DataProvider.ExecuteInsertCommand(query, parameter);
            return row;
        }
        public int RestoreProductAll()
        {
            string query = "UPDATE SANPHAM SET TRANGTHAI=1";
            int row = 0;
            row = DataProvider.ExecuteInsertCommand(query, null);
            return row;
        }
        public int UpdateProduct(Product product)
        {
            int data = 0;
            string query = "Update SANPHAM SET TENSANPHAM = @TENSP,DANHMUC=@DANHMUC,SOLUONG=@SOLUONG,DONGIA=@DONGIA,MOTA=@MOTA,HINHANH=@HINHANH where MASANPHAM = @MASP";
            SqlParameter[] parameter = new SqlParameter[8];
            parameter[0] = new SqlParameter("@MASP", product.MaSanPham);
            parameter[1] = new SqlParameter("@TENSP", product.TenSanPham);
            parameter[2] = new SqlParameter("@DANHMUC", product.DanhMuc);
            parameter[3] = new SqlParameter("@SOLUONG", product.SoLuong);
            parameter[4] = new SqlParameter("@DONGIA", product.DonGia);
            parameter[5] = new SqlParameter("@TRANGTHAI", product.TrangThai);
            parameter[6] = new SqlParameter("@MOTA", product.MoTa);
            parameter[7] = new SqlParameter("@HINHANH", product.image);
            data = DataProvider.ExecuteInsertCommand(query, parameter);
            return data;
        }
        public DataTable GetListFillProduct(string tendanhmuc)
        {
            DataTable lst = new DataTable();
            string query = "select a.* ,b.tendanhmuc from sanpham a,Danhmuc b where a.danhmuc=b.madanhmuc and TRANGTHAI = 1 and b.tendanhmuc=@tendanhmuc";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@tendanhmuc", tendanhmuc);
            lst = DataProvider.ExcecuteSelectCommand(query, parameters);
            return lst;
        }
        public DataTable GetListFindProduct(string tensanpham)
        {
            DataTable lst = new DataTable();
            string query = string.Format("select a.* ,b.tendanhmuc from sanpham a,Danhmuc b where a.danhmuc=b.madanhmuc and TRANGTHAI = 1 AND a.tensanpham LIKE N'%{0}%'", tensanpham);
            lst = DataProvider.ExcecuteSelectCommand(query, null);
            return lst;
        }
        public DataTable SortProductName(string tendanhmuc)
        {
            DataTable lst = new DataTable();
            string query;
            if (tendanhmuc == "Tat ca")
            {
                query = "select a.* ,b.tendanhmuc from sanpham a,Danhmuc b where a.danhmuc=b.madanhmuc and TRANGTHAI = 1 ORDER BY TENSANPHAM ASC";

            }
            else
                query = "select a.* ,b.tendanhmuc from sanpham a,Danhmuc b where a.danhmuc=b.madanhmuc and TRANGTHAI = 1 and b.tendanhmuc=@tendanhmuc ORDER BY TENSANPHAM ASC";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@tendanhmuc", tendanhmuc);
            lst = DataProvider.ExcecuteSelectCommand(query, parameters);
            return lst;
        }
        public DataTable SortSoLuongASC(string tendanhmuc)
        {
            DataTable lst = new DataTable();
            string query;
            if (tendanhmuc == "Tat ca")
            {
                query = "select a.* ,b.tendanhmuc from sanpham a,Danhmuc b where a.danhmuc=b.madanhmuc and TRANGTHAI = 1 ORDER BY SOLUONG ASC";

            }
            else
                query = "select a.* ,b.tendanhmuc from sanpham a,Danhmuc b where a.danhmuc=b.madanhmuc and TRANGTHAI = 1 and b.tendanhmuc=@tendanhmuc ORDER BY SOLUONG ASC";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@tendanhmuc", tendanhmuc);
            lst = DataProvider.ExcecuteSelectCommand(query, parameters);
            return lst;
        }
        public DataTable SortSoLuongDESC(string tendanhmuc)
        {
            DataTable lst = new DataTable();
            string query;
            if (tendanhmuc == "Tat ca")
            {
                query = "select a.* ,b.tendanhmuc from sanpham a,Danhmuc b where a.danhmuc=b.madanhmuc and TRANGTHAI = 1 ORDER BY SOLUONG DESC";

            }
            else
                query = "select a.* ,b.tendanhmuc from sanpham a,Danhmuc b where a.danhmuc=b.madanhmuc and TRANGTHAI = 1 and b.tendanhmuc=@tendanhmuc ORDER BY SOLUONG DESC";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@tendanhmuc", tendanhmuc);
            lst = DataProvider.ExcecuteSelectCommand(query, parameters);
            return lst;
        }
        public DataTable SortDonGiaASC(string tendanhmuc)
        {
            DataTable lst = new DataTable();
            string query;
            if (tendanhmuc == "Tat ca")
            {
                query = "select a.* ,b.tendanhmuc from sanpham a,Danhmuc b where a.danhmuc=b.madanhmuc and TRANGTHAI = 1 ORDER BY DONGIA ASC";

            }
            else
                query = "select a.* ,b.tendanhmuc from sanpham a,Danhmuc b where a.danhmuc=b.madanhmuc and TRANGTHAI = 1 and b.tendanhmuc=@tendanhmuc ORDER BY DONGIA ASC";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@tendanhmuc", tendanhmuc);
            lst = DataProvider.ExcecuteSelectCommand(query, parameters);
            return lst;
        }
        public DataTable SortDonGiaDESC(string tendanhmuc)
        {
            DataTable lst = new DataTable();
            string query;
            if (tendanhmuc == "Tat ca")
            {
                query = "select a.* ,b.tendanhmuc from sanpham a,Danhmuc b where a.danhmuc=b.madanhmuc and TRANGTHAI = 1 ORDER BY DONGIA DESC";

            }
            else
                query = "select a.* ,b.tendanhmuc from sanpham a,Danhmuc b where a.danhmuc=b.madanhmuc and TRANGTHAI = 1 and b.tendanhmuc=@tendanhmuc ORDER BY DONGIA DESC";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@tendanhmuc", tendanhmuc);
            lst = DataProvider.ExcecuteSelectCommand(query, parameters);
            return lst;
        }
    }
}

