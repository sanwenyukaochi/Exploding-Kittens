using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace System.IO
{
	[Serializable]
	public class StreamWriter : TextWriter
	{
		public new static readonly StreamWriter Null;

		private Stream _stream;

		private Encoding _encoding;

		private Encoder _encoder;

		private byte[] _byteBuffer;

		private char[] _charBuffer;

		private int _charPos;

		private int _charLen;

		private bool _autoFlush;

		private bool _haveWrittenPreamble;

		private bool _closable;

		private Task _asyncWriteTask;

		private static Encoding UTF8NoBOM => null;

		public virtual bool AutoFlush
		{
			set
			{
			}
		}

		public virtual Stream BaseStream => null;

		internal bool LeaveOpen => false;

		public override Encoding Encoding => null;

		private void CheckAsyncTaskInProgress()
		{
		}

		private static void ThrowAsyncIOInProgress()
		{
		}

		internal StreamWriter()
		{
		}

		public StreamWriter(Stream stream)
		{
		}

		public StreamWriter(Stream stream, Encoding encoding)
		{
		}

		public StreamWriter(Stream stream, Encoding encoding, int bufferSize, bool leaveOpen)
		{
		}

		public StreamWriter(string path)
		{
		}

		public StreamWriter(string path, bool append)
		{
		}

		public StreamWriter(string path, bool append, Encoding encoding, int bufferSize)
		{
		}

		private void Init(Stream streamArg, Encoding encodingArg, int bufferSize, bool shouldLeaveOpen)
		{
		}

		public override void Close()
		{
		}

		protected override void Dispose(bool disposing)
		{
		}

		public override void Flush()
		{
		}

		private void Flush(bool flushStream, bool flushEncoder)
		{
		}

		public override void Write(char value)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Write(char[] buffer)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Write(char[] buffer, int index, int count)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void WriteSpan(ReadOnlySpan<char> buffer, bool appendNewLine)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Write(string value)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteLine(string value)
		{
		}
	}
}
