namespace System.ComponentModel
{
	[AttributeUsage(AttributeTargets.All)]
	public sealed class RefreshPropertiesAttribute : Attribute
	{
		public static readonly RefreshPropertiesAttribute All;

		public static readonly RefreshPropertiesAttribute Repaint;

		public static readonly RefreshPropertiesAttribute Default;

		private RefreshProperties refresh;

		public RefreshProperties RefreshProperties => default(RefreshProperties);

		public RefreshPropertiesAttribute(RefreshProperties refresh)
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

		public override bool IsDefaultAttribute()
		{
			return false;
		}
	}
}
