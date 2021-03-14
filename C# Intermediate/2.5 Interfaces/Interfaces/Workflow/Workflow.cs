using System.Collections.Generic;

namespace Workflow
{
    public class Workflow : IWorkflow
    {
        private readonly IList<IActivity> _activities;

        public Workflow()
        {
            _activities = new List<IActivity>();
        }

        public Workflow(List<IActivity> activities)
        {
            _activities = activities;
        }

        public void Add(IActivity activity)
        {
            _activities.Add(activity);
        }

        public IEnumerable<IActivity> GetActivities()
        {
            return _activities;
        }

        public void Remove(IActivity activity)
        {
            _activities.Remove(activity);
        }
    }
}
