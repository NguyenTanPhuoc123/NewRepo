using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace frmLogin.Data_Tranfer_Object
{
    class Product
    {
        private string m_MaSanPham;
        private string m_TenSanPham;
        private int m_DanhMuc;
        private int m_SoLuong;
        private float m_DonGia;
        private int m_TrangThai;

        public Product(string maSanPham, string tenSanPham, int danhMuc, int soLuong, float donGia, int trangThai)
        {
            this.MaSanPham = maSanPham;
            this.TenSanPham = tenSanPham;
            this.DanhMuc = danhMuc;
            this.SoLuong = soLuong;
            this.DonGia = donGia;
            this.TrangThai = trangThai;
        }

        public string MaSanPham { get => m_MaSanPham; set => m_MaSanPham = value; }
        public string TenSanPham { get => m_TenSanPham; set => m_TenSanPham = value; }
        public int DanhMuc { get => m_DanhMuc; set => m_DanhMuc = value; }
        public int SoLuong { get => m_SoLuong; set => m_SoLuong = value; }
        public float DonGia { get => m_DonGia; set => m_DonGia = value; }
        public int TrangThai { get => m_TrangThai; set => m_TrangThai = value; }
    
        public Product(DataRow row)
        {
            this.m_MaSanPham = row["MASANPHAM"].ToString();
            this.m_TenSanPham = row["TENSANPHAM"].ToString();
            this.m_DanhMuc = (int)row["DANHMUC"];
            this.m_SoLuong = (int)row["SOLUONG"];
            this.m_DonGia = (float)row["DONGIA"];
        }
    }
}
