namespace System.Runtime.Serialization
{
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
	public sealed class DataMemberAttribute : Attribute
	{
		private string name;

		private int order;

		private bool isRequired;

		private bool emitDefaultValue;

		public string Name => null;

		public int Order => 0;

		public bool IsRequired => false;

		public bool EmitDefaultValue => false;
	}
}
