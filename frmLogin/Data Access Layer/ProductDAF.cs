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
            string query = "select *  from sanpham";
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);
            foreach (DataRow item in data.Rows)
            {
                Product acc = new Product(item);
                lst.Add(acc);
            }
            return lst;
        }
        public static int ExecuteInsertCommand(string sql,Product product)
        {
            SqlCommand cmd = new SqlCommand(sql);
            int rows = 0;
            cmd.Connection = DataProvider.OpenConnection();
            SqlParameter[] parameter = new SqlParameter[8];
            parameter[0] = new SqlParameter("@MASP", product.MaSanPham);
            parameter[0] = new SqlParameter("@TENSP", product.TenSanPham);
            parameter[0] = new SqlParameter("@DANHMUC", product.DanhMuc);
            parameter[0] = new SqlParameter("@SOLUONG", product.SoLuong);
            parameter[0] = new SqlParameter("@DONGIA", product.DonGia);
            parameter[0] = new SqlParameter("@TRANGTHAI", product.TrangThai);
            parameter[0] = new SqlParameter("@MOTA", product.MoTa);
            parameter[0] = new SqlParameter("@HINHANH", product.image);
            cmd.Parameters.AddRange(parameter);
            rows = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return rows;
        }
    }
}
