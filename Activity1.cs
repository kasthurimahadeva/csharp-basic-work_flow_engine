using System;

namespace WorkflowEngine
{
    class Activity1 : IActivity
    {
        public void Execute()
        {
            Console.WriteLine($"{nameof(Activity1)} is executing");
        }
    }
}