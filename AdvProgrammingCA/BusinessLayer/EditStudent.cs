using AdvProgrammingCA.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvProgrammingCA.BusinessLayer
{
    class EditStudent
    {

        EditQuery eq;

        public EditStudent(int id, string email, string phone,
            string al1, string al2, string city, string country, short glevel)
        {
            eq = new EditQuery();
            eq.edit(id, email, phone, al1, al2, city, country, glevel);
        }
    }
}
