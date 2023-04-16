using frmLogin.Data_Tranfer_Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmLogin.Data_Access_Layer
{
    public class LocationDAF
    {
        private static LocationDAF instance;
        public static LocationDAF Instance
        {
            get { if (instance == null) instance = new LocationDAF(); return LocationDAF.instance; }
            private set { LocationDAF.instance = value; }
        }

        private LocationDAF()
        {

        }
        public List<Location> GetListLocation()
        {
            List<Location> listLocation = new List<Location>();
            string query = "SELECT * FROM VITRI WHERE XOA = 0";
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);
            foreach(DataRow row in data.Rows)
            {
                Location location = new Location(row);
                listLocation.Add(location);
            }
            return listLocation;
        }
    }
}
