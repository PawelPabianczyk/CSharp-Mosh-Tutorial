using System;

namespace Polymorphism
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connetionString) : base(connetionString) { }

        public override void Open()
        {
            Console.WriteLine("Opening Oracle database.");
        }

        public override void Close()
        {
            Console.WriteLine("Closing Oracle database.");
        }
    }
}