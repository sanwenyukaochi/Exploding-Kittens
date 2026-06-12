namespace System.ComponentModel
{
	[TypeConverter(typeof(ComponentConverter))]
	[DesignerCategory("Component")]
	public class MarshalByValueComponent : IComponent, IDisposable, IServiceProvider
	{
		private static readonly object s_eventDisposed;

		private ISite _site;

		private EventHandlerList _events;

		protected EventHandlerList Events => null;

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public virtual ISite Site
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public virtual IContainer Container => null;

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public virtual bool DesignMode => false;

		public event EventHandler Disposed
		{
			add
			{
			}
			remove
			{
			}
		}

		~MarshalByValueComponent()
		{
		}

		public void Dispose()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		public virtual object GetService(Type service)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
