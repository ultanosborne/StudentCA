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
    class EditQuery
    {

        SqlConnection conn;

        public EditQuery()
        {
            string cs = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
            conn = new SqlConnection(cs);

        }

        public void edit(int id, string email, string phone,
            string al1, string al2, string city, string country, short glevel)
        {
            SqlCommand cmd = new SqlCommand("EditStudent", conn);
            cmd.Parameters.AddWithValue("@SID", id);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Phone", phone);
            cmd.Parameters.AddWithValue("@AL1", al1);
            cmd.Parameters.AddWithValue("@AL2", al2);
            cmd.Parameters.AddWithValue("@City", city);
            cmd.Parameters.AddWithValue("@Country", country);
            cmd.Parameters.AddWithValue("@GLevel", glevel);
            if (conn.State != ConnectionState.Open)
                conn.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
        }
    }
}
