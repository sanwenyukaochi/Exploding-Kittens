namespace System.ComponentModel
{
	public class ListChangedEventArgs : EventArgs
	{
		public ListChangedType ListChangedType { get; }

		public int NewIndex { get; }

		public int OldIndex { get; }

		public PropertyDescriptor PropertyDescriptor { get; }

		public ListChangedEventArgs(ListChangedType listChangedType, int newIndex)
		{
		}

		public ListChangedEventArgs(ListChangedType listChangedType, int newIndex, PropertyDescriptor propDesc)
		{
		}

		public ListChangedEventArgs(ListChangedType listChangedType, PropertyDescriptor propDesc)
		{
		}

		public ListChangedEventArgs(ListChangedType listChangedType, int newIndex, int oldIndex)
		{
		}
	}
}
