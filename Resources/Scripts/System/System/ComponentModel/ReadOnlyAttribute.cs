namespace System.ComponentModel
{
	[AttributeUsage(AttributeTargets.All)]
	public sealed class ReadOnlyAttribute : Attribute
	{
		public static readonly ReadOnlyAttribute Yes;

		public static readonly ReadOnlyAttribute No;

		public static readonly ReadOnlyAttribute Default;

		public bool IsReadOnly { get; }

		public ReadOnlyAttribute(bool isReadOnly)
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
