using System;
using System.Collections.Generic;

namespace Workflow
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //based on https://www.udemy.com/course/csharp-intermediate-classes-interfaces-and-oop/learn/lecture/3023250#questions/8280878
            var workflow = new WorkflowEngine();

            workflow.AddToWorkflow(new UploadVideoToCloud());
            workflow.AddToWorkflow(new CallAWebService());
            workflow.AddToWorkflow(new SendAnEmail());
            workflow.AddToWorkflow(new ChangeTheStatus());

            workflow.Run();
        }
    }
}

