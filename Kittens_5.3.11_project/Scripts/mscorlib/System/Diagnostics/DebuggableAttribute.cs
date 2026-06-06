using System.Runtime.InteropServices;

namespace System.Diagnostics
{
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module, AllowMultiple = false)]
	[ComVisible(true)]
	public sealed class DebuggableAttribute : Attribute
	{
		[Flags]
		[ComVisible(true)]
		public enum DebuggingModes
		{
			None = 0,
			Default = 1,
			DisableOptimizations = 0x100,
			IgnoreSymbolStoreSequencePoints = 2,
			EnableEditAndContinue = 4
		}

		private DebuggingModes m_debuggingModes;

		public DebuggableAttribute(DebuggingModes modes)
		{
		}
	}
}
