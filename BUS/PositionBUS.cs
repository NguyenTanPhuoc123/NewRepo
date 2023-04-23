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
    }
}
