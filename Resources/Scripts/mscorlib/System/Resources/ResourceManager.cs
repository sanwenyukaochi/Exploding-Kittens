using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Threading;

namespace System.Resources
{
	[Serializable]
	[ComVisible(true)]
	public class ResourceManager
	{
		internal class CultureNameResourceSetPair
		{
		}

		internal class ResourceManagerMediator
		{
			private ResourceManager _rm;

			internal string ModuleDir => null;

			internal Type LocationInfo => null;

			internal Type UserResourceSet => null;

			internal string BaseNameField => null;

			internal CultureInfo NeutralResourcesCulture => null;

			internal bool LookedForSatelliteContractVersion
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			internal Version SatelliteContractVersion
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			internal UltimateResourceFallbackLocation FallbackLoc => default(UltimateResourceFallbackLocation);

			internal RuntimeAssembly CallingAssembly => null;

			internal RuntimeAssembly MainAssembly => null;

			internal string BaseName => null;

			internal ResourceManagerMediator(ResourceManager rm)
			{
			}

			internal string GetResourceFileName(CultureInfo culture)
			{
				return null;
			}

			internal Version ObtainSatelliteContractVersion(Assembly a)
			{
				return null;
			}
		}

		protected string BaseNameField;

		[Obsolete("call InternalGetResourceSet instead")]
		protected Hashtable ResourceSets;

		[NonSerialized]
		private Dictionary<string, ResourceSet> _resourceSets;

		private string moduleDir;

		protected Assembly MainAssembly;

		private Type _locationInfo;

		private Type _userResourceSet;

		private CultureInfo _neutralResourcesCulture;

		[NonSerialized]
		private CultureNameResourceSetPair _lastUsedResourceCache;

		private bool _ignoreCase;

		private bool UseManifest;

		[OptionalField(VersionAdded = 1)]
		private bool UseSatelliteAssem;

		[OptionalField]
		private UltimateResourceFallbackLocation _fallbackLoc;

		[OptionalField]
		private Version _satelliteContractVersion;

		[OptionalField]
		private bool _lookedForSatelliteContractVersion;

		[OptionalField(VersionAdded = 1)]
		private Assembly _callingAssembly;

		[OptionalField(VersionAdded = 4)]
		private RuntimeAssembly m_callingAssembly;

		[NonSerialized]
		private IResourceGroveler resourceGroveler;

		public static readonly int MagicNumber;

		public static readonly int HeaderVersionNumber;

		private static readonly Type _minResourceSet;

		internal static readonly string ResReaderTypeName;

		internal static readonly string ResSetTypeName;

		internal static readonly string MscorlibName;

		internal static readonly int DEBUG;

		public virtual string BaseName => null;

		public virtual bool IgnoreCase => false;

		protected UltimateResourceFallbackLocation FallbackLocation => default(UltimateResourceFallbackLocation);

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Init()
		{
		}

		protected ResourceManager()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ResourceManager(Type resourceSource)
		{
		}

		[OnDeserializing]
		private void OnDeserializing(StreamingContext ctx)
		{
		}

		[OnDeserialized]
		private void OnDeserialized(StreamingContext ctx)
		{
		}

		[OnSerializing]
		private void OnSerializing(StreamingContext ctx)
		{
		}

		private void CommonAssemblyInit()
		{
		}

		protected virtual string GetResourceFileName(CultureInfo culture)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual ResourceSet GetResourceSet(CultureInfo culture, bool createIfNotExists, bool tryParents)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual ResourceSet InternalGetResourceSet(CultureInfo culture, bool createIfNotExists, bool tryParents)
		{
			return null;
		}

		private ResourceSet InternalGetResourceSet(CultureInfo requestedCulture, bool createIfNotExists, bool tryParents, ref StackCrawlMark stackMark)
		{
			return null;
		}

		private static void AddResourceSet(Dictionary<string, ResourceSet> localResourceSets, string cultureName, ref ResourceSet rs)
		{
		}

		protected static Version GetSatelliteContractVersion(Assembly a)
		{
			return null;
		}

		protected static CultureInfo GetNeutralResourcesLanguage(Assembly a)
		{
			return null;
		}

		internal static bool CompareNames(string asmTypeName1, string typeName2, AssemblyName asmName2)
		{
			return false;
		}

		private void SetAppXConfiguration()
		{
		}
	}
}
