using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmLogin.Data_Tranfer_Object
{
    public class Account
    {
        public static int typeAccount;
        private string m_username;
        private string m_password;
        private int m_employeeID;
        private int m_typeAccount;
        private string m_employeeName;
        private string m_typeName;

        public string Username { get => m_username; set => m_username = value; }
        public string Password { get => m_password; set => m_password = value; }
        public int EmployeeID { get => m_employeeID; set => m_employeeID = value; }
        public int TypeAccount { get => m_typeAccount; set => m_typeAccount = value; }
        public string EmployeeName { get => m_employeeName; set => m_employeeName = value; }
        public string TypeName { get => m_typeName; set => m_typeName = value; }

        public Account(string username, string password, int typeAccount, int employeeID, string typeName, string employeName)
        {
            this.m_username = username;
            this.m_password = password;
            this.m_typeAccount = typeAccount;
            this.m_employeeID = employeeID;
            this.m_typeName = typeName;
            this.m_employeeName = employeName;
        }

        public Account(DataRow row)
        {
            this.m_username = row["TENDANGNHAP"].ToString();
            this.m_password = row["MATKHAU"].ToString();
            this.m_typeAccount = (int)row["LOAITAIKHOAN"];
            this.m_employeeID = (int)row["MANV"];
            this.m_typeName = row["TENLOAI"].ToString();
            this.m_employeeName = row["TENNV"].ToString();
            
        }
    }
}
