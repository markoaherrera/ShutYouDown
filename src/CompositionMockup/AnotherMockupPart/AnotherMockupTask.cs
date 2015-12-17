using System;
using MockupContracts;
using System.ComponentModel.Composition;

namespace AnotherMockupPart
{
    [Export(typeof(IMockupTask))]
    public class AnotherMockupTask : IMockupTask
    {
        public AnotherMockupTask()
        {
        }

        public void ExecuteMockupTask()
        {
            Console.WriteLine("Executting another task");
        }
    }
}
