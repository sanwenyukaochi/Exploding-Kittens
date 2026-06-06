using System;

namespace HutongGames.PlayMaker
{
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class ActionCategoryAttribute : Attribute
	{
		private readonly string category;

		public string Category => null;

		public ActionCategoryAttribute(string category)
		{
		}

		public ActionCategoryAttribute(ActionCategory category)
		{
		}
	}
}
