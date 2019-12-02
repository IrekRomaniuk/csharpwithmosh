using System;
namespace Database
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionstr) : base(connectionstr)
        {
            Console.WriteLine("Initialize Sql .. {0}", connectionstr);
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
