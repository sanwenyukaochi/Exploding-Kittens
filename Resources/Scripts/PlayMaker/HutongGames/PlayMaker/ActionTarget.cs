using System;

namespace HutongGames.PlayMaker
{
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
	public sealed class ActionTarget : Attribute
	{
		private readonly Type objectType;

		private readonly string fieldName;

		private readonly bool allowPrefabs;

		public Type ObjectType => null;

		public string FieldName => null;

		public bool AllowPrefabs => false;

		public ActionTarget(Type objectType, string fieldName = "", bool allowPrefabs = false)
		{
		}

		public bool IsSameAs(ActionTarget actionTarget)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
