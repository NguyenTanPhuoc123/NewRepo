using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace frmLogin.Data_Tranfer_Object
{
    class Discount
    {
        private string m_MaGiamGia;
        private string m_TenGiamGia;
        private int m_DonGia;
        private DateTime? m_NgayBatDau;
        private DateTime? m_NgayKetThuc;
       

        public string MaGiamGia { get => m_MaGiamGia; set => m_MaGiamGia = value; }
        public string TenGiamGia { get => m_TenGiamGia; set => m_TenGiamGia = value; }
        public int DonGia { get => m_DonGia; set => m_DonGia = value; }
        public DateTime? NgayBatDau { get => m_NgayBatDau; set => m_NgayBatDau = value; }
        public DateTime? NgayKetThuc { get => m_NgayKetThuc; set => m_NgayKetThuc = value; }

        public Discount(DataRow row)
        {
            this.m_MaGiamGia = row["MAGIAMGIA"].ToString();
            this.m_TenGiamGia = row["TEMGIAMGIA"].ToString();
            this.m_DonGia = (int)row["DONGIA"];
            this.m_NgayBatDau = (DateTime?)row["NgayBatDau"];
            this.m_NgayKetThuc = (DateTime?)row["NgayKetThuc"];
        }

        public Discount(string maGiamGia, string tenGiamGia, int donGia, DateTime? ngayBatDau, DateTime? ngayKetThuc)
        {
            m_MaGiamGia = maGiamGia;
            m_TenGiamGia = tenGiamGia;
            m_DonGia = donGia;
            m_NgayBatDau = ngayBatDau;
            m_NgayKetThuc = ngayKetThuc;
        }
    }
}
