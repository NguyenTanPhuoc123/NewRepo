using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using System.Data.SqlClient;

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
        

        public int InsertNewBillInfo(string billID, string productID,float price,string count, float total)
        {
            int row;
            string query = string.Format("INSERT INTO CHITIETHOADON(MAHD,MASP,SOLUONG,DONGIA,THANHTIEN,TRANGTHAI) VALUES('{0}','{1}',{2},{3},{4},1)", billID, productID, count, price, total);
            row = DataProvider.ExecuteInsertCommand(query, null);
            return row;
        }


        public int DeleteBillInfo(string billID, string productID)
        {
            int row;
            string query = string.Format("UPDATE CHITIETHOADON SET TrangThai = 0 WHERE MAHD = '{0}' and MASP = '{1}' ", billID, productID);
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

        public int DeleteAllBillInfo()
        {
            int row;
            string query = string.Format("UPDATE CHITIETHOADON SET TrangThai = 0");
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

        public int RestoreBillInfo(string billID, string productID)
        {
            int row;
            string query = string.Format("UPDATE CHITIETHOADON SET TrangThai = 1 WHERE MAHD = '{0}' and MASP = '{1}' ", billID, productID);
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

        public int RestoreAllBillInfo()
        {
            int row;
            string query = string.Format("UPDATE CHITIETHOADON SET TrangThai = 1 ");
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

        public bool CheckProduct(string ProductID,string mahd)
        {
            string query =string.Format("Select count(*) from Chitiethoadon where MASP = '{0}' AND MAHD = '{1}'",ProductID,mahd);
            int data = DataProvider.ExecuteScalarCommand(query, null);
            return (data > 0 ? true : false);
        }
        public void UpdateCount(string soluong,string ProductID, string mahd)
        {
            string query = string.Format("UPDATE CHITIETHOADON SET SOLUONG = SOLUONG + {0},THANHTIEN = THANHTIEN +(DONGIA*{1}) where MASP = '{2}' AND MAHD = '{3}'", soluong,soluong, ProductID,mahd);
            DataProvider.ExecuteInsertCommand(query, null);
        }
        public bool CheckProductDeleted(string ProductID, string mahd)
        {
            string query = string.Format("Select count(*) from Chitiethoadon where MASP = '{0}' AND MAHD = '{1}' AND TRANGTHAI=0", ProductID, mahd);
            int data = DataProvider.ExecuteScalarCommand(query, null);
            return (data > 0 ? true : false);
        }
        public void UpdateProduct(string soluong, string ProductID, string mahd,float thanhtien)
        {
            string query = string.Format("UPDATE CHITIETHOADON SET SOLUONG = {0},THANHTIEN ={1},TRANGTHAI=1 where MASP = '{2}' AND MAHD = '{3}'", soluong, thanhtien, ProductID, mahd);
            DataProvider.ExecuteInsertCommand(query, null);
        }
        public bool CheckProduct(string ProductID)
        {
            string query = string.Format("Select count(*) from Chitiethoadon where MASP = '{0}'", ProductID);
            int data = DataProvider.ExecuteScalarCommand(query, null);
            return (data > 0 ? false : true);
        }
    }
}
