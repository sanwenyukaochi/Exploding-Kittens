namespace System.Text
{
	[Serializable]
	public abstract class Encoder
	{
		internal EncoderFallback _fallback;

		internal EncoderFallbackBuffer _fallbackBuffer;

		public EncoderFallback Fallback => null;

		public EncoderFallbackBuffer FallbackBuffer => null;

		internal bool InternalHasFallbackBuffer => false;

		public virtual void Reset()
		{
		}

		public abstract int GetByteCount(char[] chars, int index, int count, bool flush);

		[CLSCompliant(false)]
		public unsafe virtual int GetByteCount(char* chars, int count, bool flush)
		{
			return 0;
		}

		public abstract int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush);

		[CLSCompliant(false)]
		public unsafe virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush)
		{
			return 0;
		}

		public virtual void Convert(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed)
		{
			charsUsed = default(int);
			bytesUsed = default(int);
			completed = default(bool);
		}

		[CLSCompliant(false)]
		public unsafe virtual void Convert(char* chars, int charCount, byte* bytes, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed)
		{
			charsUsed = default(int);
			bytesUsed = default(int);
			completed = default(bool);
		}
	}
}
