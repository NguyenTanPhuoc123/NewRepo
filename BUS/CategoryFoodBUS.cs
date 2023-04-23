using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CategoryFoodBUS
    {
        private static CategoryFoodBUS instance;
        public static CategoryFoodBUS Instance
        {
            get { if (instance == null) instance = new CategoryFoodBUS(); return CategoryFoodBUS.instance; }
            private set { CategoryFoodBUS.instance = value; }
        }
        public List<CategoryFood> GetCategoryFoods()
        {
            return CategoryFoodDAO.Instance.GetCategoryFoods();
        }
    }
}
