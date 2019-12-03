using System;
namespace Workflow
{
    public class ChangeTheStatus: IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Change the status of the video record in the database");
        }
    }
}
