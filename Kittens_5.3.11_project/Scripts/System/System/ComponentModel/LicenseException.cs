using System.Runtime.Serialization;

namespace System.ComponentModel
{
	[Serializable]
	public class LicenseException : SystemException
	{
		private Type type;

		private object instance;

		public Type LicensedType => null;

		public LicenseException(Type type)
		{
		}

		public LicenseException(Type type, object instance)
		{
		}

		public LicenseException(Type type, object instance, string message)
		{
		}

		public LicenseException(Type type, object instance, string message, Exception innerException)
		{
		}

		protected LicenseException(SerializationInfo info, StreamingContext context)
		{
		}

		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
