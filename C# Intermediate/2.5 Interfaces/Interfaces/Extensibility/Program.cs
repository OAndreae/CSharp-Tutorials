using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensibility
{
    class Program
    {
        static void Main(string[] args)
        {
            //var migrator = new DbMigrator(new FileLogger(@"E:\Documents\log.txt"));
            var migrator = new DbMigrator(new ConsoleLogger());

            migrator.Migrate();
        }
    }
}
