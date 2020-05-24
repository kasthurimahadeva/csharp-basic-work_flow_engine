using System;

namespace WorkflowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflow = new Workflow();
            workflow.AddActivity(new Activity1());
            workflow.AddActivity(new Activity2());
            var workflowEngine = new WorkflowEngine();
            workflowEngine.Run(workflow);
        }
    }
}