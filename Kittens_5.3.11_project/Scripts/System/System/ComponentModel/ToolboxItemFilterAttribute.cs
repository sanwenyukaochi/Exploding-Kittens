namespace System.ComponentModel
{
	[Serializable]
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
	public sealed class ToolboxItemFilterAttribute : Attribute
	{
		private string _typeId;

		public string FilterString { get; }

		public ToolboxItemFilterType FilterType { get; }

		public override object TypeId => null;

		public ToolboxItemFilterAttribute(string filterString)
		{
		}

		public ToolboxItemFilterAttribute(string filterString, ToolboxItemFilterType filterType)
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

		public override bool Match(object obj)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
