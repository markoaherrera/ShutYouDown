using System;
using MockupContracts;
using System.ComponentModel.Composition;

namespace MockupParts
{
	[Export(typeof(IMockupTask))]
	public class MockupTask : IMockupTask
	{
		public MockupTask ()
		{
		}

		#region IMockupTask implementation
		public void ExecuteMockupTask ()
		{
			Console.WriteLine ("Executting a Shutdown");
		}
		#endregion
	}
}

