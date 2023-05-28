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
            string query = "select a.* ,b.tendanhmuc from sanpham a,Danhmuc b where a.danhmuc=b.madanhmuc and TRANGTHAI = 1";
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
        public DataTable GetProductDeleted()
        {
            DataTable da = new DataTable();
            string query = "select a.* ,b.tendanhmuc from sanpham a,Danhmuc b where a.danhmuc=b.madanhmuc and TRANGTHAI = 0";
            da = DataProvider.ExcecuteSelectCommand(query, null);
            return da;
        }
        public string GetProductID()
        {
            string query = "SELECT COUNT(*) FROM SANPHAM";
            int data = DataProvider.ExecuteScalarCommand(query, null);
            data += 1;
            string billID = string.Format("SP" + data);
            return billID;
        }
        public bool CheckNameProduct(string productName)
        {
            string query = string.Format("Select Count(*) From SanPham Where TENSANPHAM=N'{0}'", productName);
            int count = DataProvider.ExecuteScalarCommand(query, null);
            return (count > 0 ? false : true);
        }
        public bool CheckNameProduct(string productName,string ProductID)
        {
            string query = string.Format("Select Count(*) From SanPham Where TENSANPHAM=N'{0}' and MASANPHAM !='{1}'", productName,ProductID);
            int count = DataProvider.ExecuteScalarCommand(query, null);
            return (count > 0 ? false : true);
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
        public int DeleteProduct(string ProductID)
        {
            string query = "UPDATE SANPHAM SET TRANGTHAI=0 WHERE MASANPHAM=@SANPHAM";
            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@SANPHAM", ProductID);
            int row = 0;
            row = DataProvider.ExecuteInsertCommand(query, parameter);
            return row;
        }
        public int DeleteProductAll()
        {
            string query = "UPDATE SANPHAM SET TRANGTHAI=0";
            int row = 0;
            row = DataProvider.ExecuteInsertCommand(query, null);
            return row;
        }
        public int RestoreProduct(string ProductID)
        {
            string query = "UPDATE SANPHAM SET TRANGTHAI=1 WHERE MASANPHAM=@SANPHAM";
            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@SANPHAM", ProductID);
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
            string query = string.Format("select a.* ,b.tendanhmuc from sanpham a,Danhmuc b where a.danhmuc=b.madanhmuc and TRANGTHAI = 1 AND dbo.fChuyenCoDauThanhKhongDau(a.TENSANPHAM) like dbo.fChuyenCoDauThanhKhongDau(N'%{0}%')", tensanpham);
            lst = DataProvider.ExcecuteSelectCommand(query, null);
            return lst;
        }
        public DataTable SortProductName(string CategoryName)
        {
            DataTable lst = new DataTable();
            string query;
            if (CategoryName == "Tất cả")
            {
                query = "select a.* ,b.tendanhmuc from sanpham a,Danhmuc b where a.danhmuc=b.madanhmuc and TRANGTHAI = 1 ORDER BY TENSANPHAM ASC";

            }
            else
                query = "select a.* ,b.tendanhmuc from sanpham a,Danhmuc b where a.danhmuc=b.madanhmuc and TRANGTHAI = 1 and b.tendanhmuc=@tendanhmuc ORDER BY TENSANPHAM ASC";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@tendanhmuc", CategoryName);
            lst = DataProvider.ExcecuteSelectCommand(query, parameters);
            return lst;
        }
        public DataTable SortSoLuongASC(string CategoryName)
        {
            DataTable lst = new DataTable();
            string query;
            if (CategoryName == "Tất cả")
            {
                query = "select a.* ,b.tendanhmuc from sanpham a,Danhmuc b where a.danhmuc=b.madanhmuc and TRANGTHAI = 1 ORDER BY SOLUONG ASC";

            }
            else
                query = "select a.* ,b.tendanhmuc from sanpham a,Danhmuc b where a.danhmuc=b.madanhmuc and TRANGTHAI = 1 and b.tendanhmuc=@tendanhmuc ORDER BY SOLUONG ASC";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@tendanhmuc", CategoryName);
            lst = DataProvider.ExcecuteSelectCommand(query, parameters);
            return lst;
        }
        public DataTable SortSoLuongDESC(string CategoryName)
        {
            DataTable lst = new DataTable();
            string query;
            if (CategoryName == "Tất cả")
            {
                query = "select a.* ,b.tendanhmuc from sanpham a,Danhmuc b where a.danhmuc=b.madanhmuc and TRANGTHAI = 1 ORDER BY SOLUONG DESC";

            }
            else
                query = "select a.* ,b.tendanhmuc from sanpham a,Danhmuc b where a.danhmuc=b.madanhmuc and TRANGTHAI = 1 and b.tendanhmuc=@tendanhmuc ORDER BY SOLUONG DESC";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@tendanhmuc", CategoryName);
            lst = DataProvider.ExcecuteSelectCommand(query, parameters);
            return lst;
        }
        public DataTable SortDonGiaASC(string CategoryName)
        {
            DataTable lst = new DataTable();
            string query;
            if (CategoryName == "Tất cả")
            {
                query = "select a.* ,b.tendanhmuc from sanpham a,Danhmuc b where a.danhmuc=b.madanhmuc and TRANGTHAI = 1 ORDER BY DONGIA ASC";

            }
            else
                query = "select a.* ,b.tendanhmuc from sanpham a,Danhmuc b where a.danhmuc=b.madanhmuc and TRANGTHAI = 1 and b.tendanhmuc=@tendanhmuc ORDER BY DONGIA ASC";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@tendanhmuc", CategoryName);
            lst = DataProvider.ExcecuteSelectCommand(query, parameters);
            return lst;
        }
        public DataTable SortDonGiaDESC(string CategoryName)
        {
            DataTable lst = new DataTable();
            string query;
            if (CategoryName == "Tất cả")
            {
                query = "select a.* ,b.tendanhmuc from sanpham a,Danhmuc b where a.danhmuc=b.madanhmuc and TRANGTHAI = 1 ORDER BY DONGIA DESC";

            }
            else
                query = "select a.* ,b.tendanhmuc from sanpham a,Danhmuc b where a.danhmuc=b.madanhmuc and TRANGTHAI = 1 and b.tendanhmuc=@tendanhmuc ORDER BY DONGIA DESC";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@tendanhmuc", CategoryName);
            lst = DataProvider.ExcecuteSelectCommand(query, parameters);
            return lst;
        }
        public List<Product> GetListFillProductSelectDish(string CategoryName)
        {
            List<Product> lst = new List<Product>();
            string query = "select a.* ,b.tendanhmuc from sanpham a,Danhmuc b where a.danhmuc=b.madanhmuc and TRANGTHAI = 1 and b.tendanhmuc=@tendanhmuc";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@tendanhmuc", CategoryName);
            DataTable data = DataProvider.ExcecuteSelectCommand(query, parameters);
            foreach (DataRow item in data.Rows)
            {
                Product acc = new Product(item);
                lst.Add(acc);
            }
            return lst;
        }
        public List<Product> GetListFindProductSelectDish(string ProductName)
        {
            List<Product> lst = new List<Product>();
            string query = string.Format("select a.* ,b.tendanhmuc from sanpham a,Danhmuc b where a.danhmuc=b.madanhmuc and TRANGTHAI = 1 AND dbo.fChuyenCoDauThanhKhongDau(a.TENSANPHAM) like dbo.fChuyenCoDauThanhKhongDau(N'%{0}%')", ProductName);
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);
            foreach (DataRow item in data.Rows)
            {
                Product acc = new Product(item);
                lst.Add(acc);
            }
            return lst;
        }

        public string ProductID(string ProductName)
        {
            string ID;
            string query = string.Format("SELECT MASANPHAM FROM SANPHAM WHERE TENSANPHAM = N'{0}'", ProductName);
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);
            foreach (DataRow row in data.Rows)
            {
                ID = row["MASANPHAM"].ToString();
                return ID;
            }
            return null;
        }

        public int ProductCount(string ProductName)
        {
            int ID;
            string query = string.Format("SELECT * FROM SANPHAM WHERE TENSANPHAM = N'{0}'", ProductName);
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);
            foreach (DataRow row in data.Rows)
            {
                ID = Convert.ToInt32(row["SOLUONG"].ToString());
                return ID;
            }
            return 0;
        }

        public int UpdateProductCount(string ProductID, string count)
        {
            int data = 0;
            string query = "Update SANPHAM SET SOLUONG = SOLUONG - @SOLUONG where MASANPHAM = @MASP";
            SqlParameter[] parameter = new SqlParameter[2];
            parameter[0] = new SqlParameter("MASP", ProductID);
            parameter[1] = new SqlParameter("@SOLUONG", count);
            data = DataProvider.ExecuteInsertCommand(query, parameter);
            return data;
        }

       
    }
}

