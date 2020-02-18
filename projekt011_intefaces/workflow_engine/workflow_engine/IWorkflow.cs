using System.Collections.Generic;

namespace workflow_engine
{
    public interface IWorkflow
    {
        void Add(ITask task);
        void Remove(ITask task);
        IEnumerable<ITask> GetTasks();
    }
}