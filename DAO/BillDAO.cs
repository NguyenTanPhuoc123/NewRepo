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

        public Bill GetBillByBillID(string billID)
        {

            string query = string.Format("Select * from HOADON WHERE TRANGTHAI = 1 and MAHD = '{0}' ", billID);
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);
            while (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill;
            }

            return null;
        }

        public bool AddNewBill(int employeeID, int tableID)
        {
            int row;
            string query = String.Format("INSERT HOADON(MAHD,NGAYLAPHD,MANHANVIEN,MAGIAMGIA,SOBAN,TRANGTHAITHANHTOAN,TRANGTHAI,TONGTIEN) values('{0}',GETDATE(),{1},0,{2},0,1,0)", BILLID(), employeeID, tableID);
            row = DataProvider.ExecuteInsertCommand(query, null);
            return (row > 0 ? true : false);
        }
        public string BILLID()
        {
            string query = "SELECT COUNT(*) FROM HOADON";
            int data = DataProvider.ExecuteScalarCommand(query, null);
            data += 1;
            string billID = string.Format("HD" + data);
            return billID;
        }

        public bool CheckHD(int TableID)
        {
            string query = string.Format("SELECT COUNT(*) FROM HOADON WHERE SOBAN = {0} AND TRANGTHAI=1 And TRANGTHAITHANHTOAN = 0", TableID);
            int count = DataProvider.ExecuteScalarCommand(query, null);
            return (count > 0 ? false : true);
        }
        public string HDID(int TableID)
        {
            string query = string.Format("SELECT MAHD FROM HOADON WHERE SOBAN = {0} AND TRANGTHAI=1 And TRANGTHAITHANHTOAN = 0", TableID);
            DataTable count = DataProvider.ExcecuteSelectCommand(query, null);
            foreach(DataRow row in count.Rows)
            {
                return row["MAHD"].ToString();
            }
            return null;
        }
        public bool UpdateBill(int tableid, string tablenew)
        {
            int row;
            string query = String.Format("Update HOADON SET SOBAN ={0} WHERE SOBAN = {1}", tablenew, tableid);
            row = DataProvider.ExecuteInsertCommand(query, null);
            return (row > 0 ? true : false);
        }

        public int OutputBill(string BillID, float Total, string DiscountID)
        {
            string query = string.Format("update hoadon set ngayxuathd=getdate(), trangthaithanhtoan = 1, tongtien={0}, magiamgia='{1}' where mahd='{2}'", Total, DiscountID, BillID);
            int data = DataProvider.ExecuteInsertCommand(query, null);
            return data;
        }
    }
}
