using System.Runtime.CompilerServices;

namespace System.Diagnostics
{
	[Serializable]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
	public sealed class ConditionalAttribute : Attribute
	{
		[CompilerGenerated]
		private readonly string _003CConditionString_003Ek__BackingField;

		public ConditionalAttribute(string conditionString)
		{
		}
	}
}
