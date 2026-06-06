using UnityEngine;

namespace MGS.Debugging
{
	public class FileLogHandler : ILogHandler
	{
		private class ErrorLog
		{
			public string Log { get; set; }

			public string Stack { get; set; }

			public LogType Type { get; set; }
		}

		private string m_Filename;

		private string m_ErrorsFilename;

		private bool m_Paused;

		private int m_NumErrorsAndExceptions;

		private const int MAX_ERRORS_FOR_JSON = 100;

		public string GetLogFilePath()
		{
			return null;
		}

		public void OnEnabled(string handler, bool enabled)
		{
		}

		public void Pause(bool pause)
		{
		}

		public void Log(string log, string stack, string type)
		{
		}

		public void Log(string log, string stack, LogType type)
		{
		}

		private void _LogJson(string log, string stack, LogType type)
		{
		}

		void ILogHandler.Update()
		{
		}
	}
}
