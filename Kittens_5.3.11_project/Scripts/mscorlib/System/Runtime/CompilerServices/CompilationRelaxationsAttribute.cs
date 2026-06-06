using System.Runtime.InteropServices;

namespace System.Runtime.CompilerServices
{
	[Serializable]
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Method)]
	[ComVisible(true)]
	public class CompilationRelaxationsAttribute : Attribute
	{
		private int m_relaxations;

		public int CompilationRelaxations => 0;

		public CompilationRelaxationsAttribute(int relaxations)
		{
		}

		public CompilationRelaxationsAttribute(CompilationRelaxations relaxations)
		{
		}
	}
}
