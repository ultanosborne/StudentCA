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
    class DeleteQuery
    {

        SqlConnection conn;

        public DeleteQuery()
        {
            string cs = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
            conn = new SqlConnection(cs);

        }

        public void delete(int id)
        {
            SqlCommand cmd = new SqlCommand("DeleteStudent", conn);
            cmd.Parameters.AddWithValue("@SID", id);
            if (conn.State != ConnectionState.Open)
                conn.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
        }
    }
}
