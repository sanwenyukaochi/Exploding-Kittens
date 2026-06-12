using System.Collections.Generic;

namespace MGS.Debugging
{
	public static class Utils
	{
		private static Dictionary<string, EDebugFileTypes> s_Files;

		public static string GetSessionsDir()
		{
			return null;
		}

		public static void AppendToFile(string session, string file, string text, EDebugFileTypes type)
		{
		}

		public static string GetFileContents(string session, string file)
		{
			return null;
		}

		public static void WriteFileContents(string session, string file, string content, EDebugFileTypes type)
		{
		}

		private static void _CreateDirectoryIfNotExists(string session)
		{
		}

		public static string[] GetSessionDirNames()
		{
			return null;
		}

		public static string GetFilePath(string session, string file)
		{
			return null;
		}

		public static void CopyFile(string fullPath, string session, string name, EDebugFileTypes type)
		{
		}

		private static byte[] _CaptureMainCameraScreenshot()
		{
			return null;
		}

		public static string TakeScreenshot(string session, string name, bool attach = true, bool useMainCamera = false)
		{
			return null;
		}

		public static string[] GetFiles(string sessionId = "", bool fullPath = false)
		{
			return null;
		}

		public static bool IsValidEmailAddress(string address)
		{
			return false;
		}
	}
}
