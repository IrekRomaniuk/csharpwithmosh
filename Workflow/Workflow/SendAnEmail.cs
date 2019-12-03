using System;
namespace Workflow
{
    public class SendAnEmail: IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Send an email to the owner of the video notifying them that the video started processing.");
        }
    }
}
