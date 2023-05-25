using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class StatisticalProductBUS
    {
        private static StatisticalProductBUS instance;

        public static StatisticalProductBUS Instance
        {
            get { if (instance == null) instance = new StatisticalProductBUS(); return StatisticalProductBUS.instance; }
            private set { StatisticalProductBUS.instance = value; }
        }

        private StatisticalProductBUS()
        {

        }

        public List<StatisticalProduct> StatisticalProductSoldMaxByDay(string startDay, string endDay)
        {
            return StatisticalProductDAO.Instance.StatisticalProductSoldMaxByDay(startDay, endDay);

        }
        public List<StatisticalProduct> StatisticalProductSoldMinByDay(string startDay, string endDay)
        {
            return StatisticalProductDAO.Instance.StatisticalProductSoldMinByDay(startDay, endDay);
        }

        public List<StatisticalProduct> GetListProductByDay(string startDay, string endDay)
        {
            return StatisticalProductDAO.Instance.GetListProductByDay(startDay, endDay);
        }

        public int GetSumQuantitySellByDay(string startDay, string endDay)
        {
            return StatisticalProductDAO.Instance.GetSumQuantitySellByDay(startDay, endDay);
        }

        public List<StatisticalProduct> StatisticalProductCanNotSellByDay(string startDay, string endDay)
        {
            return StatisticalProductDAO.Instance.StatisticalProductCanNotSellByDay(startDay, endDay);
        }
    }
}
