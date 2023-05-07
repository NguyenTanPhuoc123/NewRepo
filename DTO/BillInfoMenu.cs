using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class BillInfoMenu
    {
        private string m_BillID;
        private string m_ProductID;
        private string m_ProductName;
        private int m_Count;
        private float m_Price;
        private float m_Total;

        public BillInfoMenu(string billID, string productID, string productName, int count, float price, float total)
        {
            m_BillID = billID;
            m_ProductID = productID;
            m_ProductName = productName;
            m_Count = count;
            m_Price = price;
            m_Total = total;
        }

        public string BillID { get => m_BillID; set => m_BillID = value; }
        public string ProductID { get => m_ProductID; set => m_ProductID = value; }
        public string ProductName { get => m_ProductName; set => m_ProductName = value; }
        public int Count { get => m_Count; set => m_Count = value; }
        public float Price { get => m_Price; set => m_Price = value; }
        public float Total { get => m_Total; set => m_Total = value; }

        public BillInfoMenu(DataRow row)
        {
            this.m_BillID = row["MAHD"].ToString();
            this.m_ProductID = row["MASP"].ToString();
            this.m_ProductName = row["TENSANPHAM"].ToString();
            this.m_Count = (int)row["SOLUONG"];
            this.m_Price = float.Parse(row["DONGIA"].ToString());
            this.m_Total = float.Parse(row["THANHTIEN"].ToString());
        }


    }
}
