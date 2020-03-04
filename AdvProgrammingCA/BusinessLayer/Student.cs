using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvProgrammingCA.BusinessLayer
{
    class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public bool Level { get; set; }
        public string Course { get; set; }
        public string Phone { get; set; }

        public Student()
        {

        }

        public Student(int id, string fname, string lname, string email, string a1,
            string a2, string city, string country, bool level, string course, string phone)
        {
            StudentID = id;
            FirstName = fname;
            LastName = lname;
            Email = email;
            AddressLine1 = a1;
            AddressLine2 = a2;
            City = city;
            Country = country;
            Level = level;
            Course = course;
            Phone = phone;
        }

    }
}
