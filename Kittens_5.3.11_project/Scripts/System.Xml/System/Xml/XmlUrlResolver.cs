using System.Diagnostics;
using System.Net;
using System.Net.Cache;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace System.Xml
{
	public class XmlUrlResolver : XmlResolver
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetEntityAsync_003Ed__15 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<object> _003C_003Et__builder;

			public Type ofObjectToReturn;

			public Uri absoluteUri;

			public XmlUrlResolver _003C_003E4__this;

			private ConfiguredTaskAwaitable<System.IO.Stream>.ConfiguredTaskAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		private static object s_DownloadManager;

		private ICredentials _credentials;

		private IWebProxy _proxy;

		private RequestCachePolicy _cachePolicy;

		private static XmlDownloadManager DownloadManager => null;

		public override object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn)
		{
			return null;
		}

		public override Uri ResolveUri(Uri baseUri, string relativeUri)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetEntityAsync_003Ed__15))]
		public override Task<object> GetEntityAsync(Uri absoluteUri, string role, Type ofObjectToReturn)
		{
			return null;
		}
	}
}
