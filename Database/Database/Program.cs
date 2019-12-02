using System;

namespace Database
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var connection1 = "ConnectionStringforSql";
            var connection2 = "ConnectionStringforOracle";
            var instruction = "Select * from Db";
            var db1 = new SqlConnection(connection1);
            db1.Open();
            db1.Close();

            var db2 = new OracleConnection(connection2);
            db2.Open();
            db2.Close();

            var db = new DbCommand(db1);
            db.Execute(instruction);
            db = new DbCommand(db2);
            db.Execute(instruction);


        }
    }
}
