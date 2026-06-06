namespace System.ComponentModel
{
	public class Container : IContainer, IDisposable
	{
		private class Site : ISite, IServiceProvider
		{
			private IComponent component;

			private Container container;

			private string name;

			public IComponent Component => null;

			public IContainer Container => null;

			public bool DesignMode => false;

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

			internal Site(IComponent component, Container container, string name)
			{
			}

			public object GetService(Type service)
			{
				return null;
			}
		}

		private ISite[] sites;

		private int siteCount;

		private ComponentCollection components;

		private ContainerFilterService filter;

		private bool checkedFilter;

		private object syncObj;

		public virtual ComponentCollection Components => null;

		~Container()
		{
		}

		public virtual void Add(IComponent component)
		{
		}

		public virtual void Add(IComponent component, string name)
		{
		}

		protected virtual ISite CreateSite(IComponent component, string name)
		{
			return null;
		}

		public void Dispose()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		protected virtual object GetService(Type service)
		{
			return null;
		}

		public virtual void Remove(IComponent component)
		{
		}

		private void Remove(IComponent component, bool preserveSite)
		{
		}

		protected void RemoveWithoutUnsiting(IComponent component)
		{
		}

		protected virtual void ValidateName(IComponent component, string name)
		{
		}
	}
}
