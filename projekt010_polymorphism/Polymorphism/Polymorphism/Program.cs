using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                var sql = new SqlConnection("");
                sql.Open();
                sql.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            try
            {
                var oracle = new OracleConnection("open oracle");
                oracle.Open();
                oracle.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            try
            {
                var server = new OracleConnection("");
                DbConnection serverDB = server;
                var command = new DbCommand(serverDB);
                command.Execute();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
