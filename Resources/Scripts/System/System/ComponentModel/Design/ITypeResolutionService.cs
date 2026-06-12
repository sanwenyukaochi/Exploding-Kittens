using System.Reflection;

namespace System.ComponentModel.Design
{
	public interface ITypeResolutionService
	{
		Type GetType(string name);

		string GetPathOfAssembly(AssemblyName name);
	}
}
