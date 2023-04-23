using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Position
    {
        private int maChucVu;
        private string tenChucVu;

        public int MaChucVu { get => maChucVu; set => maChucVu = value; }
        public string TenChucVu { get => tenChucVu; set => tenChucVu = value; }

        public Position(int maChucVu, string tenChucVu)
        {
            this.maChucVu = maChucVu;
            this.tenChucVu = tenChucVu;
        }
        public Position(DataRow row)
        {
            this.maChucVu = (int)row["MACHUCVU"];
            this.tenChucVu = row["TENCHUCVU"].ToString();
        }
    }
}
