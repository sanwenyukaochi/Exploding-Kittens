using System;

namespace HutongGames.PlayMaker
{
	[AttributeUsage(AttributeTargets.Field)]
	public sealed class HasIntSliderAttribute : Attribute
	{
		private readonly int minValue;

		private readonly int maxValue;

		public int MinValue => 0;

		public int MaxValue => 0;

		public HasIntSliderAttribute(int minValue, int maxValue)
		{
		}
	}
}
