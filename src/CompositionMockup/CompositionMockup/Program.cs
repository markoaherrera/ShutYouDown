using System;
using MockupContracts;
using System.Configuration;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

namespace CompositionMockup
{
	class MainClass
	{
		private CompositionContainer _container;

		[Import(typeof(IMockupTask))]
		public IMockupTask mockupTask;

		private MainClass()
		{
			var catalog = new AggregateCatalog ();
			// I bet this is for import parts
			catalog.Catalogs.Add (new AssemblyCatalog (typeof(MainClass).Assembly));
			catalog.Catalogs.Add (new DirectoryCatalog (
                ConfigurationManager.AppSettings["DirectoryCatalog"]));
                //"/home/marko/progra/Projects2015/ShutYouDown/src/CompositionMockup/MockupParts/bin/Debug"));

			_container = new CompositionContainer (catalog);

			try {
				this._container.ComposeParts(this);
			} catch (CompositionException ex) {
				Console.WriteLine (ex.Message);
			}
		}

		public static void Main (string[] args)
		{
			//Console.WriteLine ("Hello World!");
			MainClass c = new MainClass();
			c.mockupTask.ExecuteMockupTask ();

		}
	}
}
