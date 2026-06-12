namespace System.Security.Cryptography
{
	public sealed class Oid
	{
		private string _value;

		private string _friendlyName;

		private OidGroup _group;

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

		public string FriendlyName => null;

		public Oid()
		{
		}

		public Oid(string oid)
		{
		}

		public Oid(string value, string friendlyName)
		{
		}

		public Oid(Oid oid)
		{
		}

		public static Oid FromOidValue(string oidValue, OidGroup group)
		{
			return null;
		}

		private Oid(string value, string friendlyName, OidGroup group)
		{
		}
	}
}
