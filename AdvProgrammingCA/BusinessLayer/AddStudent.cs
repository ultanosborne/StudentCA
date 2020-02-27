using AdvProgrammingCA.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvProgrammingCA.BusinessLayer
{
    class AddStudent
    {

        AddQuery aq;

        int StuNo { get; set; }
        string FName { get; set; }
        string LName { get; set; }
        string Email { get; set; }
        string Phone { get; set; }
        string Ad1 { get; set; }
        string Ad2 { get; set; }
        string City { get; set; }
        string Country { get; set; }
        short Level { get; set; }
        string Course { get; set; }


        public AddStudent(string sn, string fn, string ln, string em, string ph, string a1, string a2, string ci,
            string co, short lv, string cs)
        {

            StuNo = int.Parse(sn);
            FName = fn;
            LName = ln;
            Email = em;
            Phone = ph;
            Ad1 = a1;
            Ad2 = a2;
            City = ci;
            Country = co;
            Level = lv;
            Course = cs;

            aq = new AddQuery();

        }

        public void addToDB()
        {
            aq.add(StuNo, FName, LName, Email, Phone, Ad1, Ad2, City, Country, Level, Course);
        }
    }
}
