using System;

namespace DbConnection
{
    class DbCommand {
        private DbConnection _dbConnection;
        private string _instruction;
        public DbCommand(DbConnection connection, string instruction){
            if(connection == null )
                throw new InvalidOperationException("invalid database connection input");
            if(instruction == null || instruction.Equals(""))
                throw new InvalidOperationException("invalid database instructon input");
            _dbConnection = connection;
            _instruction = instruction;
        }

        public void Execute(){
            _dbConnection.open();
            System.Console.WriteLine(_instruction);
            _dbConnection.close();
        }
    }
}