using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAO
{
    public class BillInfoMenuDAO
    {       
        private static BillInfoMenuDAO instance;
        public static BillInfoMenuDAO Instance
        {
            get { if (instance == null) instance = new BillInfoMenuDAO(); return BillInfoMenuDAO.instance; }
            private set { BillInfoMenuDAO.instance = value; }
        }

        private BillInfoMenuDAO()
        {

        }

        public List<BillInfoMenu> GetListBillInfoMenuByBillID(string billID)
        {
            List<BillInfoMenu> list = new List<BillInfoMenu>();
            string query = string.Format("GetListBillInfoMenuByBillID {0} ", billID);
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);
            foreach(DataRow item in data.Rows)
            {
                BillInfoMenu billInfoMenu = new BillInfoMenu(item);
                list.Add(billInfoMenu);
            }

            return list;
        }
            
    }
}
