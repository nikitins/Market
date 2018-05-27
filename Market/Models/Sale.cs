using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Models
{
    class Sale : Date
    {
        public int id;
        public int sum;
        public int bonus;
        public string firstName;
        public string secondName;
        public string phone;
        public bool opened = false;
        public int salesCount = 0;

        public Sale(int id, int sum, int bonus, string firstName, string secondName, string phone, DateTime date)
        {
            this.id = id;
            this.sum = sum;
            this.bonus = bonus;
            this.firstName = firstName;
            this.secondName = secondName;
            this.phone = phone;
            this.date = date;
        }
    }
}
