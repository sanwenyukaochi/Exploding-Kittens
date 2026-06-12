namespace System.ComponentModel
{
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class ComplexBindingPropertiesAttribute : Attribute
	{
		public static readonly ComplexBindingPropertiesAttribute Default;

		public string DataSource { get; }

		public string DataMember { get; }

		public ComplexBindingPropertiesAttribute()
		{
		}

		public ComplexBindingPropertiesAttribute(string dataSource)
		{
		}

		public ComplexBindingPropertiesAttribute(string dataSource, string dataMember)
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
