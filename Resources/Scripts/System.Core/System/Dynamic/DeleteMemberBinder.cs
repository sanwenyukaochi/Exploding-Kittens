namespace System.Dynamic
{
	public abstract class DeleteMemberBinder : DynamicMetaObjectBinder
	{
		public string Name { get; }

		public bool IgnoreCase { get; }

		public DynamicMetaObject FallbackDeleteMember(DynamicMetaObject target)
		{
			return null;
		}

		public abstract DynamicMetaObject FallbackDeleteMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion);

		public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
		{
			return null;
		}
	}
}
