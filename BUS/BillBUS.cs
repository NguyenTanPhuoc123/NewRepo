using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class BillBUS
    {
        private static BillBUS instance;
        public static BillBUS Instance
        {
            get { if (instance == null) instance = new BillBUS(); return BillBUS.instance; }
            private set { BillBUS.instance = value; }
        }

        private BillBUS()
        {

        }

        public List<Bill> GetListBill()
        {
            return BillDAO.Instance.GetListBill();
        }

        public bool AddNewBill(int employeeID, int tableID)
        {
            return BillDAO.Instance.AddNewBill(employeeID, tableID);
        }
        public bool CheckHD(int TableID)
        {
            return BillDAO.Instance.CheckHD(TableID);
        }
        public string HDID(int TableID)
        {
            return BillDAO.Instance.HDID(TableID);
        }
        public bool UpdateBill(int tableid, string tablenew)
        {
            return BillDAO.Instance.UpdateBill(tableid, tablenew);
        }
    }
}
