using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

namespace System.Net
{
	[Serializable]
	public class WebProxy : IWebProxy, ISerializable
	{
		private bool _UseRegistry;

		private bool _BypassOnLocal;

		private bool m_EnableAutoproxy;

		private Uri _ProxyAddress;

		private ArrayList _BypassList;

		private ICredentials _Credentials;

		private Regex[] _RegExBypassList;

		private Hashtable _ProxyHostAddresses;

		private AutoWebProxyScriptEngine m_ScriptEngine;

		public ICredentials Credentials => null;

		public bool UseDefaultCredentials
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal AutoWebProxyScriptEngine ScriptEngine => null;

		public WebProxy()
		{
		}

		public WebProxy(Uri Address, bool BypassOnLocal, string[] BypassList, ICredentials Credentials)
		{
		}

		public Uri GetProxy(Uri destination)
		{
			return null;
		}

		private void UpdateRegExList(bool canThrow)
		{
		}

		private bool IsMatchInBypassList(Uri input)
		{
			return false;
		}

		private bool IsLocal(Uri host)
		{
			return false;
		}

		private bool IsLocalInProxyHash(Uri host)
		{
			return false;
		}

		public bool IsBypassed(Uri host)
		{
			return false;
		}

		private bool IsBypassedManual(Uri host)
		{
			return false;
		}

		protected WebProxy(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		public static IWebProxy CreateDefaultProxy()
		{
			return null;
		}

		internal WebProxy(bool enableAutoproxy)
		{
		}

		internal void UnsafeUpdateFromRegistry()
		{
		}

		private bool GetProxyAuto(Uri destination, out Uri proxyUri)
		{
			proxyUri = null;
			return false;
		}

		private bool IsBypassedAuto(Uri destination, out bool isBypassed)
		{
			isBypassed = default(bool);
			return false;
		}

		private static bool AreAllBypassed(IEnumerable<string> proxies, bool checkFirstOnly)
		{
			return false;
		}

		private static Uri ProxyUri(string proxyName)
		{
			return null;
		}
	}
}
