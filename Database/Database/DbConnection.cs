using System;
namespace Database
{
    public abstract class DbConnection
    {

        private string _connectionString;
        private TimeSpan _timeout;
        public  DbConnection(string connectionstr)
        {
            if (string.IsNullOrEmpty(connectionstr)){
                throw new System.InvalidOperationException("Invalid ...");       
            }
            this._connectionString = connectionstr;
            Console.WriteLine("Connection string: {0} verified", connectionstr);
        }

        public abstract void Open();

        public abstract void Close();
       
    }
}
