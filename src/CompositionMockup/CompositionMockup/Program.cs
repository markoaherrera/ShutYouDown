using System;
using System.Collections.Generic;
using MockupContracts;
using System.Configuration;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

namespace CompositionMockup
{
	class MainClass
	{
		private CompositionContainer _container;

        [ImportMany]
        // public List<IMockupTask> mockupTasks { get; private set; }
		// public Lazy<IMockupTask>[] mockupTasks;
        public List<Lazy<IMockupTask>> mockupTasks;

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
            foreach (var item in c.mockupTasks)
            {
                // item.ExecuteMockupTask();  // if not lazy
                item.Value.ExecuteMockupTask();
            }
			// c.mockupTask.ExecuteMockupTask ();

            Console.ReadLine();
		}
	}
}
