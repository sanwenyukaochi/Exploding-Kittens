namespace System.ComponentModel
{
	public abstract class InstanceCreationEditor
	{
		public virtual string Text => null;

		public abstract object CreateInstance(ITypeDescriptorContext context, Type instanceType);
	}
}
