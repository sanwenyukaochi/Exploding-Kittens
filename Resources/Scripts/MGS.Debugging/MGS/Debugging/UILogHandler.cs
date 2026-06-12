using UnityEngine;
using UnityEngine.UI;

namespace MGS.Debugging
{
	public class UILogHandler : ILogHandler
	{
		private GameObject m_LogUI;

		private Button m_OpenButton;

		private Text m_OpenButtonText;

		private Button m_CloseButton;

		private Button m_ScrollToBottomButton;

		private GameObject m_LogWindow;

		private GameObject m_LogEntry;

		private GameObject m_ScrollParent;

		private int numWarnings;

		private int numErrors;

		private bool m_Paused;

		public RectTransform OpenButtonRectTransform => null;

		private void _Init()
		{
		}

		public void Pause(bool pause)
		{
		}

		private void _Destroy()
		{
		}

		private void _Show(bool show)
		{
		}

		public void OnEnabled(string handler, bool enabled)
		{
		}

		public void Log(string log, string stack, string type)
		{
		}

		public void Log(string log, string stack, LogType type)
		{
		}

		void ILogHandler.Update()
		{
		}
	}
}
