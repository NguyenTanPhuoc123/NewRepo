using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class EmployeeMenuBUS
    {
        private static EmployeeMenuBUS instance;
        public static EmployeeMenuBUS Instance
        {
            get { if (instance == null) instance = new EmployeeMenuBUS(); return EmployeeMenuBUS.instance; }
            private set { EmployeeMenuBUS.instance = value; }
        }

        private EmployeeMenuBUS()
        {

        }
        public List<EmployeeMenu> GetListEmployee()
        {
            return EmployeeMenuDAO.Instance.GetListEmployee();
        }

        public List<EmployeeMenu> GetListEmployeeDeleted()
        {
            return EmployeeMenuDAO.Instance.GetListEmployeeDeleted();
        }

        public List<Position> GetListPosition()
        {
            return EmployeeMenuDAO.Instance.GetListPosition();
        }

        public List<EmployeeMenu> SearchEmloyeeName(string employeeName)
        {
            return EmployeeMenuDAO.Instance.SearchEmloyeeName(employeeName);
        }

        public List<EmployeeMenu> SortListEmployeeByEmployeeID(int positionID)
        {
            return EmployeeMenuDAO.Instance.SortListEmployeeByEmployeeID(positionID);
        }

        public List<EmployeeMenu> SortListEmployeeByEmployeeName(int positionID)
        {
            return EmployeeMenuDAO.Instance.SortListEmployeeByEmployeeName(positionID);
        }

        public List<EmployeeMenu> FillEmployee(int positionID)
        {
            return EmployeeMenuDAO.Instance.FillEmployee(positionID);
        }
    }
}
