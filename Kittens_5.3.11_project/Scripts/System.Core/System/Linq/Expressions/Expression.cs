using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic.Utils;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace System.Linq.Expressions
{
	public abstract class Expression
	{
		internal class BinaryExpressionProxy
		{
		}

		internal class BlockExpressionProxy
		{
		}

		internal class CatchBlockProxy
		{
		}

		internal class ConditionalExpressionProxy
		{
		}

		internal class ConstantExpressionProxy
		{
		}

		internal class DebugInfoExpressionProxy
		{
		}

		internal class DefaultExpressionProxy
		{
		}

		internal class GotoExpressionProxy
		{
		}

		internal class IndexExpressionProxy
		{
		}

		internal class InvocationExpressionProxy
		{
		}

		internal class LabelExpressionProxy
		{
		}

		internal class LambdaExpressionProxy
		{
		}

		internal class ListInitExpressionProxy
		{
		}

		internal class LoopExpressionProxy
		{
		}

		internal class MemberExpressionProxy
		{
		}

		internal class MemberInitExpressionProxy
		{
		}

		internal class MethodCallExpressionProxy
		{
		}

		internal class NewArrayExpressionProxy
		{
		}

		internal class NewExpressionProxy
		{
		}

		internal class ParameterExpressionProxy
		{
		}

		internal class RuntimeVariablesExpressionProxy
		{
		}

		internal class SwitchCaseProxy
		{
		}

		internal class SwitchExpressionProxy
		{
		}

		internal class TryExpressionProxy
		{
		}

		internal class TypeBinaryExpressionProxy
		{
		}

		internal class UnaryExpressionProxy
		{
		}

		private class ExtensionInfo
		{
			internal readonly ExpressionType NodeType;

			internal readonly Type Type;
		}

		private static readonly CacheDict<Type, MethodInfo> s_lambdaDelegateCache;

		private static CacheDict<Type, Func<Expression, string, bool, ReadOnlyCollection<ParameterExpression>, LambdaExpression>> s_lambdaFactories;

		private static ConditionalWeakTable<Expression, ExtensionInfo> s_legacyCtorSupportTable;

		public virtual ExpressionType NodeType => default(ExpressionType);

		public virtual Type Type => null;

		public virtual bool CanReduce => false;

		public static BinaryExpression Assign(Expression left, Expression right)
		{
			return null;
		}

		private static BinaryExpression GetUserDefinedBinaryOperator(ExpressionType binaryType, string name, Expression left, Expression right, bool liftToNull)
		{
			return null;
		}

		private static BinaryExpression GetMethodBasedBinaryOperator(ExpressionType binaryType, Expression left, Expression right, MethodInfo method, bool liftToNull)
		{
			return null;
		}

		private static BinaryExpression GetMethodBasedAssignOperator(ExpressionType binaryType, Expression left, Expression right, MethodInfo method, LambdaExpression conversion, bool liftToNull)
		{
			return null;
		}

		private static BinaryExpression GetUserDefinedBinaryOperatorOrThrow(ExpressionType binaryType, string name, Expression left, Expression right, bool liftToNull)
		{
			return null;
		}

		private static BinaryExpression GetUserDefinedAssignOperatorOrThrow(ExpressionType binaryType, string name, Expression left, Expression right, LambdaExpression conversion, bool liftToNull)
		{
			return null;
		}

		private static MethodInfo GetUserDefinedBinaryOperator(ExpressionType binaryType, Type leftType, Type rightType, string name)
		{
			return null;
		}

		private static bool IsLiftingConditionalLogicalOperator(Type left, Type right, MethodInfo method, ExpressionType binaryType)
		{
			return false;
		}

		internal static bool ParameterIsAssignable(ParameterInfo pi, Type argType)
		{
			return false;
		}

		private static void ValidateParamswithOperandsOrThrow(Type paramType, Type operandType, ExpressionType exprType, string name)
		{
		}

		private static void ValidateOperator(MethodInfo method)
		{
		}

		private static void ValidateMethodInfo(MethodInfo method, string paramName)
		{
		}

		private static bool IsNullComparison(Expression left, Expression right)
		{
			return false;
		}

		private static bool IsNullConstant(Expression e)
		{
			return false;
		}

		private static void ValidateUserDefinedConditionalLogicOperator(ExpressionType nodeType, Type left, Type right, MethodInfo method)
		{
		}

		private static void VerifyOpTrueFalse(ExpressionType nodeType, Type left, MethodInfo opTrue, string paramName)
		{
		}

		private static bool IsValidLiftedConditionalLogicalOperator(Type left, Type right, ParameterInfo[] pms)
		{
			return false;
		}

		public static BinaryExpression MakeBinary(ExpressionType binaryType, Expression left, Expression right, bool liftToNull, MethodInfo method)
		{
			return null;
		}

		public static BinaryExpression MakeBinary(ExpressionType binaryType, Expression left, Expression right, bool liftToNull, MethodInfo method, LambdaExpression conversion)
		{
			return null;
		}

		public static BinaryExpression Equal(Expression left, Expression right)
		{
			return null;
		}

		public static BinaryExpression Equal(Expression left, Expression right, bool liftToNull, MethodInfo method)
		{
			return null;
		}

		public static BinaryExpression ReferenceEqual(Expression left, Expression right)
		{
			return null;
		}

		public static BinaryExpression NotEqual(Expression left, Expression right)
		{
			return null;
		}

		public static BinaryExpression NotEqual(Expression left, Expression right, bool liftToNull, MethodInfo method)
		{
			return null;
		}

		public static BinaryExpression ReferenceNotEqual(Expression left, Expression right)
		{
			return null;
		}

		private static BinaryExpression GetEqualityComparisonOperator(ExpressionType binaryType, string opName, Expression left, Expression right, bool liftToNull)
		{
			return null;
		}

		public static BinaryExpression GreaterThan(Expression left, Expression right, bool liftToNull, MethodInfo method)
		{
			return null;
		}

		public static BinaryExpression LessThan(Expression left, Expression right, bool liftToNull, MethodInfo method)
		{
			return null;
		}

		public static BinaryExpression GreaterThanOrEqual(Expression left, Expression right, bool liftToNull, MethodInfo method)
		{
			return null;
		}

		public static BinaryExpression LessThanOrEqual(Expression left, Expression right, bool liftToNull, MethodInfo method)
		{
			return null;
		}

		private static BinaryExpression GetComparisonOperator(ExpressionType binaryType, string opName, Expression left, Expression right, bool liftToNull)
		{
			return null;
		}

		public static BinaryExpression AndAlso(Expression left, Expression right)
		{
			return null;
		}

		public static BinaryExpression AndAlso(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		public static BinaryExpression OrElse(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		public static BinaryExpression Coalesce(Expression left, Expression right, LambdaExpression conversion)
		{
			return null;
		}

		private static Type ValidateCoalesceArgTypes(Type left, Type right)
		{
			return null;
		}

		public static BinaryExpression Add(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		public static BinaryExpression AddAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
		{
			return null;
		}

		private static void ValidateOpAssignConversionLambda(LambdaExpression conversion, Expression left, MethodInfo method, ExpressionType nodeType)
		{
		}

		public static BinaryExpression AddAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
		{
			return null;
		}

		public static BinaryExpression AddChecked(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		public static BinaryExpression Subtract(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		public static BinaryExpression SubtractAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
		{
			return null;
		}

		public static BinaryExpression SubtractAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
		{
			return null;
		}

		public static BinaryExpression SubtractChecked(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		public static BinaryExpression Divide(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		public static BinaryExpression DivideAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
		{
			return null;
		}

		public static BinaryExpression Modulo(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		public static BinaryExpression ModuloAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
		{
			return null;
		}

		public static BinaryExpression Multiply(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		public static BinaryExpression MultiplyAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
		{
			return null;
		}

		public static BinaryExpression MultiplyAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
		{
			return null;
		}

		public static BinaryExpression MultiplyChecked(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		private static bool IsSimpleShift(Type left, Type right)
		{
			return false;
		}

		private static Type GetResultTypeOfShift(Type left, Type right)
		{
			return null;
		}

		public static BinaryExpression LeftShift(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		public static BinaryExpression LeftShiftAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
		{
			return null;
		}

		public static BinaryExpression RightShift(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		public static BinaryExpression RightShiftAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
		{
			return null;
		}

		public static BinaryExpression And(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		public static BinaryExpression AndAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
		{
			return null;
		}

		public static BinaryExpression Or(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		public static BinaryExpression OrAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
		{
			return null;
		}

		public static BinaryExpression ExclusiveOr(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		public static BinaryExpression ExclusiveOrAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
		{
			return null;
		}

		public static BinaryExpression Power(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		public static BinaryExpression PowerAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
		{
			return null;
		}

		public static BinaryExpression ArrayIndex(Expression array, Expression index)
		{
			return null;
		}

		public static BlockExpression Block(Expression arg0, Expression arg1)
		{
			return null;
		}

		public static BlockExpression Block(Expression arg0, Expression arg1, Expression arg2)
		{
			return null;
		}

		public static BlockExpression Block(Expression arg0, Expression arg1, Expression arg2, Expression arg3)
		{
			return null;
		}

		public static BlockExpression Block(Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4)
		{
			return null;
		}

		public static BlockExpression Block(IEnumerable<Expression> expressions)
		{
			return null;
		}

		public static BlockExpression Block(Type type, params Expression[] expressions)
		{
			return null;
		}

		public static BlockExpression Block(Type type, IEnumerable<Expression> expressions)
		{
			return null;
		}

		public static BlockExpression Block(IEnumerable<ParameterExpression> variables, params Expression[] expressions)
		{
			return null;
		}

		public static BlockExpression Block(Type type, IEnumerable<ParameterExpression> variables, params Expression[] expressions)
		{
			return null;
		}

		public static BlockExpression Block(IEnumerable<ParameterExpression> variables, IEnumerable<Expression> expressions)
		{
			return null;
		}

		public static BlockExpression Block(Type type, IEnumerable<ParameterExpression> variables, IEnumerable<Expression> expressions)
		{
			return null;
		}

		private static BlockExpression BlockCore(Type type, ReadOnlyCollection<ParameterExpression> variables, ReadOnlyCollection<Expression> expressions)
		{
			return null;
		}

		internal static void ValidateVariables(ReadOnlyCollection<ParameterExpression> varList, string collectionName)
		{
		}

		private static BlockExpression GetOptimizedBlockExpression(IReadOnlyList<Expression> expressions)
		{
			return null;
		}

		public static CatchBlock MakeCatchBlock(Type type, ParameterExpression variable, Expression body, Expression filter)
		{
			return null;
		}

		public static ConditionalExpression Condition(Expression test, Expression ifTrue, Expression ifFalse)
		{
			return null;
		}

		public static ConditionalExpression Condition(Expression test, Expression ifTrue, Expression ifFalse, Type type)
		{
			return null;
		}

		public static ConditionalExpression IfThen(Expression test, Expression ifTrue)
		{
			return null;
		}

		public static ConstantExpression Constant(object value)
		{
			return null;
		}

		public static ConstantExpression Constant(object value, Type type)
		{
			return null;
		}

		public static DefaultExpression Empty()
		{
			return null;
		}

		public static DefaultExpression Default(Type type)
		{
			return null;
		}

		public virtual Expression Reduce()
		{
			return null;
		}

		protected internal virtual Expression VisitChildren(ExpressionVisitor visitor)
		{
			return null;
		}

		protected internal virtual Expression Accept(ExpressionVisitor visitor)
		{
			return null;
		}

		public Expression ReduceAndCheck()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		private static void RequiresCanRead(IReadOnlyList<Expression> items, string paramName)
		{
		}

		private static void RequiresCanWrite(Expression expression, string paramName)
		{
		}

		public static GotoExpression Break(LabelTarget target)
		{
			return null;
		}

		public static GotoExpression Return(LabelTarget target)
		{
			return null;
		}

		public static GotoExpression Return(LabelTarget target, Expression value)
		{
			return null;
		}

		public static GotoExpression Goto(LabelTarget target, Type type)
		{
			return null;
		}

		public static GotoExpression Goto(LabelTarget target, Expression value)
		{
			return null;
		}

		public static GotoExpression MakeGoto(GotoExpressionKind kind, LabelTarget target, Expression value, Type type)
		{
			return null;
		}

		private static void ValidateGoto(LabelTarget target, ref Expression value, string targetParameter, string valueParameter, Type type)
		{
		}

		private static void ValidateGotoType(Type expectedType, ref Expression value, string paramName)
		{
		}

		public static IndexExpression MakeIndex(Expression instance, PropertyInfo indexer, IEnumerable<Expression> arguments)
		{
			return null;
		}

		public static IndexExpression ArrayAccess(Expression array, params Expression[] indexes)
		{
			return null;
		}

		public static IndexExpression ArrayAccess(Expression array, IEnumerable<Expression> indexes)
		{
			return null;
		}

		public static IndexExpression Property(Expression instance, PropertyInfo indexer, IEnumerable<Expression> arguments)
		{
			return null;
		}

		private static IndexExpression MakeIndexProperty(Expression instance, PropertyInfo indexer, string paramName, ReadOnlyCollection<Expression> argList)
		{
			return null;
		}

		private static void ValidateIndexedProperty(Expression instance, PropertyInfo indexer, string paramName, ref ReadOnlyCollection<Expression> argList)
		{
		}

		private static void ValidateAccessor(Expression instance, MethodInfo method, ParameterInfo[] indexes, ref ReadOnlyCollection<Expression> arguments, string paramName)
		{
		}

		private static void ValidateAccessorArgumentTypes(MethodInfo method, ParameterInfo[] indexes, ref ReadOnlyCollection<Expression> arguments, string paramName)
		{
		}

		internal static InvocationExpression Invoke(Expression expression)
		{
			return null;
		}

		internal static InvocationExpression Invoke(Expression expression, Expression arg0)
		{
			return null;
		}

		internal static InvocationExpression Invoke(Expression expression, Expression arg0, Expression arg1)
		{
			return null;
		}

		internal static InvocationExpression Invoke(Expression expression, Expression arg0, Expression arg1, Expression arg2)
		{
			return null;
		}

		internal static InvocationExpression Invoke(Expression expression, Expression arg0, Expression arg1, Expression arg2, Expression arg3)
		{
			return null;
		}

		internal static InvocationExpression Invoke(Expression expression, Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4)
		{
			return null;
		}

		public static InvocationExpression Invoke(Expression expression, IEnumerable<Expression> arguments)
		{
			return null;
		}

		internal static MethodInfo GetInvokeMethod(Expression expression)
		{
			return null;
		}

		public static LabelExpression Label(LabelTarget target)
		{
			return null;
		}

		public static LabelExpression Label(LabelTarget target, Expression defaultValue)
		{
			return null;
		}

		public static LabelTarget Label()
		{
			return null;
		}

		public static LabelTarget Label(string name)
		{
			return null;
		}

		public static LabelTarget Label(Type type)
		{
			return null;
		}

		public static LabelTarget Label(Type type, string name)
		{
			return null;
		}

		internal static LambdaExpression CreateLambda(Type delegateType, Expression body, string name, bool tailCall, ReadOnlyCollection<ParameterExpression> parameters)
		{
			return null;
		}

		public static Expression<TDelegate> Lambda<TDelegate>(Expression body, params ParameterExpression[] parameters)
		{
			return null;
		}

		public static Expression<TDelegate> Lambda<TDelegate>(Expression body, IEnumerable<ParameterExpression> parameters)
		{
			return null;
		}

		public static Expression<TDelegate> Lambda<TDelegate>(Expression body, bool tailCall, IEnumerable<ParameterExpression> parameters)
		{
			return null;
		}

		public static Expression<TDelegate> Lambda<TDelegate>(Expression body, string name, bool tailCall, IEnumerable<ParameterExpression> parameters)
		{
			return null;
		}

		public static LambdaExpression Lambda(Type delegateType, Expression body, params ParameterExpression[] parameters)
		{
			return null;
		}

		public static LambdaExpression Lambda(Type delegateType, Expression body, string name, bool tailCall, IEnumerable<ParameterExpression> parameters)
		{
			return null;
		}

		private static void ValidateLambdaArgs(Type delegateType, ref Expression body, ReadOnlyCollection<ParameterExpression> parameters, string paramName)
		{
		}

		public static LoopExpression Loop(Expression body, LabelTarget @break, LabelTarget @continue)
		{
			return null;
		}

		public static MemberExpression Field(Expression expression, FieldInfo field)
		{
			return null;
		}

		public static MemberExpression Field(Expression expression, string fieldName)
		{
			return null;
		}

		public static MemberExpression Property(Expression expression, string propertyName)
		{
			return null;
		}

		public static MemberExpression Property(Expression expression, PropertyInfo property)
		{
			return null;
		}

		public static MemberExpression MakeMemberAccess(Expression expression, MemberInfo member)
		{
			return null;
		}

		internal static MethodCallExpression Call(MethodInfo method)
		{
			return null;
		}

		public static MethodCallExpression Call(MethodInfo method, Expression arg0)
		{
			return null;
		}

		public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1)
		{
			return null;
		}

		public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2)
		{
			return null;
		}

		public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3)
		{
			return null;
		}

		public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4)
		{
			return null;
		}

		public static MethodCallExpression Call(MethodInfo method, params Expression[] arguments)
		{
			return null;
		}

		public static MethodCallExpression Call(MethodInfo method, IEnumerable<Expression> arguments)
		{
			return null;
		}

		public static MethodCallExpression Call(Expression instance, MethodInfo method)
		{
			return null;
		}

		public static MethodCallExpression Call(Expression instance, MethodInfo method, params Expression[] arguments)
		{
			return null;
		}

		internal static MethodCallExpression Call(Expression instance, MethodInfo method, Expression arg0)
		{
			return null;
		}

		public static MethodCallExpression Call(Expression instance, MethodInfo method, Expression arg0, Expression arg1)
		{
			return null;
		}

		public static MethodCallExpression Call(Expression instance, MethodInfo method, Expression arg0, Expression arg1, Expression arg2)
		{
			return null;
		}

		public static MethodCallExpression Call(Expression instance, string methodName, Type[] typeArguments, params Expression[] arguments)
		{
			return null;
		}

		public static MethodCallExpression Call(Expression instance, MethodInfo method, IEnumerable<Expression> arguments)
		{
			return null;
		}

		private static ParameterInfo[] ValidateMethodAndGetParameters(Expression instance, MethodInfo method)
		{
			return null;
		}

		private static void ValidateStaticOrInstanceMethod(Expression instance, MethodInfo method)
		{
		}

		private static void ValidateCallInstanceType(Type instanceType, MethodInfo method)
		{
		}

		private static void ValidateArgumentTypes(MethodBase method, ExpressionType nodeKind, ref ReadOnlyCollection<Expression> arguments, string methodParamName)
		{
		}

		private static ParameterInfo[] GetParametersForValidation(MethodBase method, ExpressionType nodeKind)
		{
			return null;
		}

		private static void ValidateArgumentCount(MethodBase method, ExpressionType nodeKind, int count, ParameterInfo[] pis)
		{
		}

		private static Expression ValidateOneArgument(MethodBase method, ExpressionType nodeKind, Expression arg, ParameterInfo pi, string methodParamName, string argumentParamName)
		{
			return null;
		}

		private static bool TryQuote(Type parameterType, ref Expression argument)
		{
			return false;
		}

		private static MethodInfo FindMethod(Type type, string methodName, Type[] typeArgs, Expression[] args, BindingFlags flags)
		{
			return null;
		}

		private static bool IsCompatible(MethodBase m, Expression[] arguments)
		{
			return false;
		}

		private static MethodInfo ApplyTypeArgs(MethodInfo m, Type[] typeArgs)
		{
			return null;
		}

		public static NewArrayExpression NewArrayInit(Type type, params Expression[] initializers)
		{
			return null;
		}

		public static NewArrayExpression NewArrayInit(Type type, IEnumerable<Expression> initializers)
		{
			return null;
		}

		public static NewArrayExpression NewArrayBounds(Type type, IEnumerable<Expression> bounds)
		{
			return null;
		}

		public static ParameterExpression Parameter(Type type)
		{
			return null;
		}

		public static ParameterExpression Parameter(Type type, string name)
		{
			return null;
		}

		public static ParameterExpression Variable(Type type, string name)
		{
			return null;
		}

		private static void Validate(Type type, bool allowByRef)
		{
		}

		public static TryExpression TryFinally(Expression body, Expression @finally)
		{
			return null;
		}

		public static TryExpression MakeTry(Type type, Expression body, Expression @finally, Expression fault, IEnumerable<CatchBlock> handlers)
		{
			return null;
		}

		private static void ValidateTryAndCatchHaveSameType(Type type, Expression tryBody, ReadOnlyCollection<CatchBlock> handlers)
		{
		}

		public static TypeBinaryExpression TypeIs(Expression expression, Type type)
		{
			return null;
		}

		public static TypeBinaryExpression TypeEqual(Expression expression, Type type)
		{
			return null;
		}

		public static UnaryExpression MakeUnary(ExpressionType unaryType, Expression operand, Type type, MethodInfo method)
		{
			return null;
		}

		private static UnaryExpression GetUserDefinedUnaryOperatorOrThrow(ExpressionType unaryType, string name, Expression operand)
		{
			return null;
		}

		private static UnaryExpression GetUserDefinedUnaryOperator(ExpressionType unaryType, string name, Expression operand)
		{
			return null;
		}

		private static UnaryExpression GetMethodBasedUnaryOperator(ExpressionType unaryType, Expression operand, MethodInfo method)
		{
			return null;
		}

		private static UnaryExpression GetUserDefinedCoercionOrThrow(ExpressionType coercionType, Expression expression, Type convertToType)
		{
			return null;
		}

		private static UnaryExpression GetUserDefinedCoercion(ExpressionType coercionType, Expression expression, Type convertToType)
		{
			return null;
		}

		private static UnaryExpression GetMethodBasedCoercionOperator(ExpressionType unaryType, Expression operand, Type convertToType, MethodInfo method)
		{
			return null;
		}

		public static UnaryExpression Negate(Expression expression, MethodInfo method)
		{
			return null;
		}

		public static UnaryExpression UnaryPlus(Expression expression, MethodInfo method)
		{
			return null;
		}

		public static UnaryExpression NegateChecked(Expression expression, MethodInfo method)
		{
			return null;
		}

		public static UnaryExpression Not(Expression expression)
		{
			return null;
		}

		public static UnaryExpression Not(Expression expression, MethodInfo method)
		{
			return null;
		}

		public static UnaryExpression IsFalse(Expression expression, MethodInfo method)
		{
			return null;
		}

		public static UnaryExpression IsTrue(Expression expression, MethodInfo method)
		{
			return null;
		}

		public static UnaryExpression OnesComplement(Expression expression, MethodInfo method)
		{
			return null;
		}

		public static UnaryExpression TypeAs(Expression expression, Type type)
		{
			return null;
		}

		public static UnaryExpression Unbox(Expression expression, Type type)
		{
			return null;
		}

		public static UnaryExpression Convert(Expression expression, Type type)
		{
			return null;
		}

		public static UnaryExpression Convert(Expression expression, Type type, MethodInfo method)
		{
			return null;
		}

		public static UnaryExpression ConvertChecked(Expression expression, Type type, MethodInfo method)
		{
			return null;
		}

		public static UnaryExpression ArrayLength(Expression array)
		{
			return null;
		}

		public static UnaryExpression Quote(Expression expression)
		{
			return null;
		}

		public static UnaryExpression Throw(Expression value, Type type)
		{
			return null;
		}

		public static UnaryExpression Increment(Expression expression, MethodInfo method)
		{
			return null;
		}

		public static UnaryExpression Decrement(Expression expression, MethodInfo method)
		{
			return null;
		}

		public static UnaryExpression PreIncrementAssign(Expression expression)
		{
			return null;
		}

		public static UnaryExpression PreIncrementAssign(Expression expression, MethodInfo method)
		{
			return null;
		}

		public static UnaryExpression PreDecrementAssign(Expression expression, MethodInfo method)
		{
			return null;
		}

		public static UnaryExpression PostIncrementAssign(Expression expression, MethodInfo method)
		{
			return null;
		}

		public static UnaryExpression PostDecrementAssign(Expression expression, MethodInfo method)
		{
			return null;
		}

		private static UnaryExpression MakeOpAssignUnary(ExpressionType kind, Expression expression, MethodInfo method)
		{
			return null;
		}
	}
	public class Expression<TDelegate> : LambdaExpression
	{
		internal sealed override Type TypeCore => null;

		internal override Type PublicType => null;

		internal Expression(Expression body)
			: base(null)
		{
		}

		public TDelegate Compile()
		{
			return default(TDelegate);
		}

		public TDelegate Compile(bool preferInterpretation)
		{
			return default(TDelegate);
		}

		[ExcludeFromCodeCoverage]
		internal virtual Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters)
		{
			return null;
		}

		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return null;
		}
	}
}
