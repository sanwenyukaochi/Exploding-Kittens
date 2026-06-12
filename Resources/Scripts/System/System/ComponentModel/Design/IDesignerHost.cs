namespace System.ComponentModel.Design
{
	public interface IDesignerHost : IServiceProvider
	{
		IDesigner GetDesigner(IComponent component);
	}
}
