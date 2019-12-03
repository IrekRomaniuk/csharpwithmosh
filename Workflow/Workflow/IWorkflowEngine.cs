using System;
namespace Workflow
{
    
    public interface IWorkflowEngine
    {
        void AddToWorkflow(IActivity activity);
        void Run();
    }
    
}
