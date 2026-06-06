namespace System.ComponentModel
{
	[AttributeUsage(AttributeTargets.All)]
	public sealed class MergablePropertyAttribute : Attribute
	{
		public static readonly MergablePropertyAttribute Yes;

		public static readonly MergablePropertyAttribute No;

		public static readonly MergablePropertyAttribute Default;

		public bool AllowMerge { get; }

		public MergablePropertyAttribute(bool allowMerge)
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
