namespace System.ComponentModel
{
	[AttributeUsage(AttributeTargets.All)]
	public sealed class LocalizableAttribute : Attribute
	{
		public static readonly LocalizableAttribute Yes;

		public static readonly LocalizableAttribute No;

		public static readonly LocalizableAttribute Default;

		public bool IsLocalizable { get; }

		public LocalizableAttribute(bool isLocalizable)
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

		public override bool IsDefaultAttribute()
		{
			return false;
		}
	}
}
