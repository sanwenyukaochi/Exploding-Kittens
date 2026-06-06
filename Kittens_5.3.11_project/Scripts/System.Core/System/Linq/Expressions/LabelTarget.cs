namespace System.Linq.Expressions
{
	public sealed class LabelTarget
	{
		public string Name { get; }

		public Type Type { get; }

		internal LabelTarget(Type type, string name)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
