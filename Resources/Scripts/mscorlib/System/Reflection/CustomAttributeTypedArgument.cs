namespace System.Reflection
{
	public struct CustomAttributeTypedArgument
	{
		public Type ArgumentType { get; }

		public object Value { get; }

		public CustomAttributeTypedArgument(object value)
		{
			ArgumentType = null;
			Value = null;
		}

		public CustomAttributeTypedArgument(Type argumentType, object value)
		{
			ArgumentType = null;
			Value = null;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public static bool operator ==(CustomAttributeTypedArgument left, CustomAttributeTypedArgument right)
		{
			return false;
		}

		public static bool operator !=(CustomAttributeTypedArgument left, CustomAttributeTypedArgument right)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}

		internal string ToString(bool typed)
		{
			return null;
		}

		private static object CanonicalizeValue(object value)
		{
			return null;
		}
	}
}
