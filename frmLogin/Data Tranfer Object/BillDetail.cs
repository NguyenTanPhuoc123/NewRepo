using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmLogin.Data_Tranfer_Object
{
    class BillDetail
    {
        private string m_MaHD;
        private string m_MaSP;
        private int m_KichThuoc;
        private int m_SoLuong;
        private float m_ThanhTien;
        private int m_TrangThai;

        public BillDetail(string maHD, string maSP, int kichThuoc, int soLuong, float thanhTien, int trangThai)
        {
            this.MaHD = maHD;
            this.MaSP = maSP;
            this.KichThuoc = kichThuoc;
            this.SoLuong = soLuong;
            this.ThanhTien = thanhTien;
            this.TrangThai = trangThai;
        }

        public string MaHD { get => m_MaHD; set => m_MaHD = value; }
        public string MaSP { get => m_MaSP; set => m_MaSP = value; }
        public int KichThuoc { get => m_KichThuoc; set => m_KichThuoc = value; }
        public int SoLuong { get => m_SoLuong; set => m_SoLuong = value; }
        public float ThanhTien { get => m_ThanhTien; set => m_ThanhTien = value; }
        public int TrangThai { get => m_TrangThai; set => m_TrangThai = value; }

        public BillDetail(DataRow row)
        {
            this.m_MaHD = row["MAHD"].ToString();
            this.m_MaSP = row["MASP"].ToString();
            this.m_KichThuoc = (int)row["KICHTHUOC"];
            this.m_SoLuong = (int)row["SOLUONG"];
            this.m_ThanhTien = (float)row["THANHTIEN"];
            //this.m_TrangThai = (int)row["TRANGTHAI"];
        }
    }
}
