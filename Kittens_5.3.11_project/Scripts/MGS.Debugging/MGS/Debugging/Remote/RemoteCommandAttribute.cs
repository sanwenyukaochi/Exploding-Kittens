using System;

namespace MGS.Debugging.Remote
{
	[AttributeUsage(AttributeTargets.Method)]
	public class RemoteCommandAttribute : DebugFunctionAttribute
	{
	}
}
