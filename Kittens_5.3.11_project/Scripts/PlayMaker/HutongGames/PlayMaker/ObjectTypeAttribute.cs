using System;

namespace HutongGames.PlayMaker
{
	[AttributeUsage(AttributeTargets.Field)]
	public sealed class ObjectTypeAttribute : Attribute
	{
		private readonly Type objectType;

		public Type ObjectType => null;

		public ObjectTypeAttribute(Type objectType)
		{
		}
	}
}
