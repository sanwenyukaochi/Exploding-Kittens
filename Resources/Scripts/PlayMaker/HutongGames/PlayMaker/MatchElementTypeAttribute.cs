using System;

namespace HutongGames.PlayMaker
{
	[AttributeUsage(AttributeTargets.Field)]
	public sealed class MatchElementTypeAttribute : Attribute
	{
		private readonly string fieldName;

		public string FieldName => null;

		public MatchElementTypeAttribute(string fieldName)
		{
		}
	}
}
