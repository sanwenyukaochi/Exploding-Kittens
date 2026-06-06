using System;

namespace HutongGames.PlayMaker
{
	[AttributeUsage(AttributeTargets.Field)]
	public sealed class ArrayEditorAttribute : Attribute
	{
		private readonly VariableType variableType;

		private readonly Type objectType;

		private readonly string elementName;

		private readonly int fixedSize;

		private readonly int maxSize;

		private readonly int minSize;

		public VariableType VariableType => default(VariableType);

		public Type ObjectType => null;

		public string ElementName => null;

		public int FixedSize => 0;

		public bool Resizable => false;

		public int MinSize => 0;

		public int MaxSize => 0;

		public ArrayEditorAttribute(VariableType variableType, string elementName = "", int fixedSize = 0, int minSize = 0, int maxSize = 65536)
		{
		}

		public ArrayEditorAttribute(Type objectType, string elementName = "", int fixedSize = 0, int minSize = 0, int maxSize = 65536)
		{
		}
	}
}
