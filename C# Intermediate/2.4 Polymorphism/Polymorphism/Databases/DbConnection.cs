using System;

namespace Databases
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; private set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new ArgumentException("connectionString is null or empty");
            }

            ConnectionString = connectionString;
        }

        public abstract void OpenConnection();
        public abstract void CloseConnection();
    }

    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString)
            : base(connectionString)
        {
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Opened connection to SQL database: {0}", ConnectionString);
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Closed connection to SQL database: {0}", ConnectionString);
        }
    }

    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Opened connection to Oracle database at {0}", ConnectionString);
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Closed connection to Oracle database at {0}", ConnectionString);
        }

    }
}
