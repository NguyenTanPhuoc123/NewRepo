using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAO
{
    public class BillInfoDAO
    {      
        private static BillInfoDAO instance;
        public static BillInfoDAO Instance
        {
            get { if (instance == null) instance = new BillInfoDAO(); return BillInfoDAO.instance; }
            private set { BillInfoDAO.instance = value; }
        }

        private BillInfoDAO()
        {

        }

        public List<BillInfo> GetListBillInfo()
        {
            List<BillInfo> list = new List<BillInfo>();
            string query = "Select * from CHITIETHOADON WHERE TRANGTHAI = 1";
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);
            foreach (DataRow item in data.Rows)
            {
                BillInfo billInfo = new BillInfo(item);
                list.Add(billInfo);
            }

            return list;
        }
    }
}
