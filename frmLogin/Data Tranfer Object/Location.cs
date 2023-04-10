using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmLogin.Data_Tranfer_Object
{
    
    public class Location
    {
        private int maViTri;
        private string tenViTri;

        public Location(int maViTri, string tenViTri)
        {
            this.maViTri = maViTri;
            this.tenViTri = tenViTri;
        }

        public int MaViTri { get => maViTri; set => maViTri = value; }
        public string TenViTri { get => tenViTri; set => tenViTri = value; }

        public Location(DataRow row)
        {
            this.maViTri = (int)row["MAVITRI"];
            this.tenViTri = row["TENVITRI"].ToString();
        } 

    }
}
