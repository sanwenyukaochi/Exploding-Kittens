namespace System.ComponentModel
{
	public class ComponentConverter : ReferenceConverter
	{
		public ComponentConverter(Type type)
			: base(null)
		{
		}

		public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
		{
			return null;
		}

		public override bool GetPropertiesSupported(ITypeDescriptorContext context)
		{
			return false;
		}
	}
}
