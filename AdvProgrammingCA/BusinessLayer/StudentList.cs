using AdvProgrammingCA.DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvProgrammingCA.BusinessLayer
{
    class StudentList
    {

        SelectQuery sq;

        public StudentList()
        {
            sq = new SelectQuery();
        }

        public DataTable pullStudentList()
        {

            return sq.students();

        }

    }
}
