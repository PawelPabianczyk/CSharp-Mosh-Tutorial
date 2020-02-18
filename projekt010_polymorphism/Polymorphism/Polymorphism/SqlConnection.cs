using System;

namespace Polymorphism
{
    public class SqlConnection : DbConnection
    {
        
        public SqlConnection(string connetionString) : base(connetionString) { }

        public override void Open()
        {
            Console.WriteLine("Opening SQL database.");
        }

        public override void Close()
        {
            Console.WriteLine("Closing SQL database.");
        }
    }
}