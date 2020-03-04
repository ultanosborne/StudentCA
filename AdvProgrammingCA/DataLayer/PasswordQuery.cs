using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvProgrammingCA.DataLayer
{
    class PasswordQuery
    {

        SqlConnection conn;
        string username, password;

        public PasswordQuery(string us, string pw)
        {
            string cs = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
            conn = new SqlConnection(cs);
            username = us;
            password = pw;
        }

        public bool ComparePW()
        {
            bool success = false;

            SqlCommand cmd = new SqlCommand("PWCheck", conn);
            cmd.Parameters.AddWithValue("@username", username);
            if (conn.State != ConnectionState.Open)
                conn.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();



            SqlDataAdapter ad = new SqlDataAdapter();

            ad.SelectCommand = cmd;
            DataTable dt = new DataTable();
            ad.Fill(dt);

            string us2, pw2 = "";

            foreach (DataRow dr in dt.Rows)
            {
                us2 = dr["Username"].ToString();
                pw2 = dr["Password"].ToString(); 
            }

            if (password == pw2)
            {
                success = true;
            }

            return success;


        }
    }
}
