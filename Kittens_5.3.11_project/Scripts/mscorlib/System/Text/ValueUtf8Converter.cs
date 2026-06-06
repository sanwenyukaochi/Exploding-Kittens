namespace System.Text
{
	internal ref struct ValueUtf8Converter
	{
		private byte[] _arrayToReturnToPool;

		private Span<byte> _bytes;

		public ValueUtf8Converter(Span<byte> initialBuffer)
		{
			_arrayToReturnToPool = null;
			_bytes = default(Span<byte>);
		}

		public Span<byte> ConvertAndTerminateString(ReadOnlySpan<char> value)
		{
			return default(Span<byte>);
		}

		public void Dispose()
		{
		}
	}
}
