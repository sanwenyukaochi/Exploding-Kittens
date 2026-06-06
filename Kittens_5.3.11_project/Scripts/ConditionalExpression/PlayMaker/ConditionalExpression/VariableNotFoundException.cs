using System;

namespace PlayMaker.ConditionalExpression
{
	public class VariableNotFoundException : Exception
	{
		public VariableNotFoundException(string variableName)
		{
		}
	}
}
