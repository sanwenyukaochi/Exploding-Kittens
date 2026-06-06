using System;

namespace HutongGames.PlayMaker
{
	[AttributeUsage(AttributeTargets.Field)]
	public sealed class DisplayOrderAttribute : Attribute
	{
		private readonly int index;

		public int Index => 0;

		public DisplayOrderAttribute(int orderIndex)
		{
		}
	}
}
