using System.Runtime.CompilerServices;

namespace System.Reflection
{
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyFileVersionAttribute : Attribute
	{
		[CompilerGenerated]
		private readonly string _003CVersion_003Ek__BackingField;

		public AssemblyFileVersionAttribute(string version)
		{
		}
	}
}
