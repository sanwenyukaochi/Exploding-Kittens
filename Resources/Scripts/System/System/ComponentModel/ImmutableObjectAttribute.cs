namespace System.ComponentModel
{
	[AttributeUsage(AttributeTargets.All)]
	public sealed class ImmutableObjectAttribute : Attribute
	{
		public static readonly ImmutableObjectAttribute Yes;

		public static readonly ImmutableObjectAttribute No;

		public static readonly ImmutableObjectAttribute Default;

		public bool Immutable { get; }

		public ImmutableObjectAttribute(bool immutable)
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
