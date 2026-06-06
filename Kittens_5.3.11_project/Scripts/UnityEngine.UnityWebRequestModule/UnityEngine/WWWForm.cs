using System.Text;

namespace UnityEngine
{
	public class WWWForm
	{
		private static byte[] dDash;

		private static byte[] crlf;

		private static byte[] contentTypeHeader;

		private static byte[] dispositionHeader;

		private static byte[] endQuote;

		private static byte[] fileNameField;

		private static byte[] ampersand;

		private static byte[] equal;

		internal static Encoding DefaultEncoding => null;
	}
}
