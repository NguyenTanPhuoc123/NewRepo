using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAO
{
   public class BillMenuDAO
    {
        
        private static BillMenuDAO instance;
        public static BillMenuDAO Instance
        {
            get { if (instance == null) instance = new BillMenuDAO(); return BillMenuDAO.instance; }
            private set { BillMenuDAO.instance = value; }
        }

        private BillMenuDAO()
        {

        }

        public List<BillMenu> GetListBillMenu()
        {
            List<BillMenu> list = new List<BillMenu>();
            string query = "SELECT * FROM HOADON a, BANAN b, NHANVIEN c , GIAMGIA d WHERE a.MAGIAMGIA = d.MAGIAM and a.MANHANVIEN = c.MANV AND a.SOBAN = b.MABANAN and a.TrangThai = 1";
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);
            foreach(DataRow item in data.Rows)
            {
                BillMenu billMenu = new BillMenu(item);
                list.Add(billMenu);
            }

            return list;
        }

        public List<BillMenu> GetListBillMenuByDate(string startDay, string endDay)
        {
            List<BillMenu> list = new List<BillMenu>();
            string query = string.Format("LoadBillMenuByDate '{0}' , '{1}' ", startDay, endDay);
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);
            foreach (DataRow item in data.Rows)
            {
                BillMenu billMenu = new BillMenu(item);
                list.Add(billMenu);
            }

            return list;
        }

        public BillMenu GetBillMenuByTableID(int tableID)
        {
            string query = string.Format("SELECT * FROM HOADON a, BANAN b, NHANVIEN c , GIAMGIA d WHERE a.MAGIAMGIA = d.MAGIAM and a.MANHANVIEN = c.MANV AND a.SOBAN = b.MABANAN and a.TrangThai = 1 and SOBAN = {0} and TRANGTHAITHANHTOAN = 0 ", tableID);
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);
            foreach (DataRow item in data.Rows)
            {
                return new BillMenu(item);
            }
            return null;
        }

        public List<BillMenu> SortBillByBillID(string dayCheckIn)
        {
            List<BillMenu> list = new List<BillMenu>();
            string query = "";
            if(dayCheckIn==null)
                query = string.Format("SELECT * FROM HOADON a, BANAN b, NHANVIEN c , GIAMGIA d WHERE a.MAGIAMGIA = d.MAGIAM and a.MANHANVIEN = c.MANV AND a.SOBAN = b.MABANAN and a.TrangThai = 1  Order by a.MAHD ");
            else
                query = string.Format("SELECT * FROM HOADON a, BANAN b, NHANVIEN c , GIAMGIA d WHERE a.MAGIAMGIA = d.MAGIAM and a.MANHANVIEN = c.MANV AND a.SOBAN = b.MABANAN and a.TrangThai = 1 and DAY(a.NGAYLAPHD) = DAY('{0}') and MONTH(a.NGAYLAPHD) = MONTH('{0}') and YEAR(a.NGAYLAPHD) = YEAR('{0}') Order by a.MAHD ", dayCheckIn);
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);
            foreach (DataRow item in data.Rows)
            {
                BillMenu billMenu = new BillMenu(item);
                list.Add(billMenu);
            }

            return list;
        }

        public List<BillMenu> SortBillByBillIDDesc(string dayCheckIn)
        {
            List<BillMenu> list = new List<BillMenu>();
            string query = "";
            if (dayCheckIn == null)
                query = string.Format("SELECT * FROM HOADON a, BANAN b, NHANVIEN c , GIAMGIA d WHERE a.MAGIAMGIA = d.MAGIAM and a.MANHANVIEN = c.MANV AND a.SOBAN = b.MABANAN and a.TrangThai = 1  Order by a.MAHD DESC ");
            else
                query = string.Format("SELECT * FROM HOADON a, BANAN b, NHANVIEN c , GIAMGIA d WHERE a.MAGIAMGIA = d.MAGIAM and a.MANHANVIEN = c.MANV AND a.SOBAN = b.MABANAN and a.TrangThai = 1 and DAY(a.NGAYLAPHD) = DAY('{0}') and MONTH(a.NGAYLAPHD) = MONTH('{0}') and YEAR(a.NGAYLAPHD) = YEAR('{0}') Order by a.MAHD DESC ", dayCheckIn);
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);
            foreach (DataRow item in data.Rows)
            {
                BillMenu billMenu = new BillMenu(item);
                list.Add(billMenu);
            }

            return list;
        }

        public List<BillMenu> SortBillByDayCheckIn(string dayCheckIn)
        {
            List<BillMenu> list = new List<BillMenu>();
            string query = "";
            if(dayCheckIn==null)
                query = string.Format("SELECT * FROM HOADON a, BANAN b, NHANVIEN c , GIAMGIA d WHERE a.MAGIAMGIA = d.MAGIAM and a.MANHANVIEN = c.MANV AND a.SOBAN = b.MABANAN and a.TrangThai = 1 Order by a.NgayLapHD ");
            else
                query = string.Format("SELECT * FROM HOADON a, BANAN b, NHANVIEN c , GIAMGIA d WHERE a.MAGIAMGIA = d.MAGIAM and a.MANHANVIEN = c.MANV AND a.SOBAN = b.MABANAN and a.TrangThai = 1 and DAY(a.NGAYLAPHD) = DAY('{0}') and MONTH(a.NGAYLAPHD) = MONTH('{0}') and YEAR(a.NGAYLAPHD) = YEAR('{0}') Order by a.NgayLapHD ", dayCheckIn);
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);
            foreach (DataRow item in data.Rows)
            {
                BillMenu billMenu = new BillMenu(item);
                list.Add(billMenu);
            }

            return list;
        }

        public List<BillMenu> SortBillByDayCheckInDesc(string dayCheckIn)
        {
            List<BillMenu> list = new List<BillMenu>();
            string query = "";
            if (dayCheckIn == null)
                query = string.Format("SELECT * FROM HOADON a, BANAN b, NHANVIEN c , GIAMGIA d WHERE a.MAGIAMGIA = d.MAGIAM and a.MANHANVIEN = c.MANV AND a.SOBAN = b.MABANAN and a.TrangThai = 1 Order by a.NgayLapHD DESC ");
            else
                query = string.Format("SELECT * FROM HOADON a, BANAN b, NHANVIEN c , GIAMGIA d WHERE a.MAGIAMGIA = d.MAGIAM and a.MANHANVIEN = c.MANV AND a.SOBAN = b.MABANAN and a.TrangThai = 1 and DAY(a.NGAYLAPHD) = DAY('{0}') and MONTH(a.NGAYLAPHD) = MONTH('{0}') and YEAR(a.NGAYLAPHD) = YEAR('{0}') Order by a.NgayLapHD DESC ", dayCheckIn);
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);
            foreach (DataRow item in data.Rows)
            {
                BillMenu billMenu = new BillMenu(item);
                list.Add(billMenu);
            }

            return list;
        }

        public List<BillMenu> SortBillByTotal(string dayCheckIn)
        {
            List<BillMenu> list = new List<BillMenu>();
            string query = "";
            if(dayCheckIn==null)                  
                query = string.Format("SELECT * FROM HOADON a, BANAN b, NHANVIEN c , GIAMGIA d WHERE a.MAGIAMGIA = d.MAGIAM and a.MANHANVIEN = c.MANV AND a.SOBAN = b.MABANAN and a.TrangThai = 1 Order by a.TongTien ");
            else
                query = string.Format("SELECT * FROM HOADON a, BANAN b, NHANVIEN c , GIAMGIA d WHERE a.MAGIAMGIA = d.MAGIAM and a.MANHANVIEN = c.MANV AND a.SOBAN = b.MABANAN and a.TrangThai = 1 and DAY(a.NGAYLAPHD) = DAY('{0}') and MONTH(a.NGAYLAPHD) = MONTH('{0}') and YEAR(a.NGAYLAPHD) = YEAR('{0}') Order by a.TongTien ", dayCheckIn);
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);
            foreach (DataRow item in data.Rows)
            {
                BillMenu billMenu = new BillMenu(item);
                list.Add(billMenu);
            }

            return list;
        }

        public List<BillMenu> SortBillByTotalDesc(string dayCheckIn)
        {
            List<BillMenu> list = new List<BillMenu>();
            string query = "";
            if (dayCheckIn == null)
                query = string.Format("SELECT * FROM HOADON a, BANAN b, NHANVIEN c , GIAMGIA d WHERE a.MAGIAMGIA = d.MAGIAM and a.MANHANVIEN = c.MANV AND a.SOBAN = b.MABANAN and a.TrangThai = 1 Order by a.TongTien DESC ");
            else
                query = string.Format("SELECT * FROM HOADON a, BANAN b, NHANVIEN c , GIAMGIA d WHERE a.MAGIAMGIA = d.MAGIAM and a.MANHANVIEN = c.MANV AND a.SOBAN = b.MABANAN and a.TrangThai = 1 and DAY(a.NGAYLAPHD) = DAY('{0}') and MONTH(a.NGAYLAPHD) = MONTH('{0}') and YEAR(a.NGAYLAPHD) = YEAR('{0}') Order by a.TongTien DESC ", dayCheckIn);
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);
            foreach (DataRow item in data.Rows)
            {
                BillMenu billMenu = new BillMenu(item);
                list.Add(billMenu);
            }

            return list;
        }

        public List<BillMenu> FillBillByDayCheckIn(string dayCheckIn)
        {
            List<BillMenu> list = new List<BillMenu>();                    
              string  query = string.Format("SELECT * FROM HOADON a, BANAN b, NHANVIEN c , GIAMGIA d WHERE a.MAGIAMGIA = d.MAGIAM and a.MANHANVIEN = c.MANV AND a.SOBAN = b.MABANAN and a.TrangThai = 1 and DAY(a.NGAYLAPHD) = DAY('{0}') and MONTH(a.NGAYLAPHD) = MONTH('{0}') and YEAR(a.NGAYLAPHD) = YEAR('{0}')", dayCheckIn);
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);
            foreach (DataRow item in data.Rows)
            {
                BillMenu billMenu = new BillMenu(item);
                list.Add(billMenu);
            }

            return list;
        }

        public List<BillMenu> GetListBillMenuForID(string BillID)
        {
            List<BillMenu> list = new List<BillMenu>();
            string query = string.Format("SELECT * FROM HOADON a, BANAN b, NHANVIEN c , GIAMGIA d WHERE a.MAGIAMGIA = d.MAGIAM and a.MANHANVIEN = c.MANV AND a.SOBAN = b.MABANAN and a.TrangThai = 1 and MAHD='{0}'",BillID);
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);
            foreach (DataRow item in data.Rows)
            {
                BillMenu billMenu = new BillMenu(item);
                list.Add(billMenu);
            }

            return list;
        }
    }
}
