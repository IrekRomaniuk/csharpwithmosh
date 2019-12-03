using System;
using System.Collections.Generic;

namespace Workflow
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //private List<object> _obj = new List<object>();
            var activity = new List<object> { "Upload..", "Call..", "Send..", "Change.." };
            var workflow = new Workflow(new Activity());
            workflow.Run(activity);
        }
    }
}
