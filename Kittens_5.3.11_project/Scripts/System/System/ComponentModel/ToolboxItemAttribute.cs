namespace System.ComponentModel
{
	[AttributeUsage(AttributeTargets.All)]
	public class ToolboxItemAttribute : Attribute
	{
		private Type _toolboxItemType;

		private string _toolboxItemTypeName;

		public static readonly ToolboxItemAttribute Default;

		public static readonly ToolboxItemAttribute None;

		public Type ToolboxItemType => null;

		public string ToolboxItemTypeName => null;

		public override bool IsDefaultAttribute()
		{
			return false;
		}

		public ToolboxItemAttribute(bool defaultType)
		{
		}

		public ToolboxItemAttribute(string toolboxItemTypeName)
		{
		}

		public ToolboxItemAttribute(Type toolboxItemType)
		{
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
