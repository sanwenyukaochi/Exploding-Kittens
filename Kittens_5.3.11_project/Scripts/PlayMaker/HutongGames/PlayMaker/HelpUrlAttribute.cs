using System;

namespace HutongGames.PlayMaker
{
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class HelpUrlAttribute : Attribute
	{
		private readonly string url;

		public string Url => null;

		public HelpUrlAttribute(string url)
		{
		}
	}
}
