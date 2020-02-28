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
        UpdateHistoryQuery uhq;

        public EditStudent(string sn, string fn, string ln, string em, string ph, string a1, string a2, string ci,
            string co, short lv, string cs, string username)
        {
            eq = new EditQuery();
            uhq = new UpdateHistoryQuery();
            eq.edit(int.Parse(sn), em, ph, a1, a2, ci, co, lv);
            uhq.update(username, 2, int.Parse(sn), fn, ln, em, ph, a1, a2, ci, co, lv, cs);

        }
    }
}
