namespace System.ComponentModel
{
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
	public sealed class ProvidePropertyAttribute : Attribute
	{
		public string PropertyName { get; }

		public string ReceiverTypeName { get; }

		public override object TypeId => null;

		public ProvidePropertyAttribute(string propertyName, Type receiverType)
		{
		}

		public ProvidePropertyAttribute(string propertyName, string receiverTypeName)
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
	}
}
