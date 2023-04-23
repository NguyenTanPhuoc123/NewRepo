using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TypeCustomer
    {
        private int m_typeID;
        private string m_typeName;

        public TypeCustomer(int typeID, string typeName)
        {
            m_typeID = typeID;
            m_typeName = typeName;
        }

        public int TypeID { get => m_typeID; set => m_typeID = value; }
        public string TypeName { get => m_typeName; set => m_typeName = value; }

        public TypeCustomer(DataRow row)
        {
            this.m_typeID = (int)row["MaLoai"];
            this.m_typeName = row["TenLoai"].ToString();
        }
    }
}
