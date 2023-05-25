using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class TypeAccountDAO
    {
        private static TypeAccountDAO instance;
        public static TypeAccountDAO Instance
        {
            get { if (instance == null) instance = new TypeAccountDAO(); return TypeAccountDAO.instance; }
            private set { TypeAccountDAO.instance = value; }
        }

        private TypeAccountDAO()
        {

        }

        public TypeAccount GetTypeAccountForTypeAccountID(int typeAccountID)
        {
            string query = string.Format("Select * from LOAITAIKHOAN Where MALOAI = {0} ", typeAccountID);
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);

            foreach (DataRow item in data.Rows)
            {
                return new TypeAccount(item);
            }

            return null;
        }

        public List<TypeAccount> GetListTypeAccount()
        {
            List<TypeAccount> type = new List<TypeAccount>();
            string query = "select * from loaitaikhoan where xoa=0";
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);
            foreach (DataRow item in data.Rows)
            {
                TypeAccount typeacc = new TypeAccount(item);
                type.Add(typeacc);
            }
            return type;
        }

        public int AddTypeAccount(string tenloai)
        {
            string query = string.Format("insert LoaiTaiKhoan(tenloai,xoa) values(N'{0}',0)", tenloai);
            int data = DataProvider.ExecuteInsertCommand(query, null);
            return data;
        }

        public int GetTypeAccountIDMax()
        {
            int ID = 0;
            int id = DataProvider.ExecuteScalarCommand("select max(MALOAI) from LOAITAIKHOAN", null);
            if (id != null)
            {
                ID = id;
            }
            return ID + 1;
        }

        public int UpdateTypeAccount(int maloai, string tenloai)
        {
            string query = string.Format("update LOAITAIKHOAN set TENLOAI=N'{0}' where MALOAI={1}", tenloai, maloai);
            int data = DataProvider.ExecuteInsertCommand(query, null);
            return data;
        }

        public int DeleteTypeAccount(int maloai)
        {
            string query = string.Format("update LOAITAIKHOAN set xoa = 1 where MALOAI={0}", maloai);
            int data = DataProvider.ExecuteInsertCommand(query, null);
            return data;
        }

        public int DeleteAllTypeAccount()
        {
            string query = string.Format("update LOAITAIKHOAN set xoa = 1");
            int data = DataProvider.ExecuteInsertCommand(query, null);
            return data;
        }

        public List<TypeAccount> GetListTypeAccountDelete()
        {
            List<TypeAccount> type = new List<TypeAccount>();
            string query = "select * from loaitaikhoan where xoa=1";
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);
            foreach (DataRow item in data.Rows)
            {
                TypeAccount typeacc = new TypeAccount(item);
                type.Add(typeacc);
            }
            return type;
        }

        public int RestoreTypeAccount(int maloai)
        {
            string query = string.Format("update LOAITAIKHOAN set xoa = 0 where MALOAI={0}", maloai);
            int data = DataProvider.ExecuteInsertCommand(query, null);
            return data;
        }

        public int RestoreAllTypeAccount()
        {
            string query = string.Format("update LOAITAIKHOAN set xoa = 0");
            int data = DataProvider.ExecuteInsertCommand(query, null);
            return data;
        }
        public bool checkNameExist(string tenloai)
        {
            string query = string.Format("Select count(*) from LOAITAIKHOAN where tenloai={0}", tenloai);
            int data  = DataProvider.ExecuteScalarCommand(query, null);
            return data>0?false:true;
        }
        public bool checkExistDelete(string maloai)
        {
            string query = string.Format("Select count(*) from taikhoan where loaitaikhoan='{0}'", maloai);
            int data = DataProvider.ExecuteScalarCommand(query, null);
            return data > 0 ? false : true;
        }


    }
}
