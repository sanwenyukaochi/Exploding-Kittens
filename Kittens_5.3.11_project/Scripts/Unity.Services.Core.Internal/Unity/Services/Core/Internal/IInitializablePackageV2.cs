using System.Threading.Tasks;

namespace Unity.Services.Core.Internal
{
	public interface IInitializablePackageV2 : IInitializablePackage
	{
		Task InitializeInstanceAsync(CoreRegistry registry);
	}
}
