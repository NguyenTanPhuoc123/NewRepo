using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAO
{
    public class BillDAO
    {
        private static BillDAO instance;
        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { BillDAO.instance = value; }
        }

        private BillDAO()
        {

        }

        public List<Bill> GetListBill()
        {
            List<Bill> list = new List<Bill>();
            string query = "Select * from HOADON WHERE TRANGTHAI = 1";
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);
            foreach(DataRow item in data.Rows)
            {
                Bill bill = new Bill(item);
                list.Add(bill); 
            }

            return list;
        }

<<<<<<< HEAD
=======
        public string GetBillIDByTableID(int tableID)
        {
           
            string query = string.Format("Select * from HOADON WHERE TRANGTHAI = 1 and SOBAN = {0}",tableID);
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);
            while ( data.Rows.Count>0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }

            return null;
        }

        public int AddNewBill(string billID, string dayCheckIn, string dayCheckOut,int employeeID, string customerID, string discountID, int tableID)
        {
            int row;
            string query = String.Format("INSERT HOADON values('{0}','{1}','{2}',{3},'{4}','{5}',{6},0,1)", billID, dayCheckIn, dayCheckOut, employeeID, customerID, discountID, tableID);
            try
            {
                row = DataProvider.ExecuteInsertCommand(query, null);

            }
            catch
            {
                row = 0;
            }

            return row;
        }
>>>>>>> 48c3914ddd7f5b16947abace3ded29db95a6cf44
    }
}
