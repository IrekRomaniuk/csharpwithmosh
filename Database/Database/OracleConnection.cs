using System;
namespace Database
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connection) : base(connection)
        {
            Console.WriteLine("Initialize Oracle .. {0}", connection);
        }
        public override void Open()
        {
            Console.WriteLine("Opened Oracle");
        }
        public override void Close()
        {
            Console.WriteLine("Closed Oracle");
        }
    }
}
