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
    public class MenuDishDAO
    {
        private static MenuDishDAO instance;
        public static MenuDishDAO Instance
        {
            get { if (instance == null) instance = new MenuDishDAO(); return MenuDishDAO.instance; }
            private set { MenuDishDAO.instance = value; }
        }

        private MenuDishDAO()
        {

        }

        public List<MenuDish> GetListMenuDishByTableID(int tableID)
        {
            List<MenuDish> list = new List<MenuDish>();
            string query = string.Format("EXEC LoadMenuDish {0}", tableID);
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);
            foreach(DataRow item in data.Rows)
            {
                MenuDish menuDish = new MenuDish(item);
                list.Add(menuDish);
            }
            return list;
        }
        //Them ma hoa don bang cau count 
        public string BILLID()
        {
            string query = "SELECT COUNT(*) FROM HOADON";
            int data = DataProvider.ExecuteScalarCommand(query, null);
            data += 1;
            string billID = string.Format("HD" + data);
            return billID;
        }
        //Them vao hoa don
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
        //Lay ra ma hoa don cao nhat +1 de them vao hoa don moi
        public int BILLMAXID()
        {
            string query = "SELECT COUNT(*) FROM HOADON";
            int billID = DataProvider.ExecuteScalarCommand(query, null);
            return billID+1;
        }
        //them vao chi tiet hoa don
        public void ADDBILLINFO(string masp,int kichthuoc,string soluong)
        {
            int BillID = BILLMAXID() - 1;
            string MAHD = string.Format("HD{0}",BillID);
            string query = "INSERT INTO CHITIETHOADON(MAHD,MASP,KICHTHUOC,SOLUONG,TRANGTHAI) VALUES(@MAHD,@MASP,@KICHTHUOC,@SOLUONG,1)";
            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@MAHD", MAHD);
            parameters[1] = new SqlParameter("@MASP",masp);
            parameters[2] = new SqlParameter("@KICHTHUOC", kichthuoc);
            parameters[3] = new SqlParameter("@SOLUONG", soluong);
            DataProvider.ExecuteInsertCommand(query, parameters);
        }
        //Lay ra ma san pham tu ten san pham
        public string ProductID(string tensp)
        {
            string ID;
            string query =string.Format("SELECT MASANPHAM FROM SANPHAM WHERE TENSANPHAM = N'{0}'",tensp);
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);
            foreach(DataRow row in data.Rows)
            {
               ID = row["MASANPHAM"].ToString();
               return ID;
            }
            return null;
        }
        public bool CheckHD(int Maban)
        {
            string query = string.Format("SELECT COUNT(*) FROM HOADON WHERE SOBAN = {0} AND TRANGTHAI=1", Maban);
            int count = DataProvider.ExecuteScalarCommand(query, null);
            return (count > 0 ? false : true);
        }
    }
}
