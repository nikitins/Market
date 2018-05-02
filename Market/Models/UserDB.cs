using System.Collections.Generic;


namespace Market.Models
{
    class UserDB
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string secondName { get; set; }
        public string phone { get; set; }
        public int parentId { get; set; }
        public int bonus { get; set; }
        public int type { get; set; }

        public UserDB(int id, string firstName, string lastName, string secondName, string phone, int parentId, int bonus, int type)
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

        public override string ToString()
        {
            return $"{firstName} {lastName} - {phone[0]}-{phone.Substring(1, 3)}-{phone.Substring(4, 3)}-{phone.Substring(7, 2)}-{phone.Substring(9, 2)}";
        }
    }
}
