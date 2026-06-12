using System.Runtime.CompilerServices;
using System.Text;

namespace System.IO
{
	[Serializable]
	public abstract class TextWriter : MarshalByRefObject, IDisposable
	{
		[Serializable]
		private sealed class NullTextWriter : TextWriter
		{
			public override Encoding Encoding => null;

			internal NullTextWriter()
			{
			}

			public override void Write(char[] buffer, int index, int count)
			{
			}

			public override void Write(string value)
			{
			}

			public override void WriteLine()
			{
			}

			public override void WriteLine(string value)
			{
			}

			public override void WriteLine(object value)
			{
			}

			public override void Write(char value)
			{
			}
		}

		[Serializable]
		internal sealed class SyncTextWriter : TextWriter, IDisposable
		{
			private readonly TextWriter _out;

			public override Encoding Encoding => null;

			public override IFormatProvider FormatProvider => null;

			public override string NewLine
			{
				[MethodImpl(MethodImplOptions.Synchronized)]
				get
				{
					return null;
				}
			}

			internal SyncTextWriter(TextWriter t)
			{
			}

			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void Close()
			{
			}

			[MethodImpl(MethodImplOptions.Synchronized)]
			protected override void Dispose(bool disposing)
			{
			}

			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void Flush()
			{
			}

			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void Write(char value)
			{
			}

			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void Write(char[] buffer)
			{
			}

			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void Write(char[] buffer, int index, int count)
			{
			}

			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void Write(string value)
			{
			}

			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void WriteLine()
			{
			}

			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void WriteLine(string value)
			{
			}

			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void WriteLine(object value)
			{
			}
		}

		public static readonly TextWriter Null;

		private static readonly char[] s_coreNewLine;

		protected char[] CoreNewLine;

		private string CoreNewLineStr;

		private IFormatProvider _internalFormatProvider;

		public virtual IFormatProvider FormatProvider => null;

		public abstract Encoding Encoding { get; }

		public virtual string NewLine => null;

		protected TextWriter()
		{
		}

		protected TextWriter(IFormatProvider formatProvider)
		{
		}

		public virtual void Close()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		public void Dispose()
		{
		}

		public virtual void Flush()
		{
		}

		public virtual void Write(char value)
		{
		}

		public virtual void Write(char[] buffer)
		{
		}

		public virtual void Write(char[] buffer, int index, int count)
		{
		}

		public virtual void Write(string value)
		{
		}

		public virtual void WriteLine()
		{
		}

		public virtual void WriteLine(string value)
		{
		}

		public virtual void WriteLine(object value)
		{
		}

		public static TextWriter Synchronized(TextWriter writer)
		{
			return null;
		}
	}
}
