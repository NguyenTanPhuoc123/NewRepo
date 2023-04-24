using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CustomerMenu
    {
        private string m_ID;
        private string m_Name;
        private string m_Phone;
        private int m_TypeID;
        private string m_TypeName;
        private string m_Gender;

        public CustomerMenu(string iD, string name, string phone, int typeID, string typeName, string gender)
        {
            m_ID = iD;
            m_Name = name;
            m_Phone = phone;
            m_TypeID = typeID;
            m_TypeName = typeName;
            m_Gender = gender;
        }

        public string ID { get => m_ID; set => m_ID = value; }
        public string Name { get => m_Name; set => m_Name = value; }
        public string Phone { get => m_Phone; set => m_Phone = value; }
        public int TypeID { get => m_TypeID; set => m_TypeID = value; }
        public string TypeName { get => m_TypeName; set => m_TypeName = value; }
        public string Gender { get => m_Gender; set => m_Gender = value; }

        public CustomerMenu(DataRow row)
        {
            this.m_ID = row["MAKH"].ToString();
            this.m_Name = row["TENKH"].ToString();
            this.m_Phone = row["SODIENTHOAI"].ToString();
            this.m_TypeID = (int)row["LOAIKH"];
            this.m_TypeName = row["TenLoai"].ToString();
            this.m_Gender = row["GioiTinh"].ToString();
        }
    }
}
