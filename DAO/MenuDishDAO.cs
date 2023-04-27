using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
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
    }
}
