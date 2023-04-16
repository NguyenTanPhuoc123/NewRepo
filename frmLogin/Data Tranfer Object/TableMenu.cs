using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmLogin.Data_Tranfer_Object
{
    public class TableMenu
    {
        private int m_MaBanAn;
        private string m_TenBan;
        private int m_MaViTri;
        private string m_TrangThai;
        private string m_TenViTri;

        public int MaBanAn { get => m_MaBanAn; set => m_MaBanAn = value; }
        public string TenBan { get => m_TenBan; set => m_TenBan = value; }
        public int MaViTri { get => m_MaViTri; set => m_MaViTri = value; }
        public string TrangThai { get => m_TrangThai; set => m_TrangThai = value; }
        public string TenViTri { get => m_TenViTri; set => m_TenViTri = value; }

        public TableMenu(DataRow row)
        {
            this.m_MaBanAn = (int)row["MABANAN"];
            this.m_TenBan = row["TENBAN"].ToString();
            this.m_MaViTri = (int)row["MAVITRI"];
            this.m_TenViTri = row["TENVITRI"].ToString();
            this.m_TrangThai = row["TRANGTHAI"].ToString();

        }

        public TableMenu(int maBanAn, string tenBan, int maViTri, string trangThai, string tenViTri)
        {
            m_MaBanAn = maBanAn;
            m_TenBan = tenBan;
            m_MaViTri = maViTri;
            m_TrangThai = trangThai;
            m_TenViTri = tenViTri;
        }
    }
}
