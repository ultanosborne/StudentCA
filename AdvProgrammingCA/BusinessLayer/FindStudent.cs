using AdvProgrammingCA.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvProgrammingCA.BusinessLayer
{
    class FindStudent
    {
        FindQuery fq;
        public Student stu;

        public FindStudent(int i)
        {
            fq = new FindQuery();
            stu = fq.find(i);
        }

    }
}
