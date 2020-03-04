using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvProgrammingCA.BusinessLayer
{
    class Verification
    {

        string Sid, Fname, Lname, Email, Phone;

        public Verification(string id, string fname, string lname, string email, string phone)
        {
            Sid = id;
            Fname = fname;
            Lname = lname;
            Email = email;
            Phone = phone;
        }

        public bool Validate()
        {
            Regex sid = new Regex(@"\d{8}");
            Regex name = new Regex("[A-Z][a-z]+");
            Regex email = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Regex phone = new Regex(@"\d{6,10}");

            Match sidMatch = sid.Match(Sid);
            Match fnameMatch = name.Match(Fname);
            Match lnameMatch = name.Match(Lname);
            Match emailMatch = email.Match(Email);
            Match phoneMatch = phone.Match(Phone);

            
            bool valid = true;
            valid &= sidMatch.Success;
            valid &= fnameMatch.Success;
            valid &= lnameMatch.Success;
            valid &= emailMatch.Success;
            valid &= phoneMatch.Success;

            return valid;
        }
    }
}
