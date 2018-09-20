using System;

namespace DbConnection
{
    abstract class DbConnection
    {
        public string connectionString {get; set;}
        public TimeSpan timeout {get; set;}

        public DbConnection(string dbConnectionString){
            if(dbConnectionString == null || dbConnectionString.Equals(""))
                throw new InvalidOperationException("invalid input");
            connectionString = dbConnectionString;
        }

        public abstract void open();
        public abstract void close();
    }
}