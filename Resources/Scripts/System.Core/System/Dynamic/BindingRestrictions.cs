using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;

namespace System.Dynamic
{
	[DebuggerDisplay("{DebugView}")]
	[DebuggerTypeProxy(typeof(BindingRestrictionsProxy))]
	public abstract class BindingRestrictions
	{
		private sealed class TestBuilder
		{
			private struct AndNode
			{
				internal int Depth;

				internal Expression Node;
			}

			private readonly HashSet<BindingRestrictions> _unique;

			private readonly Stack<AndNode> _tests;

			internal void Append(BindingRestrictions restrictions)
			{
			}

			internal Expression ToExpression()
			{
				return null;
			}

			private void Push(Expression node, int depth)
			{
			}
		}

		private sealed class MergedRestriction : BindingRestrictions
		{
			internal readonly BindingRestrictions Left;

			internal readonly BindingRestrictions Right;

			internal MergedRestriction(BindingRestrictions left, BindingRestrictions right)
			{
			}

			internal override Expression GetExpression()
			{
				return null;
			}
		}

		private sealed class CustomRestriction : BindingRestrictions
		{
			private readonly Expression _expression;

			internal CustomRestriction(Expression expression)
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

			internal override Expression GetExpression()
			{
				return null;
			}
		}

		private sealed class TypeRestriction : BindingRestrictions
		{
			private readonly Expression _expression;

			private readonly Type _type;

			internal TypeRestriction(Expression parameter, Type type)
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

			internal override Expression GetExpression()
			{
				return null;
			}
		}

		private sealed class InstanceRestriction : BindingRestrictions
		{
			private readonly Expression _expression;

			private readonly object _instance;

			internal InstanceRestriction(Expression parameter, object instance)
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

			internal override Expression GetExpression()
			{
				return null;
			}
		}

		private sealed class BindingRestrictionsProxy
		{
		}

		public static readonly BindingRestrictions Empty;

		private BindingRestrictions()
		{
		}

		internal abstract Expression GetExpression();

		public BindingRestrictions Merge(BindingRestrictions restrictions)
		{
			return null;
		}

		public static BindingRestrictions GetTypeRestriction(Expression expression, Type type)
		{
			return null;
		}

		internal static BindingRestrictions GetTypeRestriction(DynamicMetaObject obj)
		{
			return null;
		}

		public static BindingRestrictions GetInstanceRestriction(Expression expression, object instance)
		{
			return null;
		}

		public Expression ToExpression()
		{
			return null;
		}
	}
}
