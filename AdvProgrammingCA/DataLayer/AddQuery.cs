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
    class AddQuery
    {

        SqlConnection conn;

        public AddQuery()
        {
            string cs = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
            conn = new SqlConnection(cs);

        }

        public void add(int id, string fname, string lname, string email, string phone,
            string al1, string al2, string city, string country, short glevel, string course)
        {
            SqlCommand cmd = new SqlCommand("AddStudent", conn);
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
