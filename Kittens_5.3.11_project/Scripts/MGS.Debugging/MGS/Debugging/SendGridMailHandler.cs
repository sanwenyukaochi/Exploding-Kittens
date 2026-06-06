using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Networking;

namespace MGS.Debugging
{
	public class SendGridMailHandler : IMailHandler
	{
		public struct SMailSettings
		{
			public string FromAddress;

			public string SendGridApiKey;

			public SMailSettings(string fromAddress, string sendGridApiKey)
			{
				FromAddress = null;
				SendGridApiKey = null;
			}
		}

		public class MailMessage
		{
			public From from { get; set; }

			public Personalization[] personalizations { get; set; }

			public Content[] content { get; set; }

			public Attachment[] attachments { get; set; }
		}

		public class From
		{
			public string email { get; set; }
		}

		public class Personalization
		{
			public To[] to { get; set; }

			public string subject { get; set; }
		}

		public class To
		{
			public string email { get; set; }
		}

		public class Content
		{
			public string type { get; set; }

			public string value { get; set; }
		}

		public class Attachment
		{
			public string content { get; set; }

			public string filename { get; set; }
		}

		[CompilerGenerated]
		private sealed class _003CSendMail_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SendGridMailHandler _003C_003E4__this;

			public string[] recipients;

			public string subject;

			public string message;

			public string[] files;

			public Action onCompleted;

			private UnityWebRequest _003Creq_003E5__2;

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
			public _003CSendMail_003Ed__3(int _003C_003E1__state)
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

		private SMailSettings m_MailSettings;

		public SendGridMailHandler(SMailSettings mailSettings)
		{
		}

		[IteratorStateMachine(typeof(_003CSendMail_003Ed__3))]
		public IEnumerator SendMail(string[] recipients, string subject, string message, string[] files, Action onCompleted = null)
		{
			return null;
		}

		private MailMessage _CreateMailMessage(string[] recipients, string subject, string message, string[] files)
		{
			return null;
		}

		private To[] _CreateRecipients(string[] recipients)
		{
			return null;
		}

		private Attachment[] _CreateAttachments(string[] files)
		{
			return null;
		}
	}
}
