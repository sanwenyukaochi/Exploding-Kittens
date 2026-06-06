using System.Collections.ObjectModel;

namespace System.Linq.Expressions
{
	public abstract class ExpressionVisitor
	{
		public virtual Expression Visit(Expression node)
		{
			return null;
		}

		public ReadOnlyCollection<Expression> Visit(ReadOnlyCollection<Expression> nodes)
		{
			return null;
		}

		private Expression[] VisitArguments(IArgumentProvider nodes)
		{
			return null;
		}

		private ParameterExpression[] VisitParameters(IParameterProvider nodes, string callerName)
		{
			return null;
		}

		public static ReadOnlyCollection<T> Visit<T>(ReadOnlyCollection<T> nodes, Func<T, T> elementVisitor)
		{
			return null;
		}

		public T VisitAndConvert<T>(T node, string callerName) where T : Expression
		{
			return null;
		}

		public ReadOnlyCollection<T> VisitAndConvert<T>(ReadOnlyCollection<T> nodes, string callerName) where T : Expression
		{
			return null;
		}

		protected internal virtual Expression VisitBinary(BinaryExpression node)
		{
			return null;
		}

		protected internal virtual Expression VisitBlock(BlockExpression node)
		{
			return null;
		}

		protected internal virtual Expression VisitConditional(ConditionalExpression node)
		{
			return null;
		}

		protected internal virtual Expression VisitConstant(ConstantExpression node)
		{
			return null;
		}

		protected internal virtual Expression VisitDefault(DefaultExpression node)
		{
			return null;
		}

		protected internal virtual Expression VisitExtension(Expression node)
		{
			return null;
		}

		protected internal virtual Expression VisitGoto(GotoExpression node)
		{
			return null;
		}

		protected internal virtual Expression VisitInvocation(InvocationExpression node)
		{
			return null;
		}

		protected virtual LabelTarget VisitLabelTarget(LabelTarget node)
		{
			return null;
		}

		protected internal virtual Expression VisitLabel(LabelExpression node)
		{
			return null;
		}

		protected internal virtual Expression VisitLambda<T>(Expression<T> node)
		{
			return null;
		}

		protected internal virtual Expression VisitLoop(LoopExpression node)
		{
			return null;
		}

		protected internal virtual Expression VisitMember(MemberExpression node)
		{
			return null;
		}

		protected internal virtual Expression VisitIndex(IndexExpression node)
		{
			return null;
		}

		protected internal virtual Expression VisitMethodCall(MethodCallExpression node)
		{
			return null;
		}

		protected internal virtual Expression VisitNewArray(NewArrayExpression node)
		{
			return null;
		}

		protected internal virtual Expression VisitParameter(ParameterExpression node)
		{
			return null;
		}

		protected virtual CatchBlock VisitCatchBlock(CatchBlock node)
		{
			return null;
		}

		protected internal virtual Expression VisitTry(TryExpression node)
		{
			return null;
		}

		protected internal virtual Expression VisitTypeBinary(TypeBinaryExpression node)
		{
			return null;
		}

		protected internal virtual Expression VisitUnary(UnaryExpression node)
		{
			return null;
		}

		private static UnaryExpression ValidateUnary(UnaryExpression before, UnaryExpression after)
		{
			return null;
		}

		private static BinaryExpression ValidateBinary(BinaryExpression before, BinaryExpression after)
		{
			return null;
		}

		private static void ValidateChildType(Type before, Type after, string methodName)
		{
		}
	}
}
