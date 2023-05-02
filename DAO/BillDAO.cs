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

        public int AddNewBill(string dayCheckIn, string dayCheckOut,int employeeID, string discountID, int tableID, float totalPrice)
        {
            int row;
            string query = String.Format("INSERT HOADON(MAHD,NGAYLAPHD,NGAYXUATHD,MANHANVIEN,SOBAN,TRANGTHAITHANHTOAN,TRANGTHAI) values('{0}',{1},{2},{3},{4},0,1)", BILLID(), dayCheckIn, dayCheckOut, employeeID, tableID);
                row = DataProvider.ExecuteInsertCommand(query, null);
            return row;
        }
        public string BILLID()
        {
            string query = "SELECT COUNT(*) FROM HOADON";
            int data = DataProvider.ExecuteScalarCommand(query, null);
            data += 1;
            string billID = string.Format("HD" + data);
            return billID;
        }
        //Them vao hoa don moi
        public bool ADDBILL(int tableID)
        {
            string MAHD = BILLID();
            string query = "INSERT INTO HOADON(MAHD,SOBAN,MANHANVIEN,MAKHACHHANG,MAGIAMGIA,TRANGTHAITHANHTOAN) VALUES(@MAHD,@MABAN,null,null,null,1)";
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@MAHD", MAHD);
            parameters[1] = new SqlParameter("@MABAN", tableID);
            int count = DataProvider.ExecuteInsertCommand(query, parameters);
            return (count > 0 ? true : false);
        }
        public bool CheckHD(int TableID)
        {
            string query = string.Format("SELECT COUNT(*) FROM HOADON WHERE SOBAN = {0} AND TRANGTHAI=1", TableID);
            int count = DataProvider.ExecuteScalarCommand(query, null);
            return (count > 0 ? false : true);
        }
        public string HDID(int TableID)
        {
            string query = string.Format("SELECT MAHD FROM HOADON WHERE SOBAN = {0} AND TRANGTHAI=1", TableID);
            DataTable count = DataProvider.ExcecuteSelectCommand(query, null);
            foreach(DataRow row in count.Rows)
            {
                return row["MAHD"].ToString();
            }
            return null;
        }
    }
}
