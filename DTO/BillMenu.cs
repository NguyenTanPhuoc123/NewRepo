using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class BillMenu
    {
        private string m_ID;
        private string m_DayCheckIn;
        private string m_DayCheckOut;
        private int m_EmployeeID;
        private string m_EmployeeName;
        private string m_DiscountID;
        private string m_DiscountName;
        private int m_TableID;
        private string m_TableName;
        private float m_Total;
        private bool m_StatusCheckOut;


        public string ID { get => m_ID; set => m_ID = value; }
        public string DayCheckIn { get => m_DayCheckIn; set => m_DayCheckIn = value; }
        public string DayCheckOut { get => m_DayCheckOut; set => m_DayCheckOut = value; }
        public int EmployeeID { get => m_EmployeeID; set => m_EmployeeID = value; }
        public string EmployeeName { get => m_EmployeeName; set => m_EmployeeName = value; }
        public string DiscountID { get => m_DiscountID; set => m_DiscountID = value; }
        public string DiscountName { get => m_DiscountName; set => m_DiscountName = value; }
        public int TableID { get => m_TableID; set => m_TableID = value; }
        public string TableName { get => m_TableName; set => m_TableName = value; }
        public bool StatusCheckOut { get => m_StatusCheckOut; set => m_StatusCheckOut = value; }
        public float Total { get => m_Total; set => m_Total = value; }

        public BillMenu(string iD, string dayCheckIn, string dayCheckOut, int employeeID, string employeeName, string discountID, string discountName, int tableID, string tableName, float total, bool statusCheckOut)
        {
            m_ID = iD;
            m_DayCheckIn = dayCheckIn;
            m_DayCheckOut = dayCheckOut;
            m_EmployeeID = employeeID;
            m_EmployeeName = employeeName;
            m_DiscountID = discountID;
            m_DiscountName = discountName;
            m_TableID = tableID;
            m_TableName = tableName;
            m_Total = total;
            m_StatusCheckOut = statusCheckOut;
        }

        public BillMenu(DataRow row)
        {
            this.m_ID = row["MAHD"].ToString();
            this.m_DayCheckIn = row["NGAYLAPHD"].ToString();
            this.m_DayCheckOut = row["NGAYXUATHD"].ToString();
            this.m_EmployeeID = (int)row["MANHANVIEN"];
            this.m_EmployeeName = row["TENNV"].ToString();
            this.m_DiscountID = row["MAGIAMGIA"].ToString();
            this.m_DiscountName = row["TENGIAMGIA"].ToString();
            this.m_TableID = (int)row["SOBAN"];
            this.m_TableName = row["TENBAN"].ToString();
            this.m_StatusCheckOut = (bool)row["TRANGTHAITHANHTOAN"];
            this.m_Total = float.Parse(row["TONGTIEN"].ToString());
        }
    }
}
