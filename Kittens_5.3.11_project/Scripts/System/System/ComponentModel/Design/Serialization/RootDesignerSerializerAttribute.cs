using System.Runtime.CompilerServices;

namespace System.ComponentModel.Design.Serialization
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true, Inherited = true)]
	[Obsolete("This attribute has been deprecated. Use DesignerSerializerAttribute instead.  For example, to specify a root designer for CodeDom, use DesignerSerializerAttribute(...,typeof(TypeCodeDomSerializer)).  https://go.microsoft.com/fwlink/?linkid=14202")]
	public sealed class RootDesignerSerializerAttribute : Attribute
	{
		private string _typeId;

		[CompilerGenerated]
		private readonly bool _003CReloadable_003Ek__BackingField;

		[CompilerGenerated]
		private readonly string _003CSerializerTypeName_003Ek__BackingField;

		public string SerializerBaseTypeName { get; }

		public override object TypeId => null;

		public RootDesignerSerializerAttribute(string serializerTypeName, string baseSerializerTypeName, bool reloadable)
		{
		}
	}
}
