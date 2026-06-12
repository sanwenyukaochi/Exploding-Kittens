namespace System.Collections.Generic
{
	public sealed class LinkedListNode<T>
	{
		internal LinkedList<T> list;

		internal LinkedListNode<T> next;

		internal LinkedListNode<T> prev;

		internal T item;

		public LinkedListNode<T> Next => null;

		public T Value => default(T);

		internal LinkedListNode(LinkedList<T> list, T value)
		{
		}

		internal void Invalidate()
		{
		}
	}
}
