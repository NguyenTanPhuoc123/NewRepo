using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class EmployeeDAO
    {
        private static EmployeeDAO instance;
        public static EmployeeDAO Instance
        {
            get { if (instance == null) instance = new EmployeeDAO(); return EmployeeDAO.instance; }
            private set { EmployeeDAO.instance = value; }
        }

        private EmployeeDAO()
        {

        }

        public Employee GetEmployeeByEmployeeID(int employeeID)
        {
            string query = string.Format("Select * from NHANVIEN WHERE MANV = {0}", employeeID);
            DataTable data = DataProvider.ExcecuteSelectCommand(query, null);

            foreach (DataRow item in data.Rows)
            {
                return new Employee(item);
            }
            return null;
        }

        public int UpdateEmployeeInFo(int employeeID, string SDT, string NgaySinh, string GioiTinh, string DiaChi)
        {
            string query = string.Format("UPDATE NHANVIEN SET SODIENTHOAI='{1}',NGAYSINH='{2}',GIOITINH=N'{3}',DIACHI=N'{4}' WHERE MANV = {0}", employeeID, SDT, NgaySinh, GioiTinh, DiaChi);
            int data = DataProvider.ExecuteInsertCommand(query, null);
            return data;
        }

        public int DeleteEmployeeInfo(int employeeID)
        {
            string query = string.Format("update nhanvien set trangthai = 0 where manv = '{0}'", employeeID);
            int data = DataProvider.ExecuteInsertCommand(query, null);
            return data;
        }

        public int UpdateEmployee(int employeeID, string employeeName, string ngaySinh, string gioiTinh, string soDienThoai, string diaChi)
        {
            string query = string.Format("update nhanvien set TENNV=N'{1}', NGAYSINH='{2}', GIOITINH=N'{3}', SODIENTHOAI='{4}', DIACHI=N'{5}' where MANV={0}", employeeID, employeeName, ngaySinh, gioiTinh, soDienThoai, diaChi);
            int data = DataProvider.ExecuteInsertCommand(query, null);
            return data;
        }

        public int AddEmployee(string tennv, string ngaysinh, string gioitinh, string ngayvaolam, int chucvu, string sdt, string diachi)
        {
            string query = string.Format("insert NHANVIEN(TenNV,NGAYSINH,GIOITINH,NGAYVAOLAM,MACHUCVU,SODIENTHOAI,DIACHI,TRANGTHAI) values(N'{0}', '{1}', N'{2}', '{3}', N'{4}', '{5}', N'{6}', 1)", tennv, ngaysinh, gioitinh, ngayvaolam, chucvu, sdt, diachi);
            int data = DataProvider.ExecuteInsertCommand(query, null);
            return data;
        }

        public int GetEmployeeIDMax()
        {
            int ID = 0;
            int id = DataProvider.ExecuteScalarCommand("select max(manv) from nhanvien", null);
            if (id != null)
            {
                ID = id;
            }
            return ID + 1;
        }

        public int DeleteAllEmployee()
        {
            string query = "update nhanvien set trangthai = 0";
            int data = DataProvider.ExecuteInsertCommand(query, null);
            return data;
        }
    }
}
