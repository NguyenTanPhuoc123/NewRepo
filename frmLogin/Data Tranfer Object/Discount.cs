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

        public Discount(string maGiamGia, string tenGiamGia, int donGia)
        {
            this.MaGiamGia = maGiamGia;
            this.TenGiamGia = tenGiamGia;
            this.DonGia = donGia;
        }

        public string MaGiamGia { get => m_MaGiamGia; set => m_MaGiamGia = value; }
        public string TenGiamGia { get => m_TenGiamGia; set => m_TenGiamGia = value; }
        public int DonGia { get => m_DonGia; set => m_DonGia = value; }

        public Discount(DataRow row)
        {
            this.m_MaGiamGia = row["MAGIAMGIA"].ToString();
            this.m_TenGiamGia = row["TEMGIAMGIA"].ToString();
            this.m_DonGia = (int)row["DONGIA"];
        }
    }
}
