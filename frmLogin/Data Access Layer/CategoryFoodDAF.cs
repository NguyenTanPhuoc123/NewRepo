using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using frmLogin.Data_Tranfer_Object;

namespace frmLogin.Data_Access_Layer
{
    public class CategoryFoodDAF
    {
        private static CategoryFoodDAF instance;

        public static CategoryFoodDAF Instance
        {
            get { if (instance == null) instance = new CategoryFoodDAF(); return CategoryFoodDAF.instance; }
            private set { CategoryFoodDAF.instance = value; }
        }

        private CategoryFoodDAF()
        {

        }

        public List<CategoryFood> GetCategoryFoods()
        {
            List<CategoryFood> listCategoryFood = new List<CategoryFood>();
            DataTable data = DataProvider.ExcecuteSelectCommand("Select * from DANHMUC", null);
            foreach(DataRow item in data.Rows)
            {
                CategoryFood categoryFood = new CategoryFood(item);
                listCategoryFood.Add(categoryFood);
            }
            return listCategoryFood;
        }

       
    }
}
