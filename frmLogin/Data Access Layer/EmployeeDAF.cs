using frmLogin.Data_Tranfer_Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public List<Employee> GetListEmployee()
        {
            List<Employee> listEmployee = new List<Employee>();
            string query = string.Format("Select * from NHANVIEN");
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);

            foreach (DataRow item in data.Rows)
            {
                Employee employee = new Employee(item);
                listEmployee.Add(employee);
            }
            return listEmployee;
        }

        public int UpdateEmployeeInFo(int employeeID,string SDT,string NgaySinh,string GioiTinh,string DiaChi)
        {
            string query = string.Format("UPDATE NHANVIEN SET SODIENTHOAI='{1}',NGAYSINH='{2}',GIOITINH=N'{3}',DIACHI=N'{4}' WHERE MANV = {0}", employeeID,SDT,NgaySinh,GioiTinh,DiaChi);
            int data = DataProvider.ExecuteInsertCommand(query, null);
            return data;
        }
       
    }
}
