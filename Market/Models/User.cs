using System.Collections.Generic;


namespace Market.Models
{
    class User
    {

        private int id { get; set; }
        private string firstName { get; set; }
        private string lastName { get; set; }
        private string secondName { get; set; }
        private string phone { get; set; }
        private int parentId { get; set; }
        private int bonus { get; set; }
        private bool agent { get; set; }
        private User parent { get; set; }
        private List<User> children { get; set; }

        public void addChild(User child)
        {
            children.Add(child);
        }


        public User(int id, string firstName, string lastName, string secondName, string phone, int parentId, int bonus, bool agent)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.secondName = secondName;
            this.phone = phone;
            this.parentId = parentId;
            this.bonus = bonus;
            this.agent = agent;
        }
    }
}
