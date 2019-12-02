using System;
namespace Database
{
    public abstract class DbConnection
    {

        private string _connectionString;
        private TimeSpan _timeout;
        public  DbConnection(string connection)
        {
            if (string.IsNullOrEmpty(connection)){
                throw new System.InvalidOperationException("Invalid ...");       
            }
            this._connectionString = connection;
            Console.WriteLine("Connection string: {0} verified", connection);
        }

        public abstract void Open();

        public abstract void Close();
       
    }
}
