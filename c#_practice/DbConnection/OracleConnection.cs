using System;

namespace DbConnection
{
    class OracleConnection: DbConnection{
        public OracleConnection(string dbConnectionString)
            : base(dbConnectionString)
            {}
            public override void open(){
            System.Console.WriteLine("oracle open");
        }
            public override void close(){
            System.Console.WriteLine("oracle close");
        }
    }
}