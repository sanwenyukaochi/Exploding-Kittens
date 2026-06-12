namespace System.Dynamic
{
	public abstract class GetMemberBinder : DynamicMetaObjectBinder
	{
		public sealed override Type ReturnType => null;

		public string Name { get; }

		public bool IgnoreCase { get; }

		internal sealed override bool IsStandardBinder => false;

		protected GetMemberBinder(string name, bool ignoreCase)
		{
		}

		public DynamicMetaObject FallbackGetMember(DynamicMetaObject target)
		{
			return null;
		}

		public abstract DynamicMetaObject FallbackGetMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion);

		public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
		{
			return null;
		}
	}
}
