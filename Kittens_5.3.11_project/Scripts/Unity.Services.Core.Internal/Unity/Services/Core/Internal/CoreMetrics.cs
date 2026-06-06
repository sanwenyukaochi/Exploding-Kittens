using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Services.Core.Telemetry.Internal;

namespace Unity.Services.Core.Internal
{
	internal class CoreMetrics
	{
		[CompilerGenerated]
		private static CoreMetrics _003CInstance_003Ek__BackingField;

		[CompilerGenerated]
		private readonly IDictionary<Type, IMetrics> _003CAllPackageMetrics_003Ek__BackingField;

		internal static CoreMetrics Instance
		{
			[CompilerGenerated]
			set
			{
				_003CInstance_003Ek__BackingField = value;
			}
		}
	}
}
