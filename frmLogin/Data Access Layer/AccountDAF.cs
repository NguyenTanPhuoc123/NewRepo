using frmLogin.Data_Tranfer_Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmLogin.Data_Access_Layer
{
   public class AccountDAF
    {
        private static AccountDAF instance;
        public static AccountDAF Instance
        {
            get { if (instance == null) instance = new AccountDAF(); return AccountDAF.instance; }
            private set { AccountDAF.instance = value; }
        }

        private AccountDAF()
        {

        }

        public bool ktDangNhap(string username, string password)
        {
            string sql = "select count(*) from taikhoan where TENDANGNHAP = @username AND MATKHAU = @password";
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@username", username);
            parameters[1] = new SqlParameter("@password", Utils.GetMD5(password));
            if (DataProvider.ExecuteScalarCommand(sql, parameters) == 1)
            {
                return true;
            }
            return false;
        }
            
        public Account GetAccountForUsername(string username)
        {
            DataTable data = DataProvider.ExcecuteSelectCommand("Select * from TAIKHOAN where TENDANGNHAP = '" + username+"'", null);

            foreach(DataRow item in data.Rows)
            {
                return new Account(item);
            }

            return null;
        }
        
    }
}
