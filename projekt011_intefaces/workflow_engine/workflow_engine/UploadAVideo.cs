using System;

namespace workflow_engine
{
    public class UploadAVideo : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Upload a video to a cloud storage.");
        }
    }
}