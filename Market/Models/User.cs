using System.Collections.Generic;


namespace Market.Models
{
    class User
    {

        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string secondName { get; set; }
        public string phone { get; set; }
        public int parentId { get; set; }
        public int bonus { get; set; }
        public int type { get; set; }
        public User parent { get; set; }
        public List<User> children { get; set; }

        public void addChild(User child)
        {
            children.Add(child);
        }


        public User(int id, string firstName, string lastName, string secondName, string phone, int parentId, int bonus, int type)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.secondName = secondName;
            this.phone = phone;
            this.parentId = parentId;
            this.bonus = bonus;
            this.type = type;
        }
    }
}
