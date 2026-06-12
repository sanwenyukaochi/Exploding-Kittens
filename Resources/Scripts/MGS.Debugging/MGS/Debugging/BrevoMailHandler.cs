using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using UnityEngine.Networking;

namespace MGS.Debugging
{
	public class BrevoMailHandler : IMailHandler
	{
		public struct SMailSettings
		{
			public string FromAddress;

			public string BrevoApiKey;

			public SMailSettings(string fromAddress, string brevoApi)
			{
				FromAddress = null;
				BrevoApiKey = null;
			}
		}

		public class Attachment
		{
			[JsonProperty("content")]
			public string Content;

			[JsonProperty("name")]
			public string Name;
		}

		public class ReplyTo
		{
			[JsonProperty("email")]
			public string Email;
		}

		public class MailMessage
		{
			[JsonProperty("sender")]
			public Sender Sender;

			[JsonProperty("replyTo")]
			public ReplyTo ReplyTo;

			[JsonProperty("to")]
			public To[] To;

			[JsonProperty("htmlContent")]
			public string HtmlContent;

			[JsonProperty("subject")]
			public string Subject;

			[JsonProperty("attachment")]
			public Attachment[] Attachment;
		}

		public class Sender
		{
			[JsonProperty("name")]
			public string Name;

			[JsonProperty("email")]
			public string Email;
		}

		public class To
		{
			[JsonProperty("email")]
			public string Email;
		}

		[CompilerGenerated]
		private sealed class _003CSendMail_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BrevoMailHandler _003C_003E4__this;

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

		public BrevoMailHandler(SMailSettings mailSettings)
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
