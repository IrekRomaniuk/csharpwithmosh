using System;
using System.Collections.Generic;

namespace Workflow
{
    public class Workflow
    {        
        private readonly IActivity _activity;
        public Workflow(IActivity activity)
        {
            _activity = activity;
        }

        public void Run(List<object> obj)
        {
            _activity.Execute(obj);
        }

    }
    
}
