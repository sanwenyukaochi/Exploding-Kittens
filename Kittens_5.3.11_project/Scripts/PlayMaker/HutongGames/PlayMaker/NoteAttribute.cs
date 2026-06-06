using System;

namespace HutongGames.PlayMaker
{
	[AttributeUsage(AttributeTargets.All)]
	public sealed class NoteAttribute : Attribute
	{
		private readonly string text;

		public string Text => null;

		public NoteAttribute(string text)
		{
		}
	}
}
