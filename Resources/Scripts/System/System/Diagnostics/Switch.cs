using System.Collections.Generic;

namespace System.Diagnostics
{
	public abstract class Switch
	{
		private readonly string description;

		private readonly string displayName;

		private string switchValueString;

		private string defaultValue;

		private static List<WeakReference> switches;

		private static int s_LastCollectionCount;

		protected Switch(string displayName, string description)
		{
		}

		protected Switch(string displayName, string description, string defaultSwitchValue)
		{
		}

		private static void _pruneCachedSwitches()
		{
		}
	}
}
