namespace System.ComponentModel
{
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class DataObjectAttribute : Attribute
	{
		public static readonly DataObjectAttribute DataObject;

		public static readonly DataObjectAttribute NonDataObject;

		public static readonly DataObjectAttribute Default;

		public bool IsDataObject { get; }

		public DataObjectAttribute()
		{
		}

		public DataObjectAttribute(bool isDataObject)
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
