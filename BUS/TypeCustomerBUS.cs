using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class TypeCustomerBUS
    {
        private static TypeCustomerBUS instance;

        public static TypeCustomerBUS Instance
        {
            get { if (instance == null) instance = new TypeCustomerBUS(); return TypeCustomerBUS.instance; }
            private set { TypeCustomerBUS.instance = value; }
        }

        private TypeCustomerBUS()
        {

        }

        public List<TypeCustomer> GetListTypeCustomer()
        {
            return TypeCustomerDAO.Instance.GetListTypeCustomer();
        }

        public int AddTypeCustomer(string typeName)
        {
            return TypeCustomerDAO.Instance.AddTypeCustomer(typeName);
        }

        public int EditTypeCustomer(int typeID, string typeName)
        {
            return TypeCustomerDAO.Instance.EditTypeCustomer(typeID, typeName);
        }

        public int DeleteTypeCustomer(int typeID)
        {
            return TypeCustomerDAO.Instance.DeleteTypeCustomer(typeID);
        }

        public int DeleteAllTypeCustomer()
        {
            return TypeCustomerDAO.Instance.DeleteAllTypeCustomer();
        }

        public int GetTypeCustomerIDMax()
        {
            return TypeCustomerDAO.Instance.GetTypeCustomerIDMax();
        }

        public List<TypeCustomer> GetListTypeCustomerDeleted()
        {
            return TypeCustomerDAO.Instance.GetListTypeCustomerDeleted();
        }

        public int RestoreTypeCustomer(int typeID)
        {
            return TypeCustomerDAO.Instance.RestoreTypeCustomer(typeID);
        }

        public int RestoreAllTypeCustomer()
        {
            return TypeCustomerDAO.Instance.RestoreAllTypeCustomer();
        }

    }
}
