using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading;

namespace ExitGames.Client.Photon
{
	public class SupportClass
	{
		public delegate int IntegerMillisecondsDelegate();

		public class ThreadSafeRandom
		{
			private static readonly Random _r;

			public static int Next()
			{
				return 0;
			}
		}

		private static List<Thread> threadList;

		protected internal static IntegerMillisecondsDelegate IntegerMilliseconds;

		private static uint[] crcLookupTable;

		public static List<MethodInfo> GetMethods(Type type, Type attribute)
		{
			return null;
		}

		public static int GetTickCount()
		{
			return 0;
		}

		[Obsolete("Use StartBackgroundCalls() instead. It works with StopBackgroundCalls().")]
		public static byte CallInBackground(Func<bool> myThread, int millisecondsInterval = 100, string taskName = "")
		{
			return 0;
		}

		public static byte StartBackgroundCalls(Func<bool> myThread, int millisecondsInterval = 100, string taskName = "")
		{
			return 0;
		}

		public static void WriteStackTrace(Exception throwable, TextWriter stream)
		{
		}

		public static void WriteStackTrace(Exception throwable)
		{
		}

		public static string DictionaryToString(IDictionary dictionary)
		{
			return null;
		}

		public static string DictionaryToString(IDictionary dictionary, bool includeTypes)
		{
			return null;
		}

		public static string ByteArrayToString(byte[] list)
		{
			return null;
		}

		private static uint[] InitializeTable(uint polynomial)
		{
			return null;
		}

		public static uint CalculateCrc(byte[] buffer, int length)
		{
			return 0u;
		}
	}
}
