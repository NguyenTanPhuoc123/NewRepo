using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class StatisticalProduct
    {
        private string m_ProductID;
        private string m_ProductName;
        private int m_TotalCount;
        private int m_Count;     
        private float m_Price;

        public StatisticalProduct(string productID, string productName, int totalCount, int count, float price)
        {
            m_ProductID = productID;
            m_ProductName = productName;
            m_TotalCount = totalCount;
            m_Count = count;         
            m_Price = price;
        }

        public string ProductID { get => m_ProductID; set => m_ProductID = value; }
        public string ProductName { get => m_ProductName; set => m_ProductName = value; }
        public int TotalCount { get => m_TotalCount; set => m_TotalCount = value; }
        public int Count { get => m_Count; set => m_Count = value; }             
        public float Price { get => m_Price; set => m_Price = value; }

        public StatisticalProduct(DataRow row)
        {
            this.m_ProductID = row["MASANPHAM"].ToString();
            this.m_ProductName = row["TENSANPHAM"].ToString();           
            this.m_Count = (int)row["SOLUONG"];
            this.m_Price = float.Parse(row["DONGIA"].ToString());
            this.m_TotalCount = int.Parse(row["TongSoLuongBan"].ToString());
        }
       
    }
}
