using System;

namespace workflow_engine
{
    public class ChangeTheStatus : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Change the status of the video record in the database to “Processing”.");
        }
    }
}