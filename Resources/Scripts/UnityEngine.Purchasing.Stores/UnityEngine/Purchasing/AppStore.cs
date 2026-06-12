using System;

namespace UnityEngine.Purchasing
{
	public enum AppStore
	{
		NotSpecified = 0,
		GooglePlay = 1,
		AmazonAppStore = 2,
		[Obsolete("AppStore to be removed with UDP deprecation.")]
		UDP = 3,
		MacAppStore = 4,
		AppleAppStore = 5,
		WinRT = 6,
		fake = 7
	}
}
