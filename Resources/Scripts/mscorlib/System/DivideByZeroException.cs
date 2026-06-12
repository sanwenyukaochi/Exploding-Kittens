using System.Runtime.Serialization;

namespace System
{
	[Serializable]
	public class DivideByZeroException : ArithmeticException
	{
		public DivideByZeroException()
		{
		}

		public DivideByZeroException(string message)
		{
		}

		protected DivideByZeroException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
