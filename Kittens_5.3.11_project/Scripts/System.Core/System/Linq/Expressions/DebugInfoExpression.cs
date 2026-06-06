using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace System.Linq.Expressions
{
	[DebuggerTypeProxy(typeof(DebugInfoExpressionProxy))]
	public class DebugInfoExpression : Expression
	{
		[ExcludeFromCodeCoverage]
		public virtual int StartLine => 0;

		[ExcludeFromCodeCoverage]
		public virtual int EndLine => 0;

		public SymbolDocumentInfo Document { get; }

		[ExcludeFromCodeCoverage]
		public virtual bool IsClear => false;
	}
}
