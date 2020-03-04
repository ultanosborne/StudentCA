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
        UpdateHistoryQuery uhq;


        public DeleteStudent(string sn, string fn, string ln, string em, string ph, string a1, string a2, string ci,
            string co, short lv, string cs, string username) 
        {
            dq = new DeleteQuery();
            uhq = new UpdateHistoryQuery();
            dq.delete(int.Parse(sn));
            uhq.update(username, 3, int.Parse(sn), fn, ln, em, ph, a1, a2, ci, co, lv, cs);
        }
    }
}
