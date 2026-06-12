namespace System.Runtime.CompilerServices
{
	public class StrongBox<T> : IStrongBox
	{
		public T Value;

		object IStrongBox.Value
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public StrongBox()
		{
		}

		public StrongBox(T value)
		{
		}
	}
}
