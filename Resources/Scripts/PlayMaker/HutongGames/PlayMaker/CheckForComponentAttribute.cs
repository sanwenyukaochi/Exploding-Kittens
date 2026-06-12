using System;

namespace HutongGames.PlayMaker
{
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
	public sealed class CheckForComponentAttribute : Attribute
	{
		private readonly Type type0;

		private readonly Type type1;

		private readonly Type type2;

		public Type Type0 => null;

		public Type Type1 => null;

		public Type Type2 => null;

		public CheckForComponentAttribute(Type type0)
		{
		}

		public CheckForComponentAttribute(Type type0, Type type1)
		{
		}

		public CheckForComponentAttribute(Type type0, Type type1, Type type2)
		{
		}
	}
}
