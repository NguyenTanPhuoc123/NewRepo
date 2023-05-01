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

        public int AddNewBill(string billID, string dayCheckIn, string dayCheckOut, int employeeID, string customerID, string discountID, int tableID)
        {
            return BillDAO.Instance.AddNewBill(billID, dayCheckIn, dayCheckOut, employeeID, customerID, discountID, tableID);
        }
        public bool ADDBILL(int tableID)
        {
            return BillDAO.Instance.ADDBILL(tableID);
        }
        public bool CheckHD(int TableID)
        {
            return BillDAO.Instance.CheckHD(TableID);
        }
    }
}
