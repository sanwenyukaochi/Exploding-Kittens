using System.Reflection;
using System.Runtime.CompilerServices;

namespace System
{
	public class ResolveEventArgs : EventArgs
	{
		[CompilerGenerated]
		private readonly Assembly _003CRequestingAssembly_003Ek__BackingField;

		public string Name { get; }

		public ResolveEventArgs(string name)
		{
		}

		public ResolveEventArgs(string name, Assembly requestingAssembly)
		{
		}
	}
}
