using System.Runtime.InteropServices;

namespace System.Runtime.Serialization
{
	[AttributeUsage(AttributeTargets.Field, Inherited = false)]
	[ComVisible(true)]
	public sealed class OptionalFieldAttribute : Attribute
	{
		private int versionAdded;

		public int VersionAdded
		{
			set
			{
			}
		}
	}
}
