using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.ComponentModel.Design
{
	[Serializable]
	public class CheckoutException : ExternalException
	{
		public static readonly CheckoutException Canceled;

		public CheckoutException()
		{
		}

		public CheckoutException(string message, int errorCode)
		{
		}

		protected CheckoutException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
