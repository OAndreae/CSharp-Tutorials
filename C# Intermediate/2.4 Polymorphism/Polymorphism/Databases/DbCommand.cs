using System;

namespace Databases
{
    public class DbCommand
    {
        private DbConnection _dbConnection;
        private string _command;

        public DbCommand(DbConnection connection, string command)
        {
            if(string.IsNullOrWhiteSpace(command))
            {
                throw new ArgumentException("command is null or empty");
            }

            _dbConnection = connection;
            _command = command;
        }

        public void Execute()
        {
            _dbConnection.OpenConnection();
            Console.WriteLine("Executing command: " + _command);
            _dbConnection.CloseConnection();
        }
    }
}
