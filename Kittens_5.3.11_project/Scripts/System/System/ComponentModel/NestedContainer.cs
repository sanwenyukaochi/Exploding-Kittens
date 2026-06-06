namespace System.ComponentModel
{
	public class NestedContainer : Container, INestedContainer, IContainer, IDisposable
	{
		private class Site : INestedSite, ISite, IServiceProvider
		{
			private string _name;

			public IComponent Component { get; }

			public IContainer Container { get; }

			public bool DesignMode => false;

			public string FullName => null;

			public string Name
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			internal Site(IComponent component, NestedContainer container, string name)
			{
			}

			public object GetService(Type service)
			{
				return null;
			}
		}

		public IComponent Owner { get; }

		protected virtual string OwnerName => null;

		public NestedContainer(IComponent owner)
		{
		}

		protected override ISite CreateSite(IComponent component, string name)
		{
			return null;
		}

		protected override void Dispose(bool disposing)
		{
		}

		protected override object GetService(Type service)
		{
			return null;
		}

		private void OnOwnerDisposed(object sender, EventArgs e)
		{
		}
	}
}
