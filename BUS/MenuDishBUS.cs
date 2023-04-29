using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class MenuDishBUS
    {
        private static MenuDishBUS instance;
        public static MenuDishBUS Instance
        {
            get { if (instance == null) instance = new MenuDishBUS(); return MenuDishBUS.instance; }
            private set { MenuDishBUS.instance = value; }
        }

        private MenuDishBUS()
        {

        }

        public List<MenuDish> GetListMenuDishByTableID(int tableID)
        {
            return MenuDishDAO.Instance.GetListMenuDishByTableID(tableID);
        }
        public bool ADDBILL(int tableID)
        {
            return MenuDishDAO.Instance.ADDBILL(tableID);
        }
        public void ADDBILLINFO(string masp, int kichthuoc, string soluong)
        {
           MenuDishDAO.Instance.ADDBILLINFO(masp,kichthuoc,soluong);
        }
        public string ProductID(string tensp)
        {
            return MenuDishDAO.Instance.ProductID(tensp);
        }
        public bool CheckHD(int Maban)
        {
            return MenuDishDAO.Instance.CheckHD(Maban);
        }
    }
}
