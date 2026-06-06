using System.Collections;
using System.Collections.Specialized;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Net
{
	[Serializable]
	[ComVisible(true)]
	[DefaultMember("Item")]
	public class WebHeaderCollection : NameValueCollection, ISerializable
	{
		private enum RfcChar : byte
		{
			High = 0,
			Reg = 1,
			Ctl = 2,
			CR = 3,
			LF = 4,
			WS = 5,
			Colon = 6,
			Delim = 7
		}

		private static readonly HeaderInfoTable HInfo;

		private string[] m_CommonHeaders;

		private int m_NumCommonHeaders;

		private static readonly string[] s_CommonHeaderNames;

		private static readonly sbyte[] s_CommonHeaderHints;

		private NameValueCollection m_InnerCollection;

		private WebHeaderCollectionType m_Type;

		private static readonly char[] HttpTrimCharacters;

		private static RfcChar[] RfcCharMap;

		private NameValueCollection InnerCollection => null;

		private bool AllowHttpRequestHeader => false;

		public override int Count => 0;

		private void NormalizeCommonHeaders()
		{
		}

		internal static bool AllowMultiValues(string name)
		{
			return false;
		}

		public void Remove(HttpRequestHeader header)
		{
		}

		internal void AddInternal(string name, string value)
		{
		}

		internal void ChangeInternal(string name, string value)
		{
		}

		internal void RemoveInternal(string name)
		{
		}

		internal static string CheckBadChars(string name, bool isHeaderValue)
		{
			return null;
		}

		internal static bool ContainsNonAsciiChars(string token)
		{
			return false;
		}

		internal void ThrowOnRestrictedHeader(string headerName)
		{
		}

		public override void Add(string name, string value)
		{
		}

		public void Add(string header)
		{
		}

		public override void Set(string name, string value)
		{
		}

		internal void SetInternal(string name, string value)
		{
		}

		public override void Remove(string name)
		{
		}

		public override string[] GetValues(string header)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		internal static string GetAsString(NameValueCollection cc, bool winInetCompat, bool forTrace)
		{
			return null;
		}

		public WebHeaderCollection()
		{
		}

		internal WebHeaderCollection(WebHeaderCollectionType type)
		{
		}

		protected WebHeaderCollection(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		public override void OnDeserialization(object sender)
		{
		}

		public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		public override string Get(string name)
		{
			return null;
		}

		public override IEnumerator GetEnumerator()
		{
			return null;
		}

		public override string Get(int index)
		{
			return null;
		}

		public override string GetKey(int index)
		{
			return null;
		}
	}
}
