using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace frmLogin.Data_Access_Layer
{
    public class DataProvider
    {
        private static string connect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\do an\frmLogin\database\QUANLYCUAHANGTIMO.mdf';Integrated Security = True; Connect Timeout = 30";
        private static SqlConnection connection = new SqlConnection(connect);
        private static SqlDataAdapter da = new SqlDataAdapter();
        
        public static SqlConnection OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed || connection.State == System.Data.ConnectionState.Broken)
                connection.Open();

            return connection;
        }

        public static DataTable ExcecuteSelectCommand(string query, SqlParameter[] parameters)
        {
            SqlCommand cmd = new SqlCommand(query);
            DataTable tbl = new DataTable();
            cmd.Connection = OpenConnection();
            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }
            da.SelectCommand = cmd;
            da.Fill(tbl);

            connection.Close();
            return tbl;
        }


    }
}
