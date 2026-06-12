using System.Runtime.InteropServices;

namespace System.ComponentModel
{
	[ComVisible(true)]
	[DesignerCategory("Component")]
	[ClassInterface(ClassInterfaceType.AutoDispatch)]
	public class Component : MarshalByRefObject, IComponent, IDisposable
	{
		private static readonly object EventDisposed;

		private ISite site;

		private EventHandlerList events;

		protected virtual bool CanRaiseEvents => false;

		internal bool CanRaiseEventsInternal => false;

		protected EventHandlerList Events => null;

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
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

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public IContainer Container => null;

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		protected bool DesignMode => false;

		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public event EventHandler Disposed
		{
			add
			{
			}
			remove
			{
			}
		}

		~Component()
		{
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

		public override string ToString()
		{
			return null;
		}
	}
}
