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
    }
}
