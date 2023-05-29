using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class TypeAccountBUS
    {
        private static TypeAccountBUS instance;
        public static TypeAccountBUS Instance
        {
            get { if (instance == null) instance = new TypeAccountBUS(); return TypeAccountBUS.instance; }
            private set { TypeAccountBUS.instance = value; }
        }

        private TypeAccountBUS()
        {

        }

        public TypeAccount GetTypeAccountForTypeAccountID(int typeAccountID)
        {
            return TypeAccountDAO.Instance.GetTypeAccountForTypeAccountID(typeAccountID);
        }

        public List<TypeAccount> GetListTypeAccount()
        {
            return TypeAccountDAO.Instance.GetListTypeAccount();
        }

        public int AddTypeAccount(string tenloai)
        {
            return TypeAccountDAO.Instance.AddTypeAccount(tenloai);
        }

        public int UpdateTypeAccount(int maloai, string tenloai)
        {
            return TypeAccountDAO.Instance.UpdateTypeAccount(maloai, tenloai);
        }

        public int DeleteTypeAccount(int maloai)
        {
            return TypeAccountDAO.Instance.DeleteTypeAccount(maloai);
        }

        public int DeleteAllTypeAccount()
        {
            return TypeAccountDAO.Instance.DeleteAllTypeAccount();
        }

        public int RestoreTypeAccount(int maloai)
        {
            return TypeAccountDAO.Instance.RestoreTypeAccount(maloai);
        }

        public int RestoreAllTypeAccount()
        {
            return TypeAccountDAO.Instance.RestoreAllTypeAccount();
        }

        public List<TypeAccount> GetListTypeAccountDelete()
        {
            return TypeAccountDAO.Instance.GetListTypeAccountDelete();
        }

        public int GetTypeAccountIDMax()
        {
            return TypeAccountDAO.Instance.GetTypeAccountIDMax();
        }
        public bool checkNameExist(string tenloai)
        {
            return TypeAccountDAO.Instance.checkNameExist(tenloai);
        }
        public bool checkNameExist(string tenloai, string id)
        {
            return TypeAccountDAO.Instance.checkNameExist(tenloai,id);
        }
        public bool checkExistDelete(string maloai)
        {
            return TypeAccountDAO.Instance.checkExistDelete(maloai);
        }
        public bool checkExistDelete()
        {
            return TypeAccountDAO.Instance.checkExistDelete();
        }
    }
}
