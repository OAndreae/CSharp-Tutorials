using System;

namespace Workflow
{
    public class EmailNotificationService : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Sent email to user");
        }
    }
}
