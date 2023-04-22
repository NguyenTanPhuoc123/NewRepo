using frmLogin.Data_Tranfer_Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmLogin.Data_Access_Layer
{
    class ProductDAF
    {
        private static ProductDAF instance;

        public static ProductDAF Instance
        {
            get { if (instance == null) instance = new ProductDAF(); return ProductDAF.instance; }
            private set { ProductDAF.instance = value; }
        }

        private ProductDAF()
        {

        }
        public List<Product> GetListProduct()
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
        public static int ExecuteInsertCommand(Product product)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO SANPHAM(MASANPHAM,TENSANPHAM,DANHMUC,SOLUONG,DONGIA,MOTA,TRANGTHAI,HinhANh) VALUES(@MASP,@TENSP,@DANHMUC,@SOLUONG,@DONGIA,@MOTA,@TRANGTHAI,@HINHANH)");
            int rows = 0;
            cmd.Connection = DataProvider.OpenConnection();
            SqlParameter[] parameter = new SqlParameter[8];
            parameter[0] = new SqlParameter("@MASP", product.MaSanPham);
            parameter[1] = new SqlParameter("@TENSP", product.TenSanPham);
            parameter[2] = new SqlParameter("@DANHMUC", product.DanhMuc);
            parameter[3] = new SqlParameter("@SOLUONG", product.SoLuong);
            parameter[4] = new SqlParameter("@DONGIA", product.DonGia);
            parameter[5] = new SqlParameter("@TRANGTHAI", product.TrangThai);
            parameter[6] = new SqlParameter("@MOTA", product.MoTa);
            parameter[7] = new SqlParameter("@HINHANH", product.image);
            cmd.Parameters.AddRange(parameter);
            rows = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return rows;
        }
        public int DeleteProduct(string query,SqlParameter[] parameters)
        {
            int row = 0;
            row = DataProvider.ExecuteInsertCommand(query, parameters);
            return row;
        }
        public static int UpdateProduct(Product product, byte[] hinhAnh)
        {
            int data = 0;
            if (hinhAnh == null)
            {
                string query = "Update SANPHAM SET TENSANPHAM = @TENSP,DANHMUC=@DANHMUC,SOLUONG=@SOLUONG,DONGIA=@DONGIA,MOTA=@MOTA where MASANPHAM = @MASP";
                SqlParameter[] parameter = new SqlParameter[7];
                parameter[0] = new SqlParameter("@MASP", product.MaSanPham);
                parameter[1] = new SqlParameter("@TENSP", product.TenSanPham);
                parameter[2] = new SqlParameter("@DANHMUC", product.DanhMuc);
                parameter[3] = new SqlParameter("@SOLUONG", product.SoLuong);
                parameter[4] = new SqlParameter("@DONGIA", product.DonGia);
                parameter[5] = new SqlParameter("@TRANGTHAI", product.TrangThai);
                parameter[6] = new SqlParameter("@MOTA", product.MoTa);
                data = DataProvider.ExecuteInsertCommand(query, parameter);
            }
            else
            {
                string query = "Update SANPHAM SET TENSANPHAM = @TENSP,DANHMUC=@DANHMUC,SOLUONG=@SOLUONG,DONGIA=@DONGIA,MOTA=@MOTA,HINHANH=@HINHANH where MASANPHAM = @MASP";
                SqlParameter[] parameter = new SqlParameter[8];
                parameter[0] = new SqlParameter("@MASP", product.MaSanPham);
                parameter[1] = new SqlParameter("@TENSP", product.TenSanPham);
                parameter[2] = new SqlParameter("@DANHMUC", product.DanhMuc);
                parameter[3] = new SqlParameter("@SOLUONG", product.SoLuong);
                parameter[4] = new SqlParameter("@DONGIA", product.DonGia);
                parameter[5] = new SqlParameter("@TRANGTHAI", product.TrangThai);
                parameter[6] = new SqlParameter("@MOTA", product.MoTa);
                parameter[7] = new SqlParameter("@HINHANH", hinhAnh);
                data = DataProvider.ExecuteInsertCommand(query, parameter);
            }
            return data;
        }
    }
}
