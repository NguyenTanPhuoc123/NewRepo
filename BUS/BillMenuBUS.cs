using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class BillMenuBUS
    {
        private static BillMenuBUS instance;
        public static BillMenuBUS Instance
        {
            get { if (instance == null) instance = new BillMenuBUS(); return BillMenuBUS.instance; }
            private set { BillMenuBUS.instance = value; }
        }

        private BillMenuBUS()
        {

        }

        public List<BillMenu> GetListBillMenu()
        {
            return BillMenuDAO.Instance.GetListBillMenu();
        }
    }
}
