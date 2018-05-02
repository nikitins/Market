using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Models
{
    class User
    {
        public int id;
        public string firstName;
        public string lastName;
        public string secondName;
        public string phone;
        public User parent;
        public List<User> children = new List<User>();
        public int bonus;
        public int type;

        public User(UserDB userDB, User parent)
        {
            id = userDB.id;
            firstName = userDB.firstName;
            lastName = userDB.lastName;
            secondName = userDB.secondName;
            phone = userDB.phone;
            bonus = userDB.bonus;
            type = userDB.type;
            this.parent = parent;
        }

        public void addChild(User child)
        {
            children.Add(child);
        }

        public override string ToString()
        {
            string res =  $"{firstName} {lastName} - {phone[0]}-{phone.Substring(1, 3)}-{phone.Substring(4, 3)}-{phone.Substring(7, 2)}-{phone.Substring(9, 2)}";
            if (type == 1)
            {
                res += " --- AGENT";
            }
            return res;
        }
    }
}
