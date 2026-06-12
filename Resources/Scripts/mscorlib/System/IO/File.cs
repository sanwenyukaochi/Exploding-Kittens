using System.Collections.Generic;
using System.Text;

namespace System.IO
{
	public static class File
	{
		public static StreamReader OpenText(string path)
		{
			return null;
		}

		public static void Copy(string sourceFileName, string destFileName)
		{
		}

		public static void Copy(string sourceFileName, string destFileName, bool overwrite)
		{
		}

		public static FileStream Create(string path)
		{
			return null;
		}

		public static FileStream Create(string path, int bufferSize)
		{
			return null;
		}

		public static void Delete(string path)
		{
		}

		public static bool Exists(string path)
		{
			return false;
		}

		public static FileStream Open(string path, FileMode mode)
		{
			return null;
		}

		public static FileStream Open(string path, FileMode mode, FileAccess access, FileShare share)
		{
			return null;
		}

		public static FileStream OpenRead(string path)
		{
			return null;
		}

		public static string ReadAllText(string path)
		{
			return null;
		}

		private static string InternalReadAllText(string path, Encoding encoding)
		{
			return null;
		}

		public static void WriteAllText(string path, string contents)
		{
		}

		public static byte[] ReadAllBytes(string path)
		{
			return null;
		}

		private static byte[] ReadAllBytesUnknownLength(FileStream fs)
		{
			return null;
		}

		public static void WriteAllBytes(string path, byte[] bytes)
		{
		}

		private static void InternalWriteAllBytes(string path, byte[] bytes)
		{
		}

		public static string[] ReadAllLines(string path)
		{
			return null;
		}

		private static string[] InternalReadAllLines(string path, Encoding encoding)
		{
			return null;
		}

		public static void WriteAllLines(string path, string[] contents)
		{
		}

		public static void WriteAllLines(string path, IEnumerable<string> contents)
		{
		}

		private static void InternalWriteAllLines(TextWriter writer, IEnumerable<string> contents)
		{
		}

		public static void AppendAllText(string path, string contents)
		{
		}
	}
}
