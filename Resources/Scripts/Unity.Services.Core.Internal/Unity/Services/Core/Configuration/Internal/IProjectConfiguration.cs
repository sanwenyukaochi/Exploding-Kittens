using Unity.Services.Core.Internal;

namespace Unity.Services.Core.Configuration.Internal
{
	public interface IProjectConfiguration : IServiceComponent
	{
		string GetString(string key, string defaultValue = null);
	}
}
