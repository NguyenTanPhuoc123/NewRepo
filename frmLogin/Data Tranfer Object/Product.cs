using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace frmLogin.Data_Tranfer_Object
{
    class Product
    {
        private byte[] m_image;
        private Image m_HinhAnh;
        private string m_MaSanPham;
        private string m_TenSanPham;
        private int m_DanhMuc;
        private int m_SoLuong;
        private float m_DonGia;
        private int m_TrangThai;
        private string m_MoTa;

        public Product(string maSanPham, string tenSanPham, int danhMuc, int soLuong, float donGia, int trangThai,byte[] hinhAnh,string moTa)
        {
            this.image = hinhAnh;
            this.MaSanPham = maSanPham;
            this.TenSanPham = tenSanPham;
            this.DanhMuc = danhMuc;
            this.SoLuong = soLuong;
            this.DonGia = donGia;
            this.TrangThai = trangThai;
            this.MoTa = moTa;
        }

        public string MaSanPham { get => m_MaSanPham; set => m_MaSanPham = value; }
        public string TenSanPham { get => m_TenSanPham; set => m_TenSanPham = value; }
        public int DanhMuc { get => m_DanhMuc; set => m_DanhMuc = value; }
        public int SoLuong { get => m_SoLuong; set => m_SoLuong = value; }
        public float DonGia { get => m_DonGia; set => m_DonGia = value; }
        public int TrangThai { get => m_TrangThai; set => m_TrangThai = value; }
        public byte[] image { get => m_image; set => m_image = value; }
        public string MoTa { get => m_MoTa; set => m_MoTa = value; }
        public Image HinhAnh { get => m_HinhAnh; set => m_HinhAnh = value; }

        public Product(DataRow row)
        {
            this.m_MaSanPham = row["MASANPHAM"].ToString();
            this.m_TenSanPham = row["TENSANPHAM"].ToString();
            this.m_DanhMuc = (int)row["DANHMUC"];
            this.m_SoLuong = (int)row["SOLUONG"];
            this.m_DonGia =float.Parse(row["DONGIA"].ToString());
            this.m_MoTa = row["MOTA"].ToString();
            
            this.HinhAnh =ConvertByteToImage((byte[])row["HINHANH"]);
        }
        public Image ConvertByteToImage(byte[] byteArray)
        {
            using (var memoryStream = new MemoryStream(byteArray))
            {
                var image = Image.FromStream(memoryStream);
                return image;
            }
        }
    }
}
