using System.Runtime.InteropServices;
using System.Text;

namespace System.IO
{
	[Serializable]
	[ComVisible(true)]
	public class StringWriter : TextWriter
	{
		private static UnicodeEncoding m_encoding;

		private StringBuilder _sb;

		private bool _isOpen;

		public override Encoding Encoding => null;

		public StringWriter()
		{
		}

		public StringWriter(IFormatProvider formatProvider)
		{
		}

		public StringWriter(StringBuilder sb)
		{
		}

		public StringWriter(StringBuilder sb, IFormatProvider formatProvider)
		{
		}

		public override void Close()
		{
		}

		protected override void Dispose(bool disposing)
		{
		}

		public override void Write(char value)
		{
		}

		public override void Write(char[] buffer, int index, int count)
		{
		}

		public override void Write(string value)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
