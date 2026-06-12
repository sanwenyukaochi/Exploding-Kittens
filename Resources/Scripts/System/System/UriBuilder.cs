namespace System
{
	public class UriBuilder
	{
		private bool _changed;

		private string _fragment;

		private string _host;

		private string _password;

		private string _path;

		private int _port;

		private string _query;

		private string _scheme;

		private string _schemeDelimiter;

		private Uri _uri;

		private string _username;

		public string Path
		{
			set
			{
			}
		}

		public Uri Uri => null;

		public UriBuilder(Uri uri)
		{
		}

		private void Init(Uri uri)
		{
		}

		public override bool Equals(object rparam)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		private void SetFieldsFromUri(Uri uri)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
