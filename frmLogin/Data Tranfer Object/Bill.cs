using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmLogin.Data_Tranfer_Object
{
    class Bill
    {
        private string m_MaHD;
        private string m_NgayLapHD;
        private int m_MaNhanVien;
        private string m_MaKhachHang;
        private string m_MaGiamGia;
        private int m_SoBan;
        private int m_TrangThaiThanhToan;
        private int m_TrangThai;

        public Bill(string maHD, string ngayLapHD, int maNhanVien, string maKhachHang, string maGiamGia, int soBan, int trangThaiThanhToan, int trangThai)
        {
            this.m_MaHD = maHD;
            this.m_NgayLapHD = ngayLapHD;
            this.m_MaNhanVien = maNhanVien;
            this.m_MaKhachHang = maKhachHang;
            this.m_MaGiamGia = maGiamGia;
            this.m_SoBan = soBan;
            this.m_TrangThaiThanhToan = trangThaiThanhToan;
            this.m_TrangThai = trangThai;
        }

        public string MaHD { get => m_MaHD; set => m_MaHD = value; }
        public string NgayLapHD { get => m_NgayLapHD; set => m_NgayLapHD = value; }
        public int MaNhanVien { get => m_MaNhanVien; set => m_MaNhanVien = value; }
        public string MaKhachHang { get => m_MaKhachHang; set => m_MaKhachHang = value; }
        public string MaGiamGia { get => m_MaGiamGia; set => m_MaGiamGia = value; }
        public int SoBan { get => m_SoBan; set => m_SoBan = value; }
        public int TrangThaiThanhToan { get => m_TrangThaiThanhToan; set => m_TrangThaiThanhToan = value; }
        public int TrangThai { get => m_TrangThai; set => m_TrangThai = value; }

        public Bill(DataRow row)
        {
            this.m_MaHD = row["MAHD"].ToString();
            this.m_NgayLapHD = row["NGAYLAPHD"].ToString();
            this.m_MaNhanVien = (int)row["MANHANVIEN"];
            this.m_MaKhachHang = row["GIOITINH"].ToString();
            this.m_MaGiamGia = row["NGAYVAOLAM"].ToString();
            this.m_SoBan = (int)row["MACHUCVU"];
            //this.m_TrangThaiThanhToan = (int)row["TRANGTHAITHANHTOAN"];
            //this.trangThai = (int)row["TRANGTHAI"];
        }
    }

}
