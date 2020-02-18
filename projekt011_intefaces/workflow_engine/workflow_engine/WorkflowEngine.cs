using System;

namespace workflow_engine
{
    public class WorkflowEngine
    {
        public void Run(IWorkflow workflow)
        {
            foreach (var task in workflow.GetTasks())
            {
                try
                {
                    task.Execute();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }
    }
}