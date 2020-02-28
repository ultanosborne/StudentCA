using AdvProgrammingCA.DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvProgrammingCA.BusinessLayer
{
    class HistoryList
    {

        HistoryQuery hq;

        public HistoryList()
        {
            hq = new HistoryQuery();
        }

        public DataTable pullHistory()
        {

            return hq.history();

        }

    }
}
