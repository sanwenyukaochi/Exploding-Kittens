using System.Collections.Generic;
using System.Linq.Expressions;

namespace System.Dynamic
{
	public class DynamicMetaObject
	{
		public static readonly DynamicMetaObject[] EmptyMetaObjects;

		private static readonly object s_noValueSentinel;

		private readonly object _value;

		public Expression Expression { get; }

		public BindingRestrictions Restrictions { get; }

		public object Value => null;

		public bool HasValue => false;

		public Type RuntimeType => null;

		public Type LimitType => null;

		public DynamicMetaObject(Expression expression, BindingRestrictions restrictions)
		{
		}

		public DynamicMetaObject(Expression expression, BindingRestrictions restrictions, object value)
		{
		}

		public virtual DynamicMetaObject BindConvert(ConvertBinder binder)
		{
			return null;
		}

		public virtual DynamicMetaObject BindGetMember(GetMemberBinder binder)
		{
			return null;
		}

		public virtual DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value)
		{
			return null;
		}

		public virtual DynamicMetaObject BindDeleteMember(DeleteMemberBinder binder)
		{
			return null;
		}

		public virtual DynamicMetaObject BindGetIndex(GetIndexBinder binder, DynamicMetaObject[] indexes)
		{
			return null;
		}

		public virtual DynamicMetaObject BindSetIndex(SetIndexBinder binder, DynamicMetaObject[] indexes, DynamicMetaObject value)
		{
			return null;
		}

		public virtual DynamicMetaObject BindDeleteIndex(DeleteIndexBinder binder, DynamicMetaObject[] indexes)
		{
			return null;
		}

		public virtual DynamicMetaObject BindInvokeMember(InvokeMemberBinder binder, DynamicMetaObject[] args)
		{
			return null;
		}

		public virtual DynamicMetaObject BindInvoke(InvokeBinder binder, DynamicMetaObject[] args)
		{
			return null;
		}

		public virtual DynamicMetaObject BindCreateInstance(CreateInstanceBinder binder, DynamicMetaObject[] args)
		{
			return null;
		}

		public virtual DynamicMetaObject BindUnaryOperation(UnaryOperationBinder binder)
		{
			return null;
		}

		public virtual DynamicMetaObject BindBinaryOperation(BinaryOperationBinder binder, DynamicMetaObject arg)
		{
			return null;
		}

		public virtual IEnumerable<string> GetDynamicMemberNames()
		{
			return null;
		}

		public static DynamicMetaObject Create(object value, Expression expression)
		{
			return null;
		}
	}
}
