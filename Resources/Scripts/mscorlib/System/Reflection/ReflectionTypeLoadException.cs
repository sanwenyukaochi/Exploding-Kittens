using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Reflection
{
	[Serializable]
	public sealed class ReflectionTypeLoadException : SystemException, ISerializable
	{
		[CompilerGenerated]
		private readonly Type[] _003CTypes_003Ek__BackingField;

		public Exception[] LoaderExceptions { get; }

		public override string Message => null;

		public ReflectionTypeLoadException(Type[] classes, Exception[] exceptions)
		{
		}

		private ReflectionTypeLoadException(SerializationInfo info, StreamingContext context)
		{
		}

		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		public override string ToString()
		{
			return null;
		}

		private string CreateString(bool isMessage)
		{
			return null;
		}
	}
}
