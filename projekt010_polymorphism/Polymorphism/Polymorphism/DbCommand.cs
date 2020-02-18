using System;

namespace Polymorphism
{
    public class DbCommand
    {
        private DbConnection server;

        public DbCommand(DbConnection dbConnection)
        {
            try
            {
                server = dbConnection;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new InvalidProgramException("Connection not found.");
            }
        }

        public void Execute()
        {
            server.Open();
            server.Close();
        }
    }
}