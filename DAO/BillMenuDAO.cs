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
        
   }
}
