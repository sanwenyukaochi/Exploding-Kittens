namespace System.ComponentModel
{
	[AttributeUsage(AttributeTargets.All)]
	public sealed class ListBindableAttribute : Attribute
	{
		public static readonly ListBindableAttribute Yes;

		public static readonly ListBindableAttribute No;

		public static readonly ListBindableAttribute Default;

		private bool _isDefault;

		public bool ListBindable { get; }

		public ListBindableAttribute(bool listBindable)
		{
		}

		public ListBindableAttribute(BindableSupport flags)
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
