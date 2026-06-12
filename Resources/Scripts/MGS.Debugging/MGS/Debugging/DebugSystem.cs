using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace MGS.Debugging
{
	public class DebugSystem
	{
		[CompilerGenerated]
		private sealed class _003CSendBugReport_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CSendBugReport_003Ed__30(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		private ILogHandler[] m_LogHandlers;

		private GameObject m_Settings;

		private List<MethodInfo> m_DebugFunctions;

		private static string[] s_DebugChannels;

		private TrackingSystem m_TrackingSystem;

		public static string SessionId;

		private static List<string> s_BugReportRecipients;

		private static IMailHandler s_MailHandler;

		private static DebugSystem s_Instance;

		public static DebugSystem Instance => null;

		public TrackingSystem Tracking => null;

		public static event Application.LogCallback OnLogReceived
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static void Track(string message)
		{
		}

		public static string[] GetDebugChannels()
		{
			return null;
		}

		public static void AddBugReportRecipients(params string[] emails)
		{
		}

		public static void SetMailHandler(IMailHandler mailHandler)
		{
		}

		public static void AddBugReportRecipient(string email)
		{
		}

		public static string[] GetBugReportRecipients()
		{
			return null;
		}

		public void Init(string assemblyName, params ILogHandler[] logHandlers)
		{
		}

		public void Destroy()
		{
		}

		private void OnLogMessageReceived(string log, string stack, LogType type)
		{
		}

		public ILogHandler GetLogHandlerByType<T>() where T : ILogHandler
		{
			return null;
		}

		public void OnEnabled(string handler, bool enabled)
		{
		}

		public static void EnableLogHandler(string logHandler, bool enable)
		{
		}

		public void EmitFlag(string message)
		{
		}

		public static void TakeScreenshot(bool useMainCamera = false)
		{
		}

		[IteratorStateMachine(typeof(_003CSendBugReport_003Ed__30))]
		public static IEnumerator SendBugReport(string[] recipients, string report, string sessionId = "", Action onFinished = null)
		{
			return null;
		}

		public void Pause(bool pause)
		{
		}

		private void _ShowSettings()
		{
		}

		public void Update()
		{
		}

		private void _FindDebugFunctions(string assemblyName)
		{
		}

		public MethodInfo[] GetDebugFunctions()
		{
			return null;
		}

		public static string PrintDeviceSpecs()
		{
			return null;
		}
	}
}
