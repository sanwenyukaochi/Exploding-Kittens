namespace System.ComponentModel
{
	[AttributeUsage(AttributeTargets.All)]
	public sealed class DesignOnlyAttribute : Attribute
	{
		public static readonly DesignOnlyAttribute Yes;

		public static readonly DesignOnlyAttribute No;

		public static readonly DesignOnlyAttribute Default;

		public bool IsDesignOnly { get; }

		public DesignOnlyAttribute(bool isDesignOnly)
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
