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
    class UpdateHistoryQuery
    {

        SqlConnection conn;

        public UpdateHistoryQuery()
        {
            string cs = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
            conn = new SqlConnection(cs);

        }

        public void update(string username, int ctype, int id, string fname, string lname, string email, string phone,
            string al1, string al2, string city, string country, short glevel, string course)
        {
            string change = "";

            switch(ctype)
            {
                case 1:
                    change = "Add";
                    break;
                case 2:
                    change = "Edit";
                    break;
                case 3:
                    change = "Delete";
                    break;
            }


            SqlCommand cmd = new SqlCommand("UpdateHistory", conn);
            cmd.Parameters.AddWithValue("@User", username);
            cmd.Parameters.AddWithValue("@Date", DateTime.Now);
            cmd.Parameters.AddWithValue("@Change", change);
            cmd.Parameters.AddWithValue("@SID", id);
            cmd.Parameters.AddWithValue("@FName", fname);
            cmd.Parameters.AddWithValue("@LName", lname);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Phone", phone);
            cmd.Parameters.AddWithValue("@AL1", al1);
            cmd.Parameters.AddWithValue("@AL2", al2);
            cmd.Parameters.AddWithValue("@City", city);
            cmd.Parameters.AddWithValue("@Country", country);
            cmd.Parameters.AddWithValue("@GLevel", glevel);
            cmd.Parameters.AddWithValue("@Course", course);
            if (conn.State != ConnectionState.Open)
                conn.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
        }
    }
}
