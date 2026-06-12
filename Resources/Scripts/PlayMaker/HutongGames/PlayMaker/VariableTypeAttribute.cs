using System;

namespace HutongGames.PlayMaker
{
	[AttributeUsage(AttributeTargets.Field)]
	public sealed class VariableTypeAttribute : Attribute
	{
		private readonly VariableType type;

		public VariableType Type => default(VariableType);

		public VariableTypeAttribute(VariableType type)
		{
		}
	}
}
