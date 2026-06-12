namespace System.ComponentModel
{
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class DefaultBindingPropertyAttribute : Attribute
	{
		public static readonly DefaultBindingPropertyAttribute Default;

		public string Name { get; }

		public DefaultBindingPropertyAttribute()
		{
		}

		public DefaultBindingPropertyAttribute(string name)
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
