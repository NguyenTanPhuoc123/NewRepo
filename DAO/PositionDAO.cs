using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class PositionDAO
    {
        private static PositionDAO instance;
        public static PositionDAO Instance
        {
            get { if (instance == null) instance = new PositionDAO(); return PositionDAO.instance; }
            private set { PositionDAO.instance = value; }
        }

        private PositionDAO()
        {

        }
        public Position GetPositionName(int id)
        {
            DataTable data = DataProvider.ExcecuteSelectCommand("Select * from CHUCVU where MACHUCVU = " + id, null);

            foreach (DataRow item in data.Rows)
            {
                return new Position(item);
            }

            return null;
        }

        public List<Position> GetListPosition()
        {
            List<Position> listPosition = new List<Position>();
            string query = string.Format("Select * from CHUCVU");
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);

            foreach (DataRow item in data.Rows)
            {
                Position employee = new Position(item);
                listPosition.Add(employee);
            }
            return listPosition;
        }
    }
}
