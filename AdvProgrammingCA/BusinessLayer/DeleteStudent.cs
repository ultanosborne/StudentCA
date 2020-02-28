using AdvProgrammingCA.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvProgrammingCA.BusinessLayer
{
    class DeleteStudent
    {
        DeleteQuery dq;


        public DeleteStudent(int id) 
        {
            dq = new DeleteQuery();
            dq.delete(id);        
        }
    }
}
