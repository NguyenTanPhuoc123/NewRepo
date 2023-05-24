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
        public bool CheckNumberPhone(string phone, string ID)
        {
            int outputNum;
            if (phone.Length > 11 || phone.Length < 10 || !int.TryParse(phone, out outputNum)) 
                return false;

            if (!phone.StartsWith("0"))
                return false;

            string query = string.Format("SELECT COUNT(MANV) FROM NHANVIEN WHERE SODIENTHOAI = {0} and MANV != {1}", phone, ID);
            int row = DataProvider.ExecuteScalarCommand(query, null);
            if (row > 0)
                return false;

            return true;
        }

        public bool CheckNumberPhoneCreate(string phone)
        {
            int outputNum;
            if (phone.Length > 11 || phone.Length < 10 ||!int.TryParse(phone, out outputNum))
                return false;

            if (!phone.StartsWith("0"))
                return false;

            string query = string.Format("SELECT COUNT(MANV) FROM NHANVIEN WHERE SODIENTHOAI = {0}", phone);
            int row = DataProvider.ExecuteScalarCommand(query, null);
            if (row > 0)
                return false;

            return true;
        }

        public bool CheckAge(DateTime BirthYear)
        {
            List<EmployeeMenu> employees = EmployeeMenuDAO.Instance.GetListEmployee();
            if (DateTime.Today.Year - BirthYear.Year >= 18)
            {
                return true;
            }
            return false;
        }

        public bool CheckAccountDelete(string employeeName)
        {
            string query = string.Format("select COUNT(a.tendangnhap) from TAIKHOAN a, NHANVIEN b where a.MANV =b.MANV and b.TENNV=N'{0}' and a.TRANGTHAI = 1", employeeName);
            int row = DataProvider.ExecuteScalarCommand(query, null);
            if (row > 0)
                return false;

            return true;
        }

        public bool CheckAccountDeleteAll()
        {
            string query = "select COUNT(a.tendangnhap) from TAIKHOAN a, NHANVIEN b where a.MANV =b.MANV and a.TRANGTHAI = 1";
            int row = DataProvider.ExecuteScalarCommand(query, null);
            if (row > 0)
                return false;

            return true;
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

        public int DeleteAllEmployee()
        {
            string query = "update nhanvien set trangthai = 0";
            int data = DataProvider.ExecuteInsertCommand(query, null);
            return data;
        }

        public int RestoreEmployeeInfo(int employeeID)
        {
            string query = string.Format("update nhanvien set trangthai = 1 where manv = '{0}'", employeeID);
            int data = DataProvider.ExecuteInsertCommand(query, null);
            return data;
        }

        public int RestoreAllEmployee()
        {
            string query = "update nhanvien set trangthai = 1";
            int data = DataProvider.ExecuteInsertCommand(query, null);
            return data;
        }
    }
}
