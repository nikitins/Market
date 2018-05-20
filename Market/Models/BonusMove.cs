using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Models
{
    class BonusMove
    {
        public int id;
        public int sum;
        public int type;
        public string firstName;
        public string lastName;
        public string phone;
        public DateTime date;

        public BonusMove(int id, int sum, int type, string firstName, string lastName, string phone, DateTime date)
        {
            this.id = id;
            this.sum = sum;
            this.type = type;
            this.firstName = firstName;
            this.lastName = lastName;
            this.phone = phone;
            this.date = date;
        }

        internal static int compareBydate(BonusMove x, BonusMove y)
        {
            return x.date.CompareTo(y.date);
        }
    }
}
