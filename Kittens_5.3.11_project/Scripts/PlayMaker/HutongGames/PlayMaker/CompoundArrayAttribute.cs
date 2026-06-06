using System;

namespace HutongGames.PlayMaker
{
	[AttributeUsage(AttributeTargets.Field)]
	public sealed class CompoundArrayAttribute : Attribute
	{
		private readonly string name;

		private readonly string firstArrayName;

		private readonly string secondArrayName;

		public string Name => null;

		public string FirstArrayName => null;

		public string SecondArrayName => null;

		public CompoundArrayAttribute(string name, string firstArrayName, string secondArrayName)
		{
		}
	}
}
