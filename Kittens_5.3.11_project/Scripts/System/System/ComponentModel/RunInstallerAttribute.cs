namespace System.ComponentModel
{
	[AttributeUsage(AttributeTargets.Class)]
	public class RunInstallerAttribute : Attribute
	{
		public static readonly RunInstallerAttribute Yes;

		public static readonly RunInstallerAttribute No;

		public static readonly RunInstallerAttribute Default;

		public bool RunInstaller { get; }

		public RunInstallerAttribute(bool runInstaller)
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

		public override bool IsDefaultAttribute()
		{
			return false;
		}
	}
}
