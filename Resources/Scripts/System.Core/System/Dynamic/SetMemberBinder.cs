namespace System.Dynamic
{
	public abstract class SetMemberBinder : DynamicMetaObjectBinder
	{
		public sealed override Type ReturnType => null;

		public string Name { get; }

		public bool IgnoreCase { get; }

		internal sealed override bool IsStandardBinder => false;

		protected SetMemberBinder(string name, bool ignoreCase)
		{
		}

		public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
		{
			return null;
		}

		public DynamicMetaObject FallbackSetMember(DynamicMetaObject target, DynamicMetaObject value)
		{
			return null;
		}

		public abstract DynamicMetaObject FallbackSetMember(DynamicMetaObject target, DynamicMetaObject value, DynamicMetaObject errorSuggestion);
	}
}
