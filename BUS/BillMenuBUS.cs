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

        public List<BillMenu> SortBillByBillID(string dayCheckIn)
        {
            return BillMenuDAO.Instance.SortBillByBillID(dayCheckIn);
        }

        public List<BillMenu> SortBillByBillIDDesc(string dayCheckIn)
        {
            return BillMenuDAO.Instance.SortBillByBillIDDesc(dayCheckIn);
        }

        public List<BillMenu> SortBillByDayCheckIn(string dayCheckIn)
        {
            return BillMenuDAO.Instance.SortBillByDayCheckIn(dayCheckIn);
        }

        public List<BillMenu> SortBillByDayCheckInDesc(string dayCheckIn)
        {
            return BillMenuDAO.Instance.SortBillByDayCheckInDesc(dayCheckIn);
        }

        public List<BillMenu> SortBillByTotal(string dayCheckIn)
        {
            return BillMenuDAO.Instance.SortBillByTotal(dayCheckIn);
        }

        public List<BillMenu> SortBillByTotalDesc(string dayCheckIn)
        {
            return BillMenuDAO.Instance.SortBillByTotalDesc(dayCheckIn);
        }

        public List<BillMenu> FillBillByDayCheckIn(string dayCheckIn)
        {
            return BillMenuDAO.Instance.FillBillByDayCheckIn(dayCheckIn);
        }

    }
}
