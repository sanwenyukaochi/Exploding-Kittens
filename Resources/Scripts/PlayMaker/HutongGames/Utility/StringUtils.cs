using System;
using System.Text;

namespace HutongGames.Utility
{
	public static class StringUtils
	{
		[ThreadStatic]
		private static StringBuilder escapeBuilder;

		public static bool forceAscii;

		internal static StringBuilder EscapeBuilder => null;

		public static string IncrementStringCounter(string s)
		{
			return null;
		}

		public static string StripHtml(string input)
		{
			return null;
		}

		public static string StripMarkdown(string input)
		{
			return null;
		}

		public static string StripHtmlAndMarkdown(string input)
		{
			return null;
		}

		public static string Escape(string aText)
		{
			return null;
		}
	}
}
