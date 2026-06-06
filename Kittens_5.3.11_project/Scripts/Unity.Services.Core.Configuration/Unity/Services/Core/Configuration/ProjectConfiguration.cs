using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Services.Core.Configuration.Internal;
using Unity.Services.Core.Internal;
using Unity.Services.Core.Internal.Serialization;

namespace Unity.Services.Core.Configuration
{
	internal class ProjectConfiguration : IProjectConfiguration, IServiceComponent
	{
		private readonly IReadOnlyDictionary<string, ConfigurationEntry> m_ConfigValues;

		[CompilerGenerated]
		private readonly IJsonSerializer _003CSerializer_003Ek__BackingField;

		public ProjectConfiguration(IReadOnlyDictionary<string, ConfigurationEntry> configValues, IJsonSerializer serializer)
		{
		}

		public string GetString(string key, string defaultValue = null)
		{
			return null;
		}
	}
}
