using System;
namespace Database
{
    public class DbCommand
    {
        private DbConnection _connection;
        public DbCommand(DbConnection connection)
        {
            Console.WriteLine("DbCommand initialize {0}", connection);
            if (connection == null)
                throw new InvalidOperationException("Invalid..");
            _connection = connection;
        }
        public void Execute(string instruction)
        {
            if (instruction == null)
                throw new InvalidOperationException("Invalid..");
            _connection.Open();
            Console.WriteLine("Execute DbCommand {0}", instruction);
            _connection.Close();
        }
    }
}
