using System.Dynamic;

namespace firstclass
{
    public class Customer
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public Customer() { }

        public Customer(int id, string name)
        {
            this.Name = name;
            this.Id = id;
        }

    }
}