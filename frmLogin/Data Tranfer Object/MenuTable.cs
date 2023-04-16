using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmLogin.Data_Tranfer_Object
{
    public class MenuTable
    {
        private string tenSP;
        private string kichThuoc;
        private int soLuong;
        private float donGia;
        private float tongTien;

        public MenuTable(string tenSP, string kichThuoc, int soLuong, float donGia, float tongTien)
        {
            this.TenSP = tenSP;
            this.KichThuoc = kichThuoc;
            this.SoLuong = soLuong;
            this.DonGia = donGia;
            this.TongTien = tongTien;
        }

        public string TenSP { get => tenSP; set => tenSP = value; }
        public string KichThuoc { get => kichThuoc; set => kichThuoc = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public float DonGia { get => donGia; set => donGia = value; }
        public float TongTien { get => tongTien; set => tongTien = value; }

        public MenuTable(DataRow row)
        {
            this.tenSP = row["TENSANPHAM"].ToString();
            this.kichThuoc = row["TENKICHTHUOC"].ToString();
            this.soLuong = (int)row["SOLUONG"];
            this.donGia = float.Parse(row["DONGIA"].ToString());
            this.tongTien = float.Parse(row["TONGTIEN"].ToString());
        }
    }
}
