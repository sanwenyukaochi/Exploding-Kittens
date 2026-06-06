using System;
using UnityEngine;

namespace MGS.Debugging
{
	public class SwitchLogHandler : UnityEngine.ILogHandler
	{
		private UnityEngine.ILogHandler m_DefaultLogHandler;

		public void LogFormat(LogType logType, UnityEngine.Object context, string format, params object[] args)
		{
		}

		public void LogException(Exception exception, UnityEngine.Object context)
		{
		}
	}
}
