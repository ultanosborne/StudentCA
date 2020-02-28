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
    class HistoryQuery
    {
        SqlConnection conn;

        public HistoryQuery()
        {
            string cs = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
            conn = new SqlConnection(cs);

        }


        public DataTable history()
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
            SqlCommand select = new SqlCommand("SELECT * FROM DatabaseHistory", conn);
            SqlDataAdapter ad = new SqlDataAdapter();
            ad.SelectCommand = select;
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }

    }
}
