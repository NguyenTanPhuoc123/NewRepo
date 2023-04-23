using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class LocationBUS
    {
        private static LocationBUS instance;
        public static LocationBUS Instance
        {
            get { if (instance == null) instance = new LocationBUS(); return LocationBUS.instance; }
            private set { LocationBUS.instance = value; }
        }

        private LocationBUS()
        {

        }
        public List<Location> GetListLocation()
        {
            return LocationDAO.Instance.GetListLocation();
        }

        public int AddLocationTable(string name)
        {
            return LocationDAO.Instance.AddLocationTable(name);
        }

        public int UpdateLocationTable(int id, string name)
        {
            return LocationDAO.Instance.UpdateLocationTable(id, name);
        }

        public int DeleteLocationTable(int id)
        {
            return LocationDAO.Instance.DeleteLocationTable(id);
        }

        public int DeleteAllLocationTable()
        {
            return LocationDAO.Instance.DeleteAllLocationTable();
        }

        public int GetLocationIDMax()
        {
            return LocationDAO.Instance.GetLocationIDMax();
        }
    }
}
