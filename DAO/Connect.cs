using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyTC.DAO
{
    class Connect
    {
        private string constring;
        private SqlConnection con;
        public void ketnoi()
        {
            constring = @"Data Source=TAEUNG-PC\SQLEXPRESS;Initial Catalog=QLTC;Persist Security Info=True;User ID=sa;Password=aa";
            con = new SqlConnection(constring);
            con.Open();
        }
        public void disconnect()
        {
            ketnoi();
            con.Close();
        }
        public DataTable table(string sql)
        {
            ketnoi();
            SqlDataAdapter dat = new SqlDataAdapter(sql,con);
            DataTable da = new DataTable();
            dat.Fill(da);
            disconnect();
            return da;
 
        }
        public bool query(string sql)
        {
            ketnoi();
            bool kq;
            SqlCommand com = new SqlCommand(sql, con);
            int n = com.ExecuteNonQuery();
            if (n > 0)
             {
                kq = true;
            }
            else
            {
                kq = false;
            }
            disconnect();
            return kq;
        }

    }
}
