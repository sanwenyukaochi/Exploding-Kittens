namespace System.ComponentModel
{
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
	public sealed class LicenseProviderAttribute : Attribute
	{
		public static readonly LicenseProviderAttribute Default;

		private Type _licenseProviderType;

		private string _licenseProviderName;

		public Type LicenseProvider => null;

		public override object TypeId => null;

		public LicenseProviderAttribute()
		{
		}

		public LicenseProviderAttribute(string typeName)
		{
		}

		public LicenseProviderAttribute(Type type)
		{
		}

		public override bool Equals(object value)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
