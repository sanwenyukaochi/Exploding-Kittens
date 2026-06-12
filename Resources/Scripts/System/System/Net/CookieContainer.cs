using System.Collections;
using System.Collections.Generic;

namespace System.Net
{
	[Serializable]
	public class CookieContainer
	{
		private static readonly HeaderVariantInfo[] HeaderInfo;

		private Hashtable m_domainTable;

		private int m_maxCookieSize;

		private int m_maxCookies;

		private int m_maxCookiesPerDomain;

		private int m_count;

		private string m_fqdnMyDomain;

		private void AddRemoveDomain(string key, PathList value)
		{
		}

		internal void Add(Cookie cookie, bool throwOnError)
		{
		}

		private bool AgeCookies(string domain)
		{
			return false;
		}

		private int ExpireCollection(CookieCollection cc)
		{
			return 0;
		}

		internal bool IsLocalDomain(string host)
		{
			return false;
		}

		internal CookieCollection CookieCutter(Uri uri, string headerName, string setCookieHeader, bool isThrow)
		{
			return null;
		}

		internal CookieCollection InternalGetCookies(Uri uri)
		{
			return null;
		}

		private void BuildCookieCollectionFromDomainMatches(Uri uri, bool isSecure, int port, CookieCollection cookies, List<string> domainAttribute, bool matchOnlyPlainCookie)
		{
		}

		private void MergeUpdateCollections(CookieCollection destination, CookieCollection source, int port, bool isSecure, bool isPlainOnly)
		{
		}

		public string GetCookieHeader(Uri uri)
		{
			return null;
		}

		internal string GetCookieHeader(Uri uri, out string optCookie2)
		{
			optCookie2 = null;
			return null;
		}
	}
}
