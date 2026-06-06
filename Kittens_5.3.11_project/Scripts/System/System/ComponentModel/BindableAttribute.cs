namespace System.ComponentModel
{
	[AttributeUsage(AttributeTargets.All)]
	public sealed class BindableAttribute : Attribute
	{
		public static readonly BindableAttribute Yes;

		public static readonly BindableAttribute No;

		public static readonly BindableAttribute Default;

		private bool _isDefault;

		public bool Bindable { get; }

		public BindingDirection Direction { get; }

		public BindableAttribute(bool bindable)
		{
		}

		public BindableAttribute(bool bindable, BindingDirection direction)
		{
		}

		public BindableAttribute(BindableSupport flags)
		{
		}

		public BindableAttribute(BindableSupport flags, BindingDirection direction)
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
