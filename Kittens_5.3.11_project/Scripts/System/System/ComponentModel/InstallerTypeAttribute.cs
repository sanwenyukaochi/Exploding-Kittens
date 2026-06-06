namespace System.ComponentModel
{
	[AttributeUsage(AttributeTargets.Class)]
	public class InstallerTypeAttribute : Attribute
	{
		private string _typeName;

		public virtual Type InstallerType => null;

		public InstallerTypeAttribute(Type installerType)
		{
		}

		public InstallerTypeAttribute(string typeName)
		{
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
