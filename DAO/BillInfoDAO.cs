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


        public int DeleteBillInfo(string billID, string productID)
        {
            int row;
            string query = string.Format("UPDATE CHITIETHOADON SET TrangThai = 0 WHERE billID = {0} and productID = {1}", billID, productID);
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
        public int BILLMAXID()
        {
            string query = "SELECT COUNT(*) FROM HOADON";
            int billID = DataProvider.ExecuteScalarCommand(query, null);
            return billID;
        }
        //them vao chi tiet hoa don
        public void ADDBILLINFO(string masp, string soluong)
        {
            int BillID = BILLMAXID();
            string MAHD = string.Format("HD{0}", BillID);
            string query = "INSERT INTO CHITIETHOADON(MAHD,MASP,SOLUONG,TRANGTHAI) VALUES(@MAHD,@MASP,@SOLUONG,1)";
            SqlParameter[] parameters = new SqlParameter[3];
            parameters[0] = new SqlParameter("@MAHD", MAHD);
            parameters[1] = new SqlParameter("@MASP", masp);
            parameters[2] = new SqlParameter("@SOLUONG", soluong);
            DataProvider.ExecuteInsertCommand(query, parameters);
        }
    }
}
