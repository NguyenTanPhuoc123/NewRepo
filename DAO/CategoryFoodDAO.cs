using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CategoryFoodDAO
    {
        private static CategoryFoodDAO instance;

        public static CategoryFoodDAO Instance
        {
            get { if (instance == null) instance = new CategoryFoodDAO(); return CategoryFoodDAO.instance; }
            private set { CategoryFoodDAO.instance = value; }
        }

        private CategoryFoodDAO()
        {

        }

        public List<CategoryFood> GetCategoryFoods()
        {
            List<CategoryFood> listCategoryFood = new List<CategoryFood>();
            DataTable data = DataProvider.ExcecuteSelectCommand("Select * from DANHMUC where xoa=0", null);
            foreach (DataRow item in data.Rows)
            {
                CategoryFood categoryFood = new CategoryFood(item);
                listCategoryFood.Add(categoryFood);
            }
            return listCategoryFood;
        }
    }
}
