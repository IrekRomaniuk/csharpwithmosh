using System;
namespace Workflow
{
    public class CallAWebService: IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Call a web service provided by a third-party video encoding service to tell them you have a video ready for encoding.");
        }
    }
}
