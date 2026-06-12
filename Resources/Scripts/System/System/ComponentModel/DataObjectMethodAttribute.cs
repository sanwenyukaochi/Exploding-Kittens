namespace System.ComponentModel
{
	[AttributeUsage(AttributeTargets.Method)]
	public sealed class DataObjectMethodAttribute : Attribute
	{
		public bool IsDefault { get; }

		public DataObjectMethodType MethodType { get; }

		public DataObjectMethodAttribute(DataObjectMethodType methodType)
		{
		}

		public DataObjectMethodAttribute(DataObjectMethodType methodType, bool isDefault)
		{
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Match(object obj)
		{
			return false;
		}
	}
}
