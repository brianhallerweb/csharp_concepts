using System;

namespace DbConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            // var sql = new SqlConnection("sql");
            // var db = new DbCommand(sql, "a sql instruction");
            var oracle = new OracleConnection("oracle");
            var db = new DbCommand(oracle, "an oracle instruction");
            // this is an example of polymorphism. The execute command 
            // works properly on a sql database connection or a 
            // oracle database connection. 
            db.Execute();
        }
    }
}
