using frmLogin.Data_Tranfer_Object;
using System;
using System.Collections.Generic;
using System.Data;
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
