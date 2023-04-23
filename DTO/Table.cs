using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Table
    {
        private int m_MaBanAn;
        private string m_TenBan;
        private int m_ViTri;
        private string m_TrangThai;

    
        public int MaBanAn { get => m_MaBanAn; set => m_MaBanAn = value; }
        public string TenBan { get => m_TenBan; set => m_TenBan = value; }
        public int ViTri { get => m_ViTri; set => m_ViTri = value; }
        public string TrangThai { get => m_TrangThai; set => m_TrangThai = value; }
     

        public Table(DataRow row)
        {
            this.m_MaBanAn = (int)row["MABANAN"];
            this.m_TenBan = row["TENBAN"].ToString();
            this.m_ViTri = (int)row["VITRI"];
            this.m_TrangThai = row["TRANGTHAI"].ToString();

        }

        public Table(int maBanAn, string tenBan, int viTri, string trangThai)
        {
            m_MaBanAn = maBanAn;
            m_TenBan = tenBan;
            m_ViTri = viTri;
            m_TrangThai = trangThai;
        }
    }
}
