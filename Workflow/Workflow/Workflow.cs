using System;
using System.Collections.Generic;

namespace Workflow
{
    public class WorkflowEngine : IWorkflowEngine
    {
        private IList<IActivity> _activities;

        public WorkflowEngine()
        {
            _activities = new List<IActivity>();
        }

        public void Run()
        {
            foreach (var activity in _activities)
            {
                activity.Execute();
            }
        }

        public void AddToWorkflow(IActivity activity)
        {
            _activities.Add(activity);
        }
    }

}
