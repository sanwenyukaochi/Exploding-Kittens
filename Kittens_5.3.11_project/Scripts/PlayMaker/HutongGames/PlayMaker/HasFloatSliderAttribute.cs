using System;

namespace HutongGames.PlayMaker
{
	[AttributeUsage(AttributeTargets.Field)]
	public sealed class HasFloatSliderAttribute : Attribute
	{
		private readonly float minValue;

		private readonly float maxValue;

		public float MinValue => 0f;

		public float MaxValue => 0f;

		public HasFloatSliderAttribute(float minValue, float maxValue)
		{
		}
	}
}
