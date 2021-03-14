using System;

namespace Workflow
{
    public class ChangeStatus : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Changed status to 'Processing'");
        }
    }
}
