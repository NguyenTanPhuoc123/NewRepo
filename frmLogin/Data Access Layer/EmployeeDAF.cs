using frmLogin.Data_Tranfer_Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmLogin.Data_Access_Layer
{
    public class EmployeeDAF
    {
        private static EmployeeDAF instance;
        public static EmployeeDAF Instance
        {
            get { if (instance == null) instance = new EmployeeDAF(); return EmployeeDAF.instance; }
            private set { EmployeeDAF.instance = value; }
        }

        private EmployeeDAF()
        {

        }

        public Employee GetEmployeeByEmployeeID(int employeeID)
        {
            string query = string.Format("Select * from NHANVIEN WHERE MANV = {0}", employeeID);
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);

            foreach(DataRow item in data.Rows)
            {
                return new Employee(item);
            }
            return null;
        }
    }
}
