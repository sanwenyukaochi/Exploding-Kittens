using System.Collections;
using System.Runtime.Serialization;

namespace System.Net
{
	[Serializable]
	public sealed class Cookie
	{
		internal static readonly char[] PortSplitDelimiters;

		internal static readonly char[] Reserved2Name;

		internal static readonly char[] Reserved2Value;

		private static Comparer staticComparer;

		private string m_comment;

		private Uri m_commentUri;

		private CookieVariant m_cookieVariant;

		private bool m_discard;

		private string m_domain;

		private bool m_domain_implicit;

		private DateTime m_expires;

		private string m_name;

		private string m_path;

		private bool m_path_implicit;

		private string m_port;

		private bool m_port_implicit;

		private int[] m_port_list;

		private bool m_secure;

		[OptionalField]
		private bool m_httpOnly;

		private DateTime m_timeStamp;

		private string m_value;

		private int m_version;

		private string m_domainKey;

		internal bool IsQuotedVersion;

		internal bool IsQuotedDomain;

		public string Comment
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Uri CommentUri
		{
			set
			{
			}
		}

		public bool HttpOnly
		{
			set
			{
			}
		}

		public bool Discard
		{
			set
			{
			}
		}

		public string Domain
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private string _Domain => null;

		public bool Expired => false;

		public DateTime Expires
		{
			set
			{
			}
		}

		public string Name => null;

		public string Path
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private string _Path => null;

		internal bool Plain => false;

		public string Port
		{
			set
			{
			}
		}

		internal int[] PortList => null;

		private string _Port => null;

		public bool Secure
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public string Value
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal CookieVariant Variant => default(CookieVariant);

		internal string DomainKey => null;

		public int Version
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		private string _Version => null;

		internal bool InternalSetName(string value)
		{
			return false;
		}

		private static bool IsDomainEqualToHost(string domain, string host)
		{
			return false;
		}

		internal bool VerifySetDefaults(CookieVariant variant, Uri uri, bool isLocalDomain, string localDomain, bool set_default, bool isThrow)
		{
			return false;
		}

		private static bool DomainCharsTest(string name)
		{
			return false;
		}

		internal static IComparer GetComparer()
		{
			return null;
		}

		public override bool Equals(object comparand)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
