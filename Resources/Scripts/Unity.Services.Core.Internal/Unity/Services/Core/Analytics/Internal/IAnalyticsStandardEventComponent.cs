using System.Collections.Generic;
using Unity.Services.Core.Internal;

namespace Unity.Services.Core.Analytics.Internal
{
	public interface IAnalyticsStandardEventComponent : IServiceComponent
	{
		void Record(string eventName, IDictionary<string, object> eventParameters, int eventVersion, string packageName);
	}
}
