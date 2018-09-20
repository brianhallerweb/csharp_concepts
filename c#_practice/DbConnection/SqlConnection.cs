using System;

namespace DbConnection
{
     class SqlConnection: DbConnection{
        public SqlConnection(string dbConnectionString)
            : base(dbConnectionString)
            {}

        public override void open(){
            System.Console.WriteLine("sql open");
        }
        public override void close(){
            System.Console.WriteLine("sql close");
    }}
}