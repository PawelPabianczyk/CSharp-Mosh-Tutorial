using System;

namespace workflow_engine
{
    public class CallAWebService : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Call a web service provided by a third-party video encoding service " +
                              "to tell them you have a video ready for encoding.");
        }
    }
}