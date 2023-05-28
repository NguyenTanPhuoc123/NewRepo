using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        public List<CategoryFood> GetCategoryFoodsID()
        {
            List<CategoryFood> listCategoryFood = new List<CategoryFood>();
            DataTable data = DataProvider.ExcecuteSelectCommand("Select * from DANHMUC", null);
            foreach (DataRow item in data.Rows)
            {
                CategoryFood categoryFood = new CategoryFood(item);
                listCategoryFood.Add(categoryFood);
            }
            return listCategoryFood;
        }
        public List<CategoryFood> GetCategoryFoodsDeleted()
        {
            List<CategoryFood> listCategoryFood = new List<CategoryFood>();
            DataTable data = DataProvider.ExcecuteSelectCommand("Select * from DANHMUC where xoa=1", null);
            foreach (DataRow item in data.Rows)
            {
                CategoryFood categoryFood = new CategoryFood(item);
                listCategoryFood.Add(categoryFood);
            }
            return listCategoryFood;
        }
        public int AddCategoryFood(string name)
        {
            int row;
            string query = "INSERT INTO DANHMUC VALUES(@TENDANHMUC,0)";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@TENDANHMUC", name);
            row = DataProvider.ExecuteInsertCommand(query, parameters);
            return row;
        }
        public int UpdateCategoryFood(string id, string name)
        {
            int row;
            string query = "UPDATE DANHMUC SET TENDANHMUC=@TENDANHMUC WHERE MADANHMUC=@DANHMUC";
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@DANHMUC", id);
            parameters[1] = new SqlParameter("@TENDANHMUC", name);
            row = DataProvider.ExecuteInsertCommand(query, parameters);
            return row;
        }
        public int DeleteCategoryFood(string id)
        {
            int row;
            string query = "UPDATE DANHMUC SET XOA=1 WHERE MADANHMUC=@DANHMUC";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@DANHMUC", id);
            row = DataProvider.ExecuteInsertCommand(query, parameters);
            return row;
        }
        public int DeleteAllCategoryFood()
        {
            int row;
            string query = "UPDATE DANHMUC SET XOA=1";
            row = DataProvider.ExecuteInsertCommand(query, null);
            return row;
        }
        public int RestoreAllCategoryFood()
        {
            int row;
            string query = "UPDATE DANHMUC SET XOA=0";
            row = DataProvider.ExecuteInsertCommand(query, null);
            return row;
        }
        public int RestoreCategoryFood(string id)
        {
            int row;
            string query = "UPDATE DANHMUC SET XOA=0 WHERE MADANHMUC=@DANHMUC";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@DANHMUC", id);
            row = DataProvider.ExecuteInsertCommand(query, parameters);
            return row;
        }
        public string GetCategory(int CategoryID)
        {
            string query = string.Format("Select TENDANHMUC from DANHMUC where MADANHMUC = {0}", CategoryID);
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);
            foreach (DataRow item in data.Rows)
            {
                string TENDANHMUC = item["TENDANHMUC"].ToString();
                return TENDANHMUC;
            }
            return null;
        }
        public List<CategoryFood> GetFillCategoryFoods(int CategoryID)
        {
            string query = string.Format("Select * from DANHMUC where xoa = 0 and madanhmuc = {0}",CategoryID);
            List <CategoryFood> listCategoryFood = new List<CategoryFood>();
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);
            foreach (DataRow item in data.Rows)
            {
                CategoryFood categoryFood = new CategoryFood(item);
                listCategoryFood.Add(categoryFood);
            }
            return listCategoryFood;
        }
        public bool checkNameExist( string CategoryName)
        {
            string query = string.Format("Select count(*) from DANHMUC where TENDANHMUC=N'{0}'",  CategoryName);
            int data = DataProvider.ExecuteScalarCommand(query, null);
            return data > 0 ? false : true;
        }
        public bool checkNameExist(string CategoryName ,string ID)
        {
            string query = string.Format("Select count(*) from DANHMUC where TENDANHMUC=N'{0}' and madanhmuc !={1}", CategoryName,ID);
            int data = DataProvider.ExecuteScalarCommand(query, null);
            return data > 0 ? false : true;
        }
        public bool checkExistDelete(string CategoryID)
        {
            string query = string.Format("Select count(*) from SANPHAM where DANHMUC={0}", CategoryID);
            int data = DataProvider.ExecuteScalarCommand(query, null);
            return data > 0 ? false : true;
        }
    }
}
