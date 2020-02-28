using AdvProgrammingCA.BusinessLayer;
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
    class FindQuery
    {
        Student stu;
        SqlConnection conn;

        public FindQuery()
        {
            string cs = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
            conn = new SqlConnection(cs);
            stu = new Student();

        }

        public Student find(int id)
        {

            SqlCommand cmd = new SqlCommand("FindByID", conn);
            cmd.Parameters.AddWithValue("@SID", id);
            if (conn.State != ConnectionState.Open)
                conn.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();



            SqlDataAdapter ad = new SqlDataAdapter();


            ad.SelectCommand = cmd;
            DataTable dt = new DataTable();
            ad.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                stu.StudentID = int.Parse(dr["StudentNumber"].ToString());
                stu.FirstName = dr["FirstName"].ToString(); ;
                stu.LastName = dr["LastName"].ToString(); ;
                stu.Email = dr["Email"].ToString();
                stu.Phone = dr["Phone"].ToString();
                stu.AddressLine1 = dr["AddressLine1"].ToString();
                stu.AddressLine2 = dr["AddressLine2"].ToString();
                stu.City = dr["City"].ToString();
                stu.Country = dr["Country"].ToString();
                System.Console.WriteLine(dr["GradLevel"].ToString());
                stu.Level = bool.Parse(dr["GradLevel"].ToString());
                stu.Course = dr["Course"].ToString();
            }

            return stu;

        }

    }
}
