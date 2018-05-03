namespace Market.Models
{
    public class Account
    {
        public int id;
        public string name;
        public int type;

        public Account(int id, string name, int type)
        {
            this.id = id;
            this.name = name;
            this.type = type;
        }
    }
}
