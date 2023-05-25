using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
namespace DAO
{
   public class StatisticalBillDAO
    {
        private static StatisticalBillDAO instance;
        public static StatisticalBillDAO Instance
        {
            get { if (instance == null) instance = new StatisticalBillDAO(); return StatisticalBillDAO.instance; }
            private set { StatisticalBillDAO.instance = value; }
        }

        private StatisticalBillDAO()
        {

        }

        public List<StatisticalBill> GetListEmployeeCreateBillMaxByDate(string startDay, string endDay)
        {
            List<StatisticalBill> list = new List<StatisticalBill>();
            string query = string.Format("EXEC LoadEmployeeCreateBillMaxByDate '{0}' , '{1}' ",startDay,endDay);
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);
            foreach (DataRow item in data.Rows)
            {
                StatisticalBill bill = new StatisticalBill(item);
                list.Add(bill);
            }

            return list;
        }

        public List<StatisticalBill> GetListEmployeeCreateBillMinByDate(string startDay, string endDay)
        {
            List<StatisticalBill> list = new List<StatisticalBill>();
            string query = string.Format("EXEC LoadEmployeeCreateBillMinByDate '{0}' , '{1}' ", startDay, endDay);
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);
            foreach (DataRow item in data.Rows)
            {
                StatisticalBill bill = new StatisticalBill(item);
                list.Add(bill);
            }

            return list;
        }
        
    }
}
