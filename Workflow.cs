using System.Collections.Generic;

namespace WorkflowEngine
{
    class Workflow
    {
        public IList<IActivity> Activities { get; }

        public Workflow()
        {
            Activities = new List<IActivity>();
        }

        public void AddActivity(IActivity activity)
        {
            Activities.Add(activity);
        }
    }
}