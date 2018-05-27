using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Models
{
    class Date
    {
        public DateTime date;

        internal static int compareBydate(Date x, Date y)
        {
            return x.date.CompareTo(y.date);
        }
    }
}
