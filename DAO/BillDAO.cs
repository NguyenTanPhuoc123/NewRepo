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

    }
}
