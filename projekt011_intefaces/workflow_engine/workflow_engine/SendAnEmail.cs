using System;

namespace workflow_engine
{
    public class SendAnEmail : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Send an email to the owner of the video notifying them " +
                              "that the video started processing.");
        }
    }
}