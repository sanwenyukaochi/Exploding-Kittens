using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.Bindings
{
	[VisibleToOtherModules]
	[AttributeUsage(AttributeTargets.Field)]
	internal class IgnoreAttribute : Attribute
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private bool _003CDoesNotContributeToSize_003Ek__BackingField;

		public bool DoesNotContributeToSize
		{
			[CompilerGenerated]
			set
			{
				_003CDoesNotContributeToSize_003Ek__BackingField = value;
			}
		}
	}
}
