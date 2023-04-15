using frmLogin.Data_Tranfer_Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmLogin.Data_Access_Layer
{
    public class AccountMenuDAF
    {

        private static AccountMenuDAF instance;
        public static AccountMenuDAF Instance
        {
            get { if (instance == null) instance = new AccountMenuDAF(); return AccountMenuDAF.instance; }
            private set { AccountMenuDAF.instance = value; }
        }

        private AccountMenuDAF()
        {

        }

        public List<AccountMenu> GetListAccount()
        {
            List<AccountMenu> lst = new List<AccountMenu>();
            string query = "select * from TAIKHOAN a, NHANVIEN b, LOAITAIKHOAN c where a.trangthai=1 and a.MANV = b.MANV and a.LOAITAIKHOAN = c.MALOAI";
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);
            foreach (DataRow item in data.Rows)
            {
                AccountMenu acc = new AccountMenu(item);
                lst.Add(acc);
            }
            return lst;
        }
    }
}
