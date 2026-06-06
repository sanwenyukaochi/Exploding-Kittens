using System;
using System.Runtime.CompilerServices;

namespace Unity.Services.Core
{
	public class RequestFailedException : Exception
	{
		[CompilerGenerated]
		private readonly int _003CErrorCode_003Ek__BackingField;

		public RequestFailedException(int errorCode, string message, Exception innerException)
		{
		}
	}
}
