using System.Runtime.InteropServices;

namespace System.IO
{
	[Serializable]
	[ComVisible(true)]
	public class StringReader : TextReader
	{
		private string _s;

		private int _pos;

		private int _length;

		public StringReader(string s)
		{
		}

		public override void Close()
		{
		}

		protected override void Dispose(bool disposing)
		{
		}

		public override int Peek()
		{
			return 0;
		}

		public override int Read()
		{
			return 0;
		}

		public override int Read([In][Out] char[] buffer, int index, int count)
		{
			return 0;
		}

		public override string ReadToEnd()
		{
			return null;
		}

		public override string ReadLine()
		{
			return null;
		}
	}
}
