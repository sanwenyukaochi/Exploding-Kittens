namespace System.Diagnostics
{
	public abstract class TraceListener : MarshalByRefObject, IDisposable
	{
		private int indentLevel;

		private int indentSize;

		private bool needIndent;

		private string listenerName;

		public virtual bool IsThreadSafe => false;

		public int IndentLevel
		{
			set
			{
			}
		}

		public int IndentSize
		{
			set
			{
			}
		}

		protected bool NeedIndent
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected TraceListener(string name)
		{
		}

		public void Dispose()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		public virtual void Flush()
		{
		}

		public abstract void Write(string message);

		protected virtual void WriteIndent()
		{
		}

		public abstract void WriteLine(string message);
	}
}
