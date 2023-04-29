using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account
    {
        private string m_username;
        private string m_password;
        private int m_employeeID;
        private int m_typeAccount;

        public string Username { get => m_username; set => m_username = value; }
        public string Password { get => m_password; set => m_password = value; }
        public int EmployeeID { get => m_employeeID; set => m_employeeID = value; }
        public int TypeAccount { get => m_typeAccount; set => m_typeAccount = value; }

        public Account(string username, string password, int typeAccount, int employeeID)
        {
            this.m_username = username;
            this.m_password = password;
            this.m_typeAccount = typeAccount;
            this.m_employeeID = employeeID;
        }

       
        public Account(DataRow row)
        {
            this.m_username = row["TENDANGNHAP"].ToString();
            this.m_password = row["MATKHAU"].ToString();
            this.m_typeAccount = (int)row["LOAITAIKHOAN"];
            this.m_employeeID = (int)row["MANV"];
        }
    }
}
