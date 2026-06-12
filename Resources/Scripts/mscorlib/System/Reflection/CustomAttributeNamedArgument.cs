namespace System.Reflection
{
	public struct CustomAttributeNamedArgument
	{
		private readonly Type _attributeType;

		private MemberInfo _lazyMemberInfo;

		public CustomAttributeTypedArgument TypedValue { get; }

		public bool IsField { get; }

		public string MemberName { get; }

		public MemberInfo MemberInfo => null;

		internal CustomAttributeNamedArgument(Type attributeType, string memberName, bool isField, CustomAttributeTypedArgument typedValue)
		{
			TypedValue = default(CustomAttributeTypedArgument);
			IsField = false;
			MemberName = null;
			_attributeType = null;
			_lazyMemberInfo = null;
		}

		public CustomAttributeNamedArgument(MemberInfo memberInfo, object value)
		{
			TypedValue = default(CustomAttributeTypedArgument);
			IsField = false;
			MemberName = null;
			_attributeType = null;
			_lazyMemberInfo = null;
		}

		public CustomAttributeNamedArgument(MemberInfo memberInfo, CustomAttributeTypedArgument typedArgument)
		{
			TypedValue = default(CustomAttributeTypedArgument);
			IsField = false;
			MemberName = null;
			_attributeType = null;
			_lazyMemberInfo = null;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public static bool operator ==(CustomAttributeNamedArgument left, CustomAttributeNamedArgument right)
		{
			return false;
		}

		public static bool operator !=(CustomAttributeNamedArgument left, CustomAttributeNamedArgument right)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
