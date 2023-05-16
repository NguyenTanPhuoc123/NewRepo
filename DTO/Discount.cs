using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Discount
    {
        private string m_DiscountID;
        private string m_DiscountName;
        private string m_StartDay;
        private string m_EndDay;
        private float m_Price;
        private bool m_Available;
        private float m_Limit;

        public Discount(string discountID, string discountName, string startDay, string endDay, float price, bool available, float limit)
        {
            m_DiscountID = discountID;
            m_DiscountName = discountName;
            m_StartDay = startDay;
            m_EndDay = endDay;
            m_Price = price;
            m_Available = available;
            m_Limit = limit;
        }


        public string DiscountID { get => m_DiscountID; set => m_DiscountID = value; }
        public string DiscountName { get => m_DiscountName; set => m_DiscountName = value; }
        public string StartDay { get => m_StartDay; set => m_StartDay = value; }
        public string EndDay { get => m_EndDay; set => m_EndDay = value; }
        public float Price { get => m_Price; set => m_Price = value; }
        public bool Available { get => m_Available; set => m_Available = value; }
        public float Limit { get => m_Limit; set => m_Limit = value; }

        public Discount(DataRow row)
        {
            this.m_DiscountID = row["MAGIAM"].ToString();
            this.m_DiscountName = row["TENGIAMGIA"].ToString();
            this.m_Price = float.Parse(row["DONGIA"].ToString());
            this.m_StartDay = row["NgayBatDau"].ToString();
            this.m_EndDay = row["NgayKetThuc"].ToString();
            this.m_Available = (bool) row["HoatDong"];
            this.m_Limit = float.Parse(row["HANMUC"].ToString());
        }

       
    } 
}
