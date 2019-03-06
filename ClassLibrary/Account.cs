namespace ClassLibrary
{
    public class Account
    {
        public Account()
        {
               
        }
        public Account(string name, string id)
        {
            Name = name;
            Id = id;
        }
        public string Name { get; set; }
        public string Id { get; set; }
    }
}