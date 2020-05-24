using System;

namespace WorkflowEngine
{
    class Activity2 : IActivity
    {
        public void Execute()
        {
            Console.WriteLine($"{nameof(Activity2)} is executing");
        }
    }
}