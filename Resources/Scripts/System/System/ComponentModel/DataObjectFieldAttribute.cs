namespace System.ComponentModel
{
	[AttributeUsage(AttributeTargets.Property)]
	public sealed class DataObjectFieldAttribute : Attribute
	{
		public bool IsIdentity { get; }

		public bool IsNullable { get; }

		public int Length { get; }

		public bool PrimaryKey { get; }

		public DataObjectFieldAttribute(bool primaryKey)
		{
		}

		public DataObjectFieldAttribute(bool primaryKey, bool isIdentity)
		{
		}

		public DataObjectFieldAttribute(bool primaryKey, bool isIdentity, bool isNullable)
		{
		}

		public DataObjectFieldAttribute(bool primaryKey, bool isIdentity, bool isNullable, int length)
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
	}
}
