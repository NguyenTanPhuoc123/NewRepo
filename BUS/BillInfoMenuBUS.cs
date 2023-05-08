using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class BillInfoMenuBUS
    {      
        private static BillInfoMenuBUS instance;
        public static BillInfoMenuBUS Instance
        {
            get { if (instance == null) instance = new BillInfoMenuBUS(); return BillInfoMenuBUS.instance; }
            private set { BillInfoMenuBUS.instance = value; }
        }

        private BillInfoMenuBUS()
        {

        }

        public List<BillInfoMenu> GetListBillInfoMenu(string billID)
        {
            return BillInfoMenuDAO.Instance.GetListBillInfoMenuByBillID(billID);
        }

        public List<BillInfoMenu> GetListBillInfoMenuDeleted()
        {
            return BillInfoMenuDAO.Instance.GetListBillInfoMenuDeleted();
        }

    }
}
