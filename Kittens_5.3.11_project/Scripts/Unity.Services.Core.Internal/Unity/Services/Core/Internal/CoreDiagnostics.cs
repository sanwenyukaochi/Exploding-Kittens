using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Services.Core.Telemetry.Internal;

namespace Unity.Services.Core.Internal
{
	internal class CoreDiagnostics
	{
		[CompilerGenerated]
		private readonly IDictionary<string, string> _003CCoreTags_003Ek__BackingField;

		[CompilerGenerated]
		private IDiagnosticsComponentProvider _003CDiagnosticsComponentProvider_003Ek__BackingField;

		public static CoreDiagnostics Instance { get; internal set; }

		internal IDiagnosticsComponentProvider DiagnosticsComponentProvider
		{
			[CompilerGenerated]
			set
			{
				_003CDiagnosticsComponentProvider_003Ek__BackingField = value;
			}
		}
	}
}
