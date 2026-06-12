namespace System.ComponentModel
{
	public sealed class EventHandlerList : IDisposable
	{
		private sealed class ListEntry
		{
			internal ListEntry _next;

			internal object _key;

			internal Delegate _handler;

			public ListEntry(object key, Delegate handler, ListEntry next)
			{
			}
		}

		private ListEntry _head;

		private Component _parent;

		public Delegate this[object key]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal EventHandlerList(Component parent)
		{
		}

		public EventHandlerList()
		{
		}

		public void AddHandler(object key, Delegate value)
		{
		}

		public void AddHandlers(EventHandlerList listToAddFrom)
		{
		}

		public void Dispose()
		{
		}

		private ListEntry Find(object key)
		{
			return null;
		}

		public void RemoveHandler(object key, Delegate value)
		{
		}
	}
}
