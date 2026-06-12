using System.Collections.Generic;

namespace MGS.Debugging
{
	public class M
	{
		private static Dictionary<string, bool> s_Channels;

		private static string s_PlayerPrefsKey;

		private static bool s_LogsEnabled;

		private static bool s_Initialized;

		private static int s_MainThreadId;

		private static bool s_DisabledChannelsSuppressErrors;

		private static bool s_DisabledChannelsSuppressWarnings;

		public static bool DisabledChannelsSuppressErrors => false;

		public static bool DisabledChannelsSuppressWarnings => false;

		public static string PlayerPrefsKey => null;

		private static bool _IsMainThread()
		{
			return false;
		}

		public static void Init()
		{
		}

		private static string[] _GetPersistentStringArray(string key)
		{
			return null;
		}

		private static void _SetPersistentStringArray(string key, string[] values)
		{
		}

		public static void EnableChannel(string channel, bool enable)
		{
		}

		private static void _AddChannelIfNew(string channel, bool enable)
		{
		}

		public static bool ChannelIsEnabled(string channel, bool checkParents = true)
		{
			return false;
		}

		private static string BuildMessage(string message, string channel)
		{
			return null;
		}

		public static void Log(string channel, string message)
		{
		}

		public static void LogError(string channel, string message)
		{
		}

		public static void LogWarning(string channel, string message)
		{
		}

		public static void LogF(string channel, string message, params object[] args)
		{
		}

		public static void LogWarningF(string channel, string message, params object[] args)
		{
		}
	}
}
