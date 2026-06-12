using System;

namespace HutongGames.PlayMaker
{
	public static class FsmTime
	{
		private static float totalEditorPlayerPausedTime;

		private static float realtimeLastUpdate;

		private static int frameCountLastUpdate;

		public static float RealtimeSinceStartup => 0f;

		public static void Update()
		{
		}

		public static string FormatTime(float time)
		{
			return null;
		}

		public static void DebugLog()
		{
		}

		[Obsolete("Workaround for old bug")]
		public static void RealtimeBugFix()
		{
		}
	}
}
