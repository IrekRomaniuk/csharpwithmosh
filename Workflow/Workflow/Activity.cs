using System;
using System.Collections.Generic;

namespace Workflow
{
    public class Activity:IActivity
    {
        public void Execute(List<object> acts)
        {
            foreach (var act in acts)
            {
                Console.WriteLine("Execute {0} ", act);
            }
            
        }
    }
}
