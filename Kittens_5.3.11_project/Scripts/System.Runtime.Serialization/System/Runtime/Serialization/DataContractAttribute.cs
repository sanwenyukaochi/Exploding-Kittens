namespace System.Runtime.Serialization
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum, Inherited = false, AllowMultiple = false)]
	public sealed class DataContractAttribute : Attribute
	{
		private bool isReference;

		public bool IsReference => false;
	}
}
