using System;
using System.Collections.Generic;
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
        private string m_employeeID;
        private int m_typeAccount;
        private bool m_status;

        public string Username { get => m_username; set => m_username = value; }
        public string Password { get => m_password; set => m_password = value; }
        public string EmployeeID { get => m_employeeID; set => m_employeeID = value; }
        public int TypeAccount { get => m_typeAccount; set => m_typeAccount = value; }
        public bool Status { get => m_status; set => m_status = value; }

        public Account(string username, string password, int typeAccount)
        {
            this.m_username = username;
            this.m_password = password;
            this.m_typeAccount = typeAccount;
        }
    }
}
