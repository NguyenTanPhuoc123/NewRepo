using frmLogin.Data_Tranfer_Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmLogin.Data_Access_Layer
{
    public class TypeAccountDAF
    {
        private static TypeAccountDAF instance;
        public static TypeAccountDAF Instance
        {
            get { if (instance == null) instance = new TypeAccountDAF(); return TypeAccountDAF.instance; }
            private set { TypeAccountDAF.instance = value; }
        }

        private TypeAccountDAF()
        {

        }

        public TypeAccount GetTypeAccountForTypeAccountID(int typeAccountID)
        {
            string query = string.Format("Select * from LOAITAIKHOAN Where MALOAI = {0} ", typeAccountID);
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);
           
            foreach(DataRow item in data.Rows)
            {    
                return new TypeAccount(item);
            }

            return null;
        }
    }
}
