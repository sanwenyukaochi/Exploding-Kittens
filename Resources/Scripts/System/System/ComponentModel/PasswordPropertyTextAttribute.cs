namespace System.ComponentModel
{
	[AttributeUsage(AttributeTargets.All)]
	public sealed class PasswordPropertyTextAttribute : Attribute
	{
		public static readonly PasswordPropertyTextAttribute Yes;

		public static readonly PasswordPropertyTextAttribute No;

		public static readonly PasswordPropertyTextAttribute Default;

		public bool Password { get; }

		public PasswordPropertyTextAttribute()
		{
		}

		public PasswordPropertyTextAttribute(bool password)
		{
		}

		public override bool Equals(object o)
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
