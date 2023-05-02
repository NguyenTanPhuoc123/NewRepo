using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BillInfo
    {
        private string m_BillID;
        private string m_ProductID;
        private int m_Count;
        private float m_Price;
        private float m_Total;

        public BillInfo(string billID, string productID, int count, float price, float total)
        {
            m_BillID = billID;
            m_ProductID = productID;
            m_Count = count;
            m_Price = price;
            m_Total = total;
        }

        public string BillID { get => m_BillID; set => m_BillID = value; }
        public string ProductID { get => m_ProductID; set => m_ProductID = value; }
        public int Count { get => m_Count; set => m_Count = value; }
        public float Total { get => m_Total; set => m_Total = value; }
        public float Price { get => m_Price; set => m_Price = value; }

        public BillInfo(DataRow row)
        {
            this.m_BillID = row["MAHD"].ToString();
            this.m_ProductID = row["MASP"].ToString();
            this.m_Count = (int)row["SOLUONG"];
            this.m_Price = float.Parse(row["DONGIA"].ToString());
            this.m_Total = float.Parse(row["THANHTIEN"].ToString());
        }


    }
}
