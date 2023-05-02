using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MenuDish
    {
        private string m_DishName;
        private int m_Count;
        private float m_Price;
        private float m_TotalPrice;

        public MenuDish(string dishName, int count, float price, float totalPrice)
        {
            m_DishName = dishName;
            m_Count = count;
            m_Price = price;
            m_TotalPrice = totalPrice;
        }

        public string DishName { get => m_DishName; set => m_DishName = value; }
        public int Count { get => m_Count; set => m_Count = value; }
        public float Price { get => m_Price; set => m_Price = value; }
        public float TotalPrice { get => m_TotalPrice; set => m_TotalPrice = value; }

        public MenuDish(DataRow row)
        {
            this.m_DishName = row["TENSANPHAM"].ToString();
            this.m_Count = (int)row["SOLUONG"];
            this.m_Price = float.Parse(row["DONGIA"].ToString());
            this.m_TotalPrice = float.Parse(row["THANHTIEN"].ToString());
        }
    }
}
