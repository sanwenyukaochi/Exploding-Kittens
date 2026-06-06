using System;

namespace HutongGames.PlayMaker
{
	[AttributeUsage(AttributeTargets.All)]
	public sealed class TooltipAttribute : Attribute
	{
		private readonly string text;

		private readonly string codedText;

		public string Text => null;

		public string CodedText => null;

		public TooltipAttribute(string text)
		{
		}
	}
}
