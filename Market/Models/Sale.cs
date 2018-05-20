using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Models
{
    class Sale
    {
        public int id;
        public int sum;
        public int bonus;
        public string firstName;
        public string lastName;
        public string phone;
        public DateTime date;

        public Sale(int id, int sum, int bonus, string firstName, string lastName, string phone, DateTime date)
        {
            this.id = id;
            this.sum = sum;
            this.bonus = bonus;
            this.firstName = firstName;
            this.lastName = lastName;
            this.phone = phone;
            this.date = date;
        }

        internal static int compareByDate(Sale x, Sale y)
        {
            return x.date.CompareTo(y.date);
        }
    }
}
