using System;

namespace Mono.Security.Interface
{
	public sealed class TlsException : Exception
	{
		private Alert alert;

		public TlsException(Alert alert, string message)
		{
		}

		public TlsException(AlertDescription description, string message)
		{
		}
	}
}
