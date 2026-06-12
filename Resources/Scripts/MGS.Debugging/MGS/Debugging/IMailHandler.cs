using System;
using System.Collections;

namespace MGS.Debugging
{
	public interface IMailHandler
	{
		IEnumerator SendMail(string[] recipients, string subject, string message, string[] files, Action onCompleted = null);
	}
}
