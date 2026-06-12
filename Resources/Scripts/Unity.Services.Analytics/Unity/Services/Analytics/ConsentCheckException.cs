using System;
using Unity.Services.Core;
using UnityEngine.Scripting;

namespace Unity.Services.Analytics
{
	public class ConsentCheckException : RequestFailedException
	{
		[Preserve]
		public ConsentCheckExceptionReason Reason { get; private set; }

		public ConsentCheckException(ConsentCheckExceptionReason reason, int errorCode, string message, Exception innerException)
			: base(0, null, null)
		{
		}
	}
}
