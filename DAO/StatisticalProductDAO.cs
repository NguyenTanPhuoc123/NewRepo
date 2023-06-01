using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
namespace DAO
{
    public class StatisticalProductDAO
    {
        private static StatisticalProductDAO instance;

        public static StatisticalProductDAO Instance
        {
            get { if (instance == null) instance = new StatisticalProductDAO(); return StatisticalProductDAO.instance; }
            private set { StatisticalProductDAO.instance = value; }
        }

        private StatisticalProductDAO()
        {

        }

        public List<StatisticalProduct> StatisticalProductSoldMaxByDay(string startDay, string endDay)
        {
            List<StatisticalProduct> list = new List<StatisticalProduct>();
            string query = string.Format("SELECT TOP 7 c.MASANPHAM,c.TENSANPHAM, c.SOLUONG,c.DONGIA, SUM(b.SOLUONG) 'TongSoLuongBan'   FROM HOADON a, CHITIETHOADON b, SANPHAM c WHERE a.MAHD = b.MAHD and b.MASP = c.MASANPHAM and b.TRANGTHAI = 1 and c.TRANGTHAI = 1 and a.NGAYXUATHD >= '{0}' and a.NGAYXUATHD <= '{1}' GROUP BY c.MASANPHAM,c.TENSANPHAM , c.SOLUONG,c.DONGIA ORDER BY SUM(b.SOLUONG) DESC", startDay, endDay);
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);
            foreach(DataRow item in data.Rows)
            {
                StatisticalProduct product = new StatisticalProduct(item);
                list.Add(product);
            }
            return list;
        }

        public List<StatisticalProduct> StatisticalProductSoldMinByDay(string startDay, string endDay)
        {
            List<StatisticalProduct> list = new List<StatisticalProduct>();
            string query = string.Format("SELECT TOP 7 c.MASANPHAM,c.TENSANPHAM, c.SOLUONG,c.DONGIA, SUM(b.SOLUONG) 'TongSoLuongBan'   FROM HOADON a, CHITIETHOADON b, SANPHAM c WHERE a.MAHD = b.MAHD and b.MASP = c.MASANPHAM and b.TRANGTHAI = 1 and c.TRANGTHAI = 1 and a.NGAYXUATHD >= '{0}' and a.NGAYXUATHD <= '{1}' GROUP BY c.MASANPHAM,c.TENSANPHAM , c.SOLUONG,c.DONGIA ORDER BY SUM(b.SOLUONG)", startDay, endDay);
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);
            foreach (DataRow item in data.Rows)
            {
                StatisticalProduct product = new StatisticalProduct(item);
                list.Add(product);
            }
            return list;
        }
      

        public List<StatisticalProduct> GetListProductByDay(string startDay, string endDay)
        {
            List<StatisticalProduct> list = new List<StatisticalProduct>();
            string query = string.Format("SELECT c.MASANPHAM,c.TENSANPHAM, c.SOLUONG,c.DONGIA, SUM(b.SOLUONG) 'TongSoLuongBan'   FROM HOADON a, CHITIETHOADON b, SANPHAM c WHERE a.MAHD = b.MAHD and b.MASP = c.MASANPHAM and b.TRANGTHAI = 1 and c.TRANGTHAI = 1 and a.NGAYXUATHD >= '{0}' and a.NGAYXUATHD <= '{1}' GROUP BY c.MASANPHAM,c.TENSANPHAM , c.SOLUONG,c.DONGIA ", startDay, endDay);
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);
            foreach (DataRow item in data.Rows)
            {
                StatisticalProduct product = new StatisticalProduct(item);
                list.Add(product);
            }
            return list;
        }       

        public int GetSumQuantitySellByDay(string startDay, string endDay)
        {
            int sum;

            string query = string.Format("SELECT SUM(b.SOLUONG) 'TongSoLuongBan'   FROM HOADON a, CHITIETHOADON b, SANPHAM c WHERE a.MAHD = b.MAHD and b.MASP = c.MASANPHAM and b.TRANGTHAI = 1 and c.TRANGTHAI = 1 and a.NGAYXUATHD >= '{0}' and a.NGAYXUATHD <= '{1}'", startDay, endDay);
            try
            {
                sum = DataProvider.ExecuteScalarCommand(query, null);
            }
            catch
            {
                sum = 0;
            }
            return sum;
        }

        public List<StatisticalProduct> StatisticalProductCanNotSellByDay(string startDay, string endDay)
        {
            List<StatisticalProduct> list = new List<StatisticalProduct>();
            string query = string.Format("SELECT c.MASANPHAM,c.TENSANPHAM, c.SOLUONG,c.DONGIA, SUM(0) 'TongSoLuongBan'   FROM HOADON a, SANPHAM c WHERE c.TRANGTHAI = 1 and a.NGAYXUATHD >= '{0}' and a.NGAYXUATHD <= '{1}' and c.MASANPHAM NOT IN (SELECT MASP FROM CHITIETHOADON WHERE CHITIETHOADON.TRANGTHAI = 1) GROUP BY c.MASANPHAM,c.TENSANPHAM , c.SOLUONG,c.DONGIA", startDay, endDay);
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);
            foreach (DataRow item in data.Rows)
            {
                StatisticalProduct product = new StatisticalProduct(item);
                list.Add(product);
            }
            return list;
        }

    }
}
