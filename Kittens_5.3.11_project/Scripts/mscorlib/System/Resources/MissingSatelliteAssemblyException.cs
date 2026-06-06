using System.Runtime.Serialization;

namespace System.Resources
{
	[Serializable]
	public class MissingSatelliteAssemblyException : SystemException
	{
		private string _cultureName;

		public MissingSatelliteAssemblyException()
		{
		}

		public MissingSatelliteAssemblyException(string message, string cultureName)
		{
		}

		protected MissingSatelliteAssemblyException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
