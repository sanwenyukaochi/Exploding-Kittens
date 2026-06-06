namespace System.Resources
{
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false)]
	public sealed class SatelliteContractVersionAttribute : Attribute
	{
		public string Version { get; }

		public SatelliteContractVersionAttribute(string version)
		{
		}
	}
}
