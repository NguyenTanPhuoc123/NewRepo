using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class Bill
    {
        private string m_ID;
        private string m_DayCheckIn;
        private string m_DayCheckOut;
        private int m_EmployeeID;
        private string m_CustomerID;
        private string m_DiscountID;
        private int m_TableID;
        private bool m_StatusCheckOut;

        public Bill(string iD, string dayCheckIn, string dayCheckOut, int employeeID, string customerID, string discountID, int tableID, bool statusCheckOut)
        {
            m_ID = iD;
            m_DayCheckIn = dayCheckIn;
            m_DayCheckOut = dayCheckOut;
            m_EmployeeID = employeeID;
            m_CustomerID = customerID;
            m_DiscountID = discountID;
            m_TableID = tableID;
            m_StatusCheckOut = statusCheckOut;
        }

        public string ID { get => m_ID; set => m_ID = value; }
        public string DayCheckIn { get => m_DayCheckIn; set => m_DayCheckIn = value; }
        public string DayCheckOut { get => m_DayCheckOut; set => m_DayCheckOut = value; }
        public int EmployeeID { get => m_EmployeeID; set => m_EmployeeID = value; }
        public string CustomerID { get => m_CustomerID; set => m_CustomerID = value; }
        public string DiscountID { get => m_DiscountID; set => m_DiscountID = value; }
        public int TableID { get => m_TableID; set => m_TableID = value; }
        public bool StatusCheckOut { get => m_StatusCheckOut; set => m_StatusCheckOut = value; }

        public Bill(DataRow row)
        {
            this.m_ID = row["MAHD"].ToString();
            this.m_DayCheckIn = row["NGAYLAPHD"].ToString();
            this.m_DayCheckOut = row["NGAYXUATHD"].ToString();
            this.m_EmployeeID = (int)row["MANHANVIEN"];
            this.m_CustomerID = row["MAKHACHHANG"].ToString();
            this.m_DiscountID = row["MAGIAMGIA"].ToString();
            this.m_TableID = (int)row["SOBAN"];
            this.m_StatusCheckOut = (bool)row["TRANGTHAITHANHTOAN"];
        }

        
    }
}
