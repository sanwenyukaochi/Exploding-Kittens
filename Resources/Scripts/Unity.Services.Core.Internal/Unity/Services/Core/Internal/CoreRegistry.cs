using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace Unity.Services.Core.Internal
{
	public sealed class CoreRegistry
	{
		[CompilerGenerated]
		private readonly string _003CInstanceId_003Ek__BackingField;

		[CompilerGenerated]
		private IServiceRegistry _003CServiceRegistry_003Ek__BackingField;

		public static CoreRegistry Instance { get; internal set; }

		internal ServicesType Type { get; private set; }

		internal InitializationOptions Options { get; set; }

		[NotNull]
		internal IPackageRegistry PackageRegistry { get; private set; }

		[NotNull]
		internal IComponentRegistry ComponentRegistry { get; private set; }

		[NotNull]
		private IServiceRegistry ServiceRegistry
		{
			[CompilerGenerated]
			set
			{
				_003CServiceRegistry_003Ek__BackingField = value;
			}
		}

		internal CoreRegistry(IPackageRegistry packageRegistry, ServicesType type = ServicesType.Default, string instanceId = null)
		{
		}

		public CoreRegistration RegisterPackage<TPackage>([NotNull] TPackage package) where TPackage : IInitializablePackage
		{
			return default(CoreRegistration);
		}

		public void RegisterServiceComponent<TComponent>([NotNull] TComponent component) where TComponent : IServiceComponent
		{
		}

		public TComponent GetServiceComponent<TComponent>() where TComponent : IServiceComponent
		{
			return default(TComponent);
		}

		internal void LockComponentRegistration()
		{
		}
	}
}
