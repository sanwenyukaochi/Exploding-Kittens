namespace System.Xml
{
	public class NameTable : XmlNameTable
	{
		private class Entry
		{
			internal string str;

			internal int hashCode;

			internal Entry next;

			internal Entry(string str, int hashCode, Entry next)
			{
			}
		}

		private Entry[] entries;

		private int count;

		private int mask;

		private int hashCodeRandomizer;

		public override string Add(string key)
		{
			return null;
		}

		public override string Add(char[] key, int start, int len)
		{
			return null;
		}

		public override string Get(string value)
		{
			return null;
		}

		private string AddEntry(string str, int hashCode)
		{
			return null;
		}

		private void Grow()
		{
		}

		private static bool TextEquals(string str1, char[] str2, int str2Start, int str2Length)
		{
			return false;
		}
	}
}
