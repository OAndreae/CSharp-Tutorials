using System;
using System.Collections.Generic;

namespace Workflow
{
    public class WorkflowEngine
    {
        public void Run(IWorkflow workflow)
        {
            try
            {
                foreach (var activity in workflow.GetActivities())
                    activity.Execute();
            }
            catch (Exception)
            {
                // log error
                // abort workflow

                throw;
            }
        }
    }
}
