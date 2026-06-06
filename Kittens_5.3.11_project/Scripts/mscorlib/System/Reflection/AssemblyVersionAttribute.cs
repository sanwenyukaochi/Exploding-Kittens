namespace System.Reflection
{
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyVersionAttribute : Attribute
	{
		private readonly string _003CVersion_003Ek__BackingField;

		public string Version => _003CVersion_003Ek__BackingField;

		public AssemblyVersionAttribute(string version)
		{
			_003CVersion_003Ek__BackingField = version;
		}
	}
}
