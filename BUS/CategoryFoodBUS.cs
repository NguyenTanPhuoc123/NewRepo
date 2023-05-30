using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
        public List<CategoryFood> GetCategoryFoodsDeleted()
        {
            return CategoryFoodDAO.Instance.GetCategoryFoodsDeleted();
        }
        public List<CategoryFood> GetCategoryFoodsID()
        {
            return CategoryFoodDAO.Instance.GetCategoryFoodsID();
        }
        public int AddCategoryFood(string name)
        {
            return CategoryFoodDAO.Instance.AddCategoryFood(name);
        }
        public int UpdateCategoryFood(string id, string name)
        {
            return CategoryFoodDAO.Instance.UpdateCategoryFood(id, name);
        }
        public int DeleteCategoryFood(string id)
        {
            return CategoryFoodDAO.Instance.DeleteCategoryFood(id);
        }
        public int DeleteAllCategoryFood()
        {
            return CategoryFoodDAO.Instance.DeleteAllCategoryFood();
        }
        public int RestoreCategoryFood(string id)
        {
            return CategoryFoodDAO.Instance.RestoreCategoryFood(id);
        }
        public int RestoreAllCategoryFood()
        {
            return CategoryFoodDAO.Instance.RestoreAllCategoryFood();
        }
        public string GetCategory(int CategoryID)
        {
            return CategoryFoodDAO.Instance.GetCategory(CategoryID);
        }
        public List<CategoryFood> GetFillCategoryFoods(int CategoryID)
        {
            return CategoryFoodDAO.Instance.GetFillCategoryFoods(CategoryID);
        }
        public bool checkNameExist(string CategoryName)
        {
            return CategoryFoodDAO.Instance.checkNameExist(CategoryName);
        }
        public bool checkNameExist(string CategoryName, string ID)
        {
            return CategoryFoodDAO.Instance.checkNameExist(CategoryName,ID);
        }
        public bool checkExistDelete(string CategoryID)
        {
            return CategoryFoodDAO.Instance.checkExistDelete(CategoryID);
        }
        public bool checkExistDelete()
        {
            return CategoryFoodDAO.Instance.checkExistDelete();
        }
    }
}
