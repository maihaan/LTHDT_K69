using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;

namespace BaiTapQLCV.Controllers
{
    public class CDataAccess
    {
        private String connectionString = "Data Source=.\\MSSQL; Initial Catalog=LTHDT_QLCV_DB; User ID=LTHDT_K69; Password=LTHDT@123;";

        public DataTable Doc(String query)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, con);
            try 
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable tb = new DataTable();
                tb.Load(dr, LoadOption.OverwriteChanges);
                con.Close();
                return tb;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                if(con.State == ConnectionState.Open)
                    con.Close();
                return null;
            }
        }

        public int Ghi(String query)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                int count = cmd.ExecuteNonQuery();
                con.Close();
                return count;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                if (con.State == ConnectionState.Open)
                    con.Close();
                return -2;
            }
        }
    }
}