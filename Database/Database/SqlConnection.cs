using System;
namespace Database
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connection) : base(connection)
        {
            Console.WriteLine("Initialize Sql .. {0}", connection);
        }
        public override void Open()
        {
            Console.WriteLine("Opened Sql");
        }
        public override void Close()
        {
            Console.WriteLine("Closed Sql");
        }
    }
}
