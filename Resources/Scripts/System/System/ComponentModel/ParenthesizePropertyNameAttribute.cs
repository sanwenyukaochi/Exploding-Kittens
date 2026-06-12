namespace System.ComponentModel
{
	[AttributeUsage(AttributeTargets.All)]
	public sealed class ParenthesizePropertyNameAttribute : Attribute
	{
		public static readonly ParenthesizePropertyNameAttribute Default;

		private bool needParenthesis;

		public bool NeedParenthesis => false;

		public ParenthesizePropertyNameAttribute()
		{
		}

		public ParenthesizePropertyNameAttribute(bool needParenthesis)
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
