using JetBrains.Annotations;

namespace Unity.Services.Core.Internal
{
	public sealed class CorePackageRegistry
	{
		public static CorePackageRegistry Instance { get; internal set; }

		internal IPackageRegistry Registry { get; set; }

		internal CorePackageRegistry()
		{
		}

		public CoreRegistration Register<TPackage>([NotNull] TPackage package) where TPackage : IInitializablePackage
		{
			return default(CoreRegistration);
		}

		internal void Lock()
		{
		}
	}
}
