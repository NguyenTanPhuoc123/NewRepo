using frmLogin.Data_Tranfer_Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmLogin.Data_Access_Layer
{
    public class PositionDAF
    {
        private static PositionDAF instance;
        public static PositionDAF Instance
        {
            get { if (instance == null) instance = new PositionDAF(); return PositionDAF.instance; }
            private set { PositionDAF.instance = value; }
        }

        private PositionDAF()
        {

        }
        public Position GetPositionName(int id)
        {
            DataTable data = DataProvider.ExcecuteSelectCommand("Select * from CHUCVU where MACHUCVU = "+ id,null);

            foreach (DataRow item in data.Rows)
            {
                return new Position(item);
            }

            return null;
        }
    }
}
