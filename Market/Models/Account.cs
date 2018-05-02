namespace Market.Models
{
    public class Account
    {
        public int id;
        public string name;
        public bool isRoot;

        public Account(int id, string name, bool isRoot)
        {
            this.id = id;
            this.name = name;
            this.isRoot = isRoot;
        }
    }
}
