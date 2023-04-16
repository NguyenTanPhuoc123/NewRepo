using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using frmLogin.Data_Tranfer_Object;

namespace frmLogin.Data_Access_Layer
{
    public class MenuDAF
    {
        private static MenuDAF instance;
        public static MenuDAF Instance
        {
            get { if (instance == null) instance = new MenuDAF(); return MenuDAF.instance; }
            private set { MenuDAF.instance = value; }
        }
        public List<MenuTable> GetListMenu(int TableID)
        {
            List<MenuTable> lst = new List<MenuTable>();
            string query =string.Format("select a.TENSANPHAM,c.SOLUONG,a.DONGIA,d.TENKICHTHUOC,c.SOLUONG*a.DONGIA 'TONGTIEN'from SANPHAM a,HOADON b,CHITIETHOADON c,KICHTHUOC d WHERE  a,TENSANPHAM = c.TENSANPHAM AND b.MAHD =c.MAHD AND d.MAKICHTHUOC = c.KICHTHUOC AND b.SOBAN = ", TableID);
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);
            foreach (DataRow item in data.Rows)
            {
                MenuTable acc = new MenuTable(item);
                lst.Add(acc);
            }
            return lst;
        }

    }
}
