using System;
namespace Database
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionstr) : base(connectionstr)
        {
            Console.WriteLine("Initialize Oracle .. {0}", connectionstr);
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
