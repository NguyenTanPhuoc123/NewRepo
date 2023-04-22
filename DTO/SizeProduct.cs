using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SizeProduct
    {
        private int m_SizeID;
        private string m_SizeName;
        private float m_Price;

        public SizeProduct(int sizeID, string sizeName, float price)
        {
            m_SizeID = sizeID;
            m_SizeName = sizeName;
            m_Price = price;
        }

        public int SizeID { get => m_SizeID; set => m_SizeID = value; }
        public string SizeName { get => m_SizeName; set => m_SizeName = value; }
        public float Price { get => m_Price; set => m_Price = value; }

        public SizeProduct(DataRow row)
        {
            this.m_SizeID = (int)row["MaKichThuoc"];
            this.m_SizeName = row["TenKichThuoc"].ToString();
            this.m_Price = float.Parse(row["Gia"].ToString());
        }
    }
}
