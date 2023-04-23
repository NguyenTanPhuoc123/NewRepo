using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CategoryFoodDTO
    {
        private int m_categoryID;
        private string m_categoryName;


        public int CategoryID { get => m_categoryID; set => m_categoryID = value; }
        public string CategoryName { get => m_categoryName; set => m_categoryName = value; }

        public CategoryFoodDTO(int categoryID, string categoryName)
        {
            m_categoryID = categoryID;
            m_categoryName = categoryName;
        }

        public CategoryFoodDTO(DataRow row)
        {
            this.m_categoryID = (int)row["MADANHMUC"];
            this.m_categoryName = row["TENDANHMUC"].ToString();
        }
    }
}
