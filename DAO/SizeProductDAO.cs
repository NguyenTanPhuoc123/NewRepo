using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class SizeProductDAO
    {
        private static SizeProductDAO instance;
        public static SizeProductDAO Instance
        {
            get { if (instance == null) instance = new SizeProductDAO(); return SizeProductDAO.instance; }
            private set { SizeProductDAO.instance = value; }
        }

        private SizeProductDAO()
        {

        }

        public List<SizeProduct> GetListSizeProduct()
        {
            List<SizeProduct> list = new List<SizeProduct>();
            string query = "Select * from KICHTHUOC where TRANGTHAI = 1";
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);

            foreach(DataRow item in data.Rows)
            {
                SizeProduct sizeProduct = new SizeProduct(item);
                list.Add(sizeProduct);
            }
            return list;
        }

        public int GetListSizeIDMax()
        {
            int sizeID = 0;
            int id = DataProvider.ExecuteScalarCommand("Select MAX(MAKICHTHUOC) from KICHTHUOC", null);
            if (id >0)
                sizeID = id;

            return sizeID+1;
        }

        public int AddSizeProduct(string sizeName, float sizePrice)
        {
            string query = string.Format("Insert KICHTHUOC(TENKICHTHUOC,GIA,TRANGTHAI) values(N'{0}',{1},1)", sizeName, sizePrice);
            int row = 0;
            row = DataProvider.ExecuteInsertCommand(query, null);
            return row;       
        }

        public int EditSizeProduct(int sizeID,string sizeName, float sizePrice)
        {
            string query = string.Format("Update KICHTHUOC SET TENKICHTHUOC = N'{0}' , GIA = {1} WHERE MAKICHTHUOC = {2}", sizeName, sizePrice, sizeID);
            int row = 0;
            row = DataProvider.ExecuteInsertCommand(query, null);
            return row;
        }

        public int DeleteSizeProduct(int sizeID)
        {
            string query = string.Format("Update KICHTHUOC SET TRANGTHAI = 0  WHERE MAKICHTHUOC = {0}",sizeID);
            int row = 0;
            row = DataProvider.ExecuteInsertCommand(query, null);
            return row;
        }

        public int DeleteAllSizeProduct()
        {
            string query = string.Format("Update KICHTHUOC SET TRANGTHAI = 0  ");
            int row = 0;
            row = DataProvider.ExecuteInsertCommand(query, null);
            return row;
        }

    }
}
