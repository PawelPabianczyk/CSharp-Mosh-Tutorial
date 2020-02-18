using System;

namespace Polymorphism
{
    public class DbConnection
    {
        private string ConnectionString;
        protected TimeSpan Timeout;

        public DbConnection(string connectionString)
        {
            if (!String.IsNullOrWhiteSpace(connectionString))
            {
                this.ConnectionString = connectionString;
                Console.WriteLine(connectionString);
            }
            else
                throw new InvalidProgramException("NULL or white space.");
        }

        public virtual void Open() { }
        public virtual void Close() { }
    }
}