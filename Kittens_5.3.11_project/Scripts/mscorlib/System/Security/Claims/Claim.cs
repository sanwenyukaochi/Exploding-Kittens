using System.Collections.Generic;
using System.Runtime.Serialization;

namespace System.Security.Claims
{
	[Serializable]
	public class Claim
	{
		private string m_issuer;

		private string m_originalIssuer;

		private string m_type;

		private string m_value;

		private string m_valueType;

		[NonSerialized]
		private byte[] m_userSerializationData;

		private Dictionary<string, string> m_properties;

		[NonSerialized]
		private object m_propertyLock;

		[NonSerialized]
		private ClaimsIdentity m_subject;

		public IDictionary<string, string> Properties => null;

		public ClaimsIdentity Subject
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public string Type => null;

		public string Value => null;

		public Claim(string type, string value, string valueType, string issuer, string originalIssuer, ClaimsIdentity subject)
		{
		}

		internal Claim(string type, string value, string valueType, string issuer, string originalIssuer, ClaimsIdentity subject, string propertyKey, string propertyValue)
		{
		}

		protected Claim(Claim other, ClaimsIdentity subject)
		{
		}

		[OnDeserialized]
		private void OnDeserializedMethod(StreamingContext context)
		{
		}

		public virtual Claim Clone(ClaimsIdentity identity)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
