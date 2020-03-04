using AdvProgrammingCA.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvProgrammingCA.BusinessLayer
{
    class LoginCheck
    {

        PasswordQuery pq;

        public bool check(string u, string p)
        {
            pq = new PasswordQuery(u, p);
            return pq.ComparePW();
        }

    }
}
