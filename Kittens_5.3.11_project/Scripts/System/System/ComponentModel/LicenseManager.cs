using System.Collections;

namespace System.ComponentModel
{
	public sealed class LicenseManager
	{
		private static readonly object s_selfLock;

		private static LicenseContext s_context;

		private static object s_contextLockHolder;

		private static Hashtable s_providers;

		private static Hashtable s_providerInstances;

		private static readonly object s_internalSyncObject;

		public static LicenseContext CurrentContext
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static LicenseUsageMode UsageMode => default(LicenseUsageMode);

		private LicenseManager()
		{
		}

		private static void CacheProvider(Type type, LicenseProvider provider)
		{
		}

		public static object CreateWithContext(Type type, LicenseContext creationContext)
		{
			return null;
		}

		public static object CreateWithContext(Type type, LicenseContext creationContext, object[] args)
		{
			return null;
		}

		private static bool GetCachedNoLicenseProvider(Type type)
		{
			return false;
		}

		private static LicenseProvider GetCachedProvider(Type type)
		{
			return null;
		}

		private static LicenseProvider GetCachedProviderInstance(Type providerType)
		{
			return null;
		}

		public static bool IsLicensed(Type type)
		{
			return false;
		}

		public static bool IsValid(Type type)
		{
			return false;
		}

		public static bool IsValid(Type type, object instance, out License license)
		{
			license = null;
			return false;
		}

		public static void LockContext(object contextUser)
		{
		}

		public static void UnlockContext(object contextUser)
		{
		}

		private static bool ValidateInternal(Type type, object instance, bool allowExceptions, out License license)
		{
			license = null;
			return false;
		}

		private static bool ValidateInternalRecursive(LicenseContext context, Type type, object instance, bool allowExceptions, out License license, out string licenseKey)
		{
			license = null;
			licenseKey = null;
			return false;
		}

		public static void Validate(Type type)
		{
		}

		public static License Validate(Type type, object instance)
		{
			return null;
		}
	}
}
