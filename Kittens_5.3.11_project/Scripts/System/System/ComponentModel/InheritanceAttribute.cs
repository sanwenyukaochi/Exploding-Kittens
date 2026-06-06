namespace System.ComponentModel
{
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event)]
	public sealed class InheritanceAttribute : Attribute
	{
		public static readonly InheritanceAttribute Inherited;

		public static readonly InheritanceAttribute InheritedReadOnly;

		public static readonly InheritanceAttribute NotInherited;

		public static readonly InheritanceAttribute Default;

		public InheritanceLevel InheritanceLevel { get; }

		public InheritanceAttribute()
		{
		}

		public InheritanceAttribute(InheritanceLevel inheritanceLevel)
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

		public override string ToString()
		{
			return null;
		}
	}
}
