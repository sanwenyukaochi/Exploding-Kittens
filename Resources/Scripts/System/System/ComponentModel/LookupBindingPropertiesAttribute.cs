namespace System.ComponentModel
{
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class LookupBindingPropertiesAttribute : Attribute
	{
		public static readonly LookupBindingPropertiesAttribute Default;

		public string DataSource { get; }

		public string DisplayMember { get; }

		public string ValueMember { get; }

		public string LookupMember { get; }

		public LookupBindingPropertiesAttribute()
		{
		}

		public LookupBindingPropertiesAttribute(string dataSource, string displayMember, string valueMember, string lookupMember)
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
