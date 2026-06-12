using System.Diagnostics;

namespace System.ComponentModel
{
	[Conditional("FALSE")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true, Inherited = true)]
	public sealed class DesignerAttribute : Attribute
	{
		private readonly string designerTypeName;

		private readonly string designerBaseTypeName;

		private string typeId;

		public string DesignerBaseTypeName => null;

		public string DesignerTypeName => null;

		public override object TypeId => null;

		public DesignerAttribute(string designerTypeName)
		{
		}

		public DesignerAttribute(Type designerType)
		{
		}

		public DesignerAttribute(string designerTypeName, string designerBaseTypeName)
		{
		}

		public DesignerAttribute(string designerTypeName, Type designerBaseType)
		{
		}

		public DesignerAttribute(Type designerType, Type designerBaseType)
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
