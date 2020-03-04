using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvProgrammingCA.BusinessLayer
{
    class XMLExport
    {

        private DataSet ds;

        public XMLExport(string sn, string fn, string ln, string em, string ph, string a1, string a2, string ci,
            string co, short lv, string cs)
        {
            DataTable dt;
            if (ds == null)
            {
                ds = new DataSet("Students");
                dt = new DataTable("Export");
                dt.Columns.Add("StudentID");
                dt.Columns.Add("FirstName");
                dt.Columns.Add("LastName");
                dt.Columns.Add("Email");
                dt.Columns.Add("Phone");
                dt.Columns.Add("AddressLine1");
                dt.Columns.Add("AddressLine2");
                dt.Columns.Add("City");
                dt.Columns.Add("Country");
                dt.Columns.Add("GradLevel");
                dt.Columns.Add("Course");
                ds.Tables.Add(dt);
            }
            dt = ds.Tables["Export"];
            DataRow row = dt.NewRow();
            row["StudentID"] = sn;
            row["FirstName"] = fn;
            row["LastName"] = ln;
            row["Email"] = em;
            row["Phone"] = ph;
            row["AddressLine1"] = a1;
            row["AddressLine2"] = a2;
            row["City"] = ci;
            row["Country"] = co;
            row["GradLevel"] = lv;
            row["Course"] = cs;
            dt.Rows.Add(row);
            dt.AcceptChanges();
            dt.WriteXml(@"C:\Users\ultan\Desktop\Project1.0\StudentsCA\AdvProgrammingCA\StudentExport.xml", true);

        }

    }
}
