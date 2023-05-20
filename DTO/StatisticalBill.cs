using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class StatisticalBill
    {                   
        private int m_EmployeeID;
        private string m_EmployeeName;           
        private int m_CountBill;

        public StatisticalBill(int employeeID, string employeeName, int countBill)
        {                     
            m_EmployeeID = employeeID;
            m_EmployeeName = employeeName;          
            m_CountBill = countBill;
        }
        
     
        public int EmployeeID { get => m_EmployeeID; set => m_EmployeeID = value; }
        public string EmployeeName { get => m_EmployeeName; set => m_EmployeeName = value; }      
        public int CountBill { get => m_CountBill; set => m_CountBill = value; }

        public StatisticalBill(DataRow row)
        {                                  
            this.m_EmployeeID = (int)row["MANHANVIEN"];
            this.m_EmployeeName = row["TENNV"].ToString();                      
            this.m_CountBill = (int)row["TONGSOHOADON"];
        }
     
    }

}
