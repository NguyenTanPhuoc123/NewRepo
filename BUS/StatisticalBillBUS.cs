using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class StatisticalBillBUS
    {
        private static StatisticalBillBUS instance;
        public static StatisticalBillBUS Instance
        {
            get { if (instance == null) instance = new StatisticalBillBUS(); return StatisticalBillBUS.instance; }
            private set { StatisticalBillBUS.instance = value; }
        }

        private StatisticalBillBUS()
        {

        }

        public List<StatisticalBill> GetListEmployeeCreateBillMaxByDate(string startDay, string endDay)
        {
            return StatisticalBillDAO.Instance.GetListEmployeeCreateBillMaxByDate(startDay, endDay);
        }

        public List<StatisticalBill> GetListEmployeeCreateBillMinByDate(string startDay, string endDay)
        {
            return StatisticalBillDAO.Instance.GetListEmployeeCreateBillMinByDate(startDay, endDay);
        }
    }
}
