using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace frmLogin.Data_Tranfer_Object
{
    public class NhanVien
    {
        private int maNV;
        private string tenNV;
        private string ngaySinh;
        private bool gioiTinh;
        private string ngayVaoLam;
        private int maChucVu;
        private string soDienThoai;
        private string diaChi;
        private bool trangThai;

        public int MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public bool GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string NgayVaoLam { get => ngayVaoLam; set => ngayVaoLam = value; }
        public int MaChucVu { get => maChucVu; set => maChucVu = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public bool TrangThai { get => trangThai; set => trangThai = value; }

        public NhanVien(DataRow row)
        {
            this.maNV = (int)row["MANV"];
            this.TenNV = row["TENNV"].ToString();
            this.ngaySinh = row["NGAYSINH"].ToString();
            this.gioiTinh = (bool)row["GIOITINH"];
            this.ngayVaoLam = row["NGAYVAOLAM"].ToString();
            this.maChucVu = (int)row["CHUCVU"];
            this.soDienThoai = row["SODIENTHOAI"].ToString();
            this.diaChi = row["DIACHI"].ToString();
            this.trangThai = (bool)row["TRANGTHAI"];
        }
    }
}
