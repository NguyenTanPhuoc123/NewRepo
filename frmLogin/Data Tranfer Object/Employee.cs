using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace frmLogin.Data_Tranfer_Object
{
    public class Employee
    {
        private int maNV;
        private string tenNV;
        private string ngaySinh;
        private string gioiTinh;
        private string ngayVaoLam;
        private int maChucVu;
        private string soDienThoai;
        private string diaChi;
        private int trangThai;
        private string tenChucVu;

        public int MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }   
        public int MaChucVu { get => maChucVu; set => maChucVu = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }
        public string TenChucVu { get => tenChucVu; set => tenChucVu = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string NgayVaoLam { get => ngayVaoLam; set => ngayVaoLam = value; }

     

        public Employee(DataRow row)
        {
            this.maNV = (int)row["MANV"];
            this.TenNV = row["TENNV"].ToString();
            this.ngaySinh = row["NGAYSINH"].ToString();
            this.gioiTinh = row["GIOITINH"].ToString();
            this.ngayVaoLam = row["NGAYVAOLAM"].ToString();
            this.maChucVu = (int)row["MACHUCVU"];
            this.soDienThoai = row["SODIENTHOAI"].ToString();
            this.diaChi = row["DIACHI"].ToString();
            this.tenChucVu = row["TENCHUCVU"].ToString();
        }

        public Employee(int maNV, string tenNV, string ngaySinh, string gioiTinh, string ngayVaoLam, int maChucVu, string soDienThoai, string diaChi, int trangThai, string tenChucVu)
        {
            this.maNV = maNV;
            this.tenNV = tenNV;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.ngayVaoLam = ngayVaoLam;
            this.maChucVu = maChucVu;
            this.soDienThoai = soDienThoai;
            this.diaChi = diaChi;
            this.trangThai = trangThai;
            this.tenChucVu = tenChucVu;
        }
    }
}
