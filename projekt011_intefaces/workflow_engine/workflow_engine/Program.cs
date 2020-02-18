using System;

namespace workflow_engine
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflow = new Workflow();
            workflow.Add(new UploadAVideo());
            workflow.Add(new CallAWebService());
            workflow.Add(new SendAnEmail());
            workflow.Add(new ChangeTheStatus());

            var engine = new WorkflowEngine();

            engine.Run(workflow);
        }
    }
}
