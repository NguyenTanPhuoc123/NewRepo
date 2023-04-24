using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TypeAccount
    {
        private int m_MaLoai;
        private string m_TenLoai;

        public int MaLoai { get => m_MaLoai; set => m_MaLoai = value; }
        public string TenLoai { get => m_TenLoai; set => m_TenLoai = value; }

        public TypeAccount(int maLoai, string tenLoai)
        {
            this.m_MaLoai = maLoai;
            this.m_TenLoai = tenLoai;
        }

        public TypeAccount(DataRow row)
        {
            this.m_MaLoai = (int)row["MALOAI"];
            this.m_TenLoai = row["TENLOAI"].ToString();
        }
    }
}
