namespace Extensibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new FileLogger(@"C:\Users\Paweł Pabiańczyk\Downloads\file.txt"));
            dbMigrator.Migrate();
        }
    }
}
