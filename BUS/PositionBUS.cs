using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class PositionBUS
    {
        private static PositionBUS instance;
        public static PositionBUS Instance
        {
            get { if (instance == null) instance = new PositionBUS(); return PositionBUS.instance; }
            private set { PositionBUS.instance = value; }
        }

        private PositionBUS()
        {

        }
        public Position GetPositionName(int id)
        {
            return PositionDAO.Instance.GetPositionName(id);
        }

        public List<Position> GetListPosition()
        {
            return PositionDAO.Instance.GetListPosition();
        }

        public int GetPositionIDMax()
        {
            return PositionDAO.Instance.GetPositionIDMax();
        }

        public int AddPosition(string tenchucvu)
        {
            return PositionDAO.Instance.AddPosition(tenchucvu);
        }

        public int UpdatePosition(int macv, string tencv)
        {
            return PositionDAO.Instance.UpdatePosition(macv, tencv);
        }

        public int DeletePosition(int macv)
        {
            return PositionDAO.Instance.DeletePosition(macv);
        }

        public int DeleteAllPosition()
        {
            return PositionDAO.Instance.DeleteAllPosition();
        }

        public List<Position> GetListPositionDeleted()
        {
            return PositionDAO.Instance.GetListPositionDeleted();
        }

        public int RestorePosition(int macv)
        {
            return PositionDAO.Instance.RestorePosition(macv);
        }

        public int RestoreAllPosition()
        {
            return PositionDAO.Instance.RestoreAllPosition();
        }
        public bool checkNameExist( string tenloai)
        {
            return PositionDAO.Instance.checkNameExist( tenloai);
        }
        public bool checkNameExist(string tenloai,string id)
        {
            return PositionDAO.Instance.checkNameExist(tenloai,id);
        }
        public bool checkExistDelete(string maloai)
        {
            return PositionDAO.Instance.checkExistDelete(maloai);
        }
        public bool checkExistDelete()
        {
            return PositionDAO.Instance.checkExistDelete();
        }
    }
}
