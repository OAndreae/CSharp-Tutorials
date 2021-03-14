using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databases
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqlConnection = new SqlConnection("www.sql.com/xyz/connection");
            var sqlCommand = new DbCommand(sqlConnection, "SELECT * FROM Customers");
            sqlCommand.Execute();
        }
    }
}
