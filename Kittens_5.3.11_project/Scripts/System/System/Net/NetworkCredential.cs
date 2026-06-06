using System.Security;

namespace System.Net
{
	public class NetworkCredential : ICredentials
	{
		private string m_domain;

		private string m_userName;

		private SecureString m_password;

		public string UserName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Password
		{
			get
			{
				return null;
			}
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

		public NetworkCredential(string userName, string password)
		{
		}

		public NetworkCredential(string userName, string password, string domain)
		{
		}

		internal string InternalGetUserName()
		{
			return null;
		}

		internal string InternalGetPassword()
		{
			return null;
		}

		internal string InternalGetDomain()
		{
			return null;
		}

		public NetworkCredential GetCredential(Uri uri, string authType)
		{
			return null;
		}
	}
}
