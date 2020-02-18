using System;

namespace firstclass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Customer client = new Customer();
            client.Id = 10;
            client.Name = "Paweł";
            Console.WriteLine("id: {0}\n{1}", client.Id, client.Name);

        }
    }
}
