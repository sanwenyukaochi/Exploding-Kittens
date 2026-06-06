using System.Collections;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace System.ComponentModel
{
	public sealed class TypeDescriptor
	{
		private sealed class AttributeProvider : TypeDescriptionProvider
		{
			private class AttributeTypeDescriptor : CustomTypeDescriptor
			{
				private Attribute[] _attributeArray;

				internal AttributeTypeDescriptor(Attribute[] attrs, ICustomTypeDescriptor parent)
				{
				}

				public override AttributeCollection GetAttributes()
				{
					return null;
				}
			}

			private Attribute[] _attrs;

			internal AttributeProvider(TypeDescriptionProvider existingProvider, params Attribute[] attrs)
			{
			}

			public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance)
			{
				return null;
			}
		}

		private sealed class ComNativeDescriptionProvider : TypeDescriptionProvider
		{
			private sealed class ComNativeTypeDescriptor : ICustomTypeDescriptor
			{
				private IComNativeDescriptorHandler _handler;

				private object _instance;

				internal ComNativeTypeDescriptor(IComNativeDescriptorHandler handler, object instance)
				{
				}

				AttributeCollection ICustomTypeDescriptor.GetAttributes()
				{
					return null;
				}

				string ICustomTypeDescriptor.GetClassName()
				{
					return null;
				}

				string ICustomTypeDescriptor.GetComponentName()
				{
					return null;
				}

				TypeConverter ICustomTypeDescriptor.GetConverter()
				{
					return null;
				}

				EventDescriptor ICustomTypeDescriptor.GetDefaultEvent()
				{
					return null;
				}

				PropertyDescriptor ICustomTypeDescriptor.GetDefaultProperty()
				{
					return null;
				}

				object ICustomTypeDescriptor.GetEditor(Type editorBaseType)
				{
					return null;
				}

				EventDescriptorCollection ICustomTypeDescriptor.GetEvents()
				{
					return null;
				}

				EventDescriptorCollection ICustomTypeDescriptor.GetEvents(Attribute[] attributes)
				{
					return null;
				}

				PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties()
				{
					return null;
				}

				PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties(Attribute[] attributes)
				{
					return null;
				}

				object ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd)
				{
					return null;
				}
			}

			private IComNativeDescriptorHandler _handler;

			internal IComNativeDescriptorHandler Handler
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			internal ComNativeDescriptionProvider(IComNativeDescriptorHandler handler)
			{
			}

			public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance)
			{
				return null;
			}
		}

		private sealed class AttributeFilterCacheItem
		{
			private Attribute[] _filter;

			internal ICollection FilteredMembers;

			internal AttributeFilterCacheItem(Attribute[] filter, ICollection filteredMembers)
			{
			}

			internal bool IsValid(Attribute[] filter)
			{
				return false;
			}
		}

		private sealed class FilterCacheItem
		{
			private ITypeDescriptorFilterService _filterService;

			internal ICollection FilteredMembers;

			internal FilterCacheItem(ITypeDescriptorFilterService filterService, ICollection filteredMembers)
			{
			}

			internal bool IsValid(ITypeDescriptorFilterService filterService)
			{
				return false;
			}
		}

		private interface IUnimplemented
		{
		}

		private sealed class MemberDescriptorComparer : IComparer
		{
			public static readonly MemberDescriptorComparer Instance;

			public int Compare(object left, object right)
			{
				return 0;
			}
		}

		private sealed class MergedTypeDescriptor : ICustomTypeDescriptor
		{
			private ICustomTypeDescriptor _primary;

			private ICustomTypeDescriptor _secondary;

			internal MergedTypeDescriptor(ICustomTypeDescriptor primary, ICustomTypeDescriptor secondary)
			{
			}

			AttributeCollection ICustomTypeDescriptor.GetAttributes()
			{
				return null;
			}

			string ICustomTypeDescriptor.GetClassName()
			{
				return null;
			}

			string ICustomTypeDescriptor.GetComponentName()
			{
				return null;
			}

			TypeConverter ICustomTypeDescriptor.GetConverter()
			{
				return null;
			}

			EventDescriptor ICustomTypeDescriptor.GetDefaultEvent()
			{
				return null;
			}

			PropertyDescriptor ICustomTypeDescriptor.GetDefaultProperty()
			{
				return null;
			}

			object ICustomTypeDescriptor.GetEditor(Type editorBaseType)
			{
				return null;
			}

			EventDescriptorCollection ICustomTypeDescriptor.GetEvents()
			{
				return null;
			}

			EventDescriptorCollection ICustomTypeDescriptor.GetEvents(Attribute[] attributes)
			{
				return null;
			}

			PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties()
			{
				return null;
			}

			PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties(Attribute[] attributes)
			{
				return null;
			}

			object ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd)
			{
				return null;
			}
		}

		private sealed class TypeDescriptionNode : TypeDescriptionProvider
		{
			private struct DefaultExtendedTypeDescriptor : ICustomTypeDescriptor
			{
				private TypeDescriptionNode _node;

				private object _instance;

				internal DefaultExtendedTypeDescriptor(TypeDescriptionNode node, object instance)
				{
					_node = null;
					_instance = null;
				}

				AttributeCollection ICustomTypeDescriptor.GetAttributes()
				{
					return null;
				}

				string ICustomTypeDescriptor.GetClassName()
				{
					return null;
				}

				string ICustomTypeDescriptor.GetComponentName()
				{
					return null;
				}

				TypeConverter ICustomTypeDescriptor.GetConverter()
				{
					return null;
				}

				EventDescriptor ICustomTypeDescriptor.GetDefaultEvent()
				{
					return null;
				}

				PropertyDescriptor ICustomTypeDescriptor.GetDefaultProperty()
				{
					return null;
				}

				object ICustomTypeDescriptor.GetEditor(Type editorBaseType)
				{
					return null;
				}

				EventDescriptorCollection ICustomTypeDescriptor.GetEvents()
				{
					return null;
				}

				EventDescriptorCollection ICustomTypeDescriptor.GetEvents(Attribute[] attributes)
				{
					return null;
				}

				PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties()
				{
					return null;
				}

				PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties(Attribute[] attributes)
				{
					return null;
				}

				object ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd)
				{
					return null;
				}
			}

			private struct DefaultTypeDescriptor : ICustomTypeDescriptor
			{
				private TypeDescriptionNode _node;

				private Type _objectType;

				private object _instance;

				internal DefaultTypeDescriptor(TypeDescriptionNode node, Type objectType, object instance)
				{
					_node = null;
					_objectType = null;
					_instance = null;
				}

				AttributeCollection ICustomTypeDescriptor.GetAttributes()
				{
					return null;
				}

				string ICustomTypeDescriptor.GetClassName()
				{
					return null;
				}

				string ICustomTypeDescriptor.GetComponentName()
				{
					return null;
				}

				TypeConverter ICustomTypeDescriptor.GetConverter()
				{
					return null;
				}

				EventDescriptor ICustomTypeDescriptor.GetDefaultEvent()
				{
					return null;
				}

				PropertyDescriptor ICustomTypeDescriptor.GetDefaultProperty()
				{
					return null;
				}

				object ICustomTypeDescriptor.GetEditor(Type editorBaseType)
				{
					return null;
				}

				EventDescriptorCollection ICustomTypeDescriptor.GetEvents()
				{
					return null;
				}

				EventDescriptorCollection ICustomTypeDescriptor.GetEvents(Attribute[] attributes)
				{
					return null;
				}

				PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties()
				{
					return null;
				}

				PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties(Attribute[] attributes)
				{
					return null;
				}

				object ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd)
				{
					return null;
				}
			}

			internal TypeDescriptionNode Next;

			internal TypeDescriptionProvider Provider;

			internal TypeDescriptionNode(TypeDescriptionProvider provider)
			{
			}

			public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args)
			{
				return null;
			}

			public override IDictionary GetCache(object instance)
			{
				return null;
			}

			public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance)
			{
				return null;
			}

			protected internal override IExtenderProvider[] GetExtenderProviders(object instance)
			{
				return null;
			}

			public override string GetFullComponentName(object component)
			{
				return null;
			}

			public override Type GetReflectionType(Type objectType, object instance)
			{
				return null;
			}

			public override Type GetRuntimeType(Type objectType)
			{
				return null;
			}

			public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance)
			{
				return null;
			}

			public override bool IsSupportedType(Type type)
			{
				return false;
			}
		}

		[TypeDescriptionProvider("System.Windows.Forms.ComponentModel.Com2Interop.ComNativeDescriptor, System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
		private sealed class TypeDescriptorComObject
		{
		}

		private sealed class TypeDescriptorInterface
		{
		}

		private static WeakHashtable _providerTable;

		private static Hashtable _providerTypeTable;

		private static Hashtable _defaultProviders;

		private static WeakHashtable _associationTable;

		private static int _metadataVersion;

		private static int _collisionIndex;

		private static BooleanSwitch TraceDescriptor;

		private const int PIPELINE_ATTRIBUTES = 0;

		private const int PIPELINE_PROPERTIES = 1;

		private const int PIPELINE_EVENTS = 2;

		private static readonly Guid[] _pipelineInitializeKeys;

		private static readonly Guid[] _pipelineMergeKeys;

		private static readonly Guid[] _pipelineFilterKeys;

		private static readonly Guid[] _pipelineAttributeFilterKeys;

		private static object _internalSyncObject;

		[Obsolete("This property has been deprecated.  Use a type description provider to supply type information for COM types instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
		public static IComNativeDescriptorHandler ComNativeDescriptorHandler
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static Type ComObjectType => null;

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static Type InterfaceType => null;

		internal static int MetadataVersion => 0;

		public static event RefreshEventHandler Refreshed
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private TypeDescriptor()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static TypeDescriptionProvider AddAttributes(Type type, params Attribute[] attributes)
		{
			return null;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static TypeDescriptionProvider AddAttributes(object instance, params Attribute[] attributes)
		{
			return null;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static void AddEditorTable(Type editorBaseType, Hashtable table)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static void AddProvider(TypeDescriptionProvider provider, Type type)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static void AddProvider(TypeDescriptionProvider provider, object instance)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static void AddProviderTransparent(TypeDescriptionProvider provider, Type type)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static void AddProviderTransparent(TypeDescriptionProvider provider, object instance)
		{
		}

		private static void CheckDefaultProvider(Type type)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static void CreateAssociation(object primary, object secondary)
		{
		}

		public static IDesigner CreateDesigner(IComponent component, Type designerBaseType)
		{
			return null;
		}

		public static EventDescriptor CreateEvent(Type componentType, string name, Type type, params Attribute[] attributes)
		{
			return null;
		}

		public static EventDescriptor CreateEvent(Type componentType, EventDescriptor oldEventDescriptor, params Attribute[] attributes)
		{
			return null;
		}

		public static object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args)
		{
			return null;
		}

		public static PropertyDescriptor CreateProperty(Type componentType, string name, Type type, params Attribute[] attributes)
		{
			return null;
		}

		public static PropertyDescriptor CreateProperty(Type componentType, PropertyDescriptor oldPropertyDescriptor, params Attribute[] attributes)
		{
			return null;
		}

		[Conditional("DEBUG")]
		private static void DebugValidate(Type type, AttributeCollection attributes, AttributeCollection debugAttributes)
		{
		}

		[Conditional("DEBUG")]
		private static void DebugValidate(AttributeCollection attributes, AttributeCollection debugAttributes)
		{
		}

		[Conditional("DEBUG")]
		private static void DebugValidate(AttributeCollection attributes, Type type)
		{
		}

		[Conditional("DEBUG")]
		private static void DebugValidate(AttributeCollection attributes, object instance, bool noCustomTypeDesc)
		{
		}

		[Conditional("DEBUG")]
		private static void DebugValidate(TypeConverter converter, Type type)
		{
		}

		[Conditional("DEBUG")]
		private static void DebugValidate(TypeConverter converter, object instance, bool noCustomTypeDesc)
		{
		}

		[Conditional("DEBUG")]
		private static void DebugValidate(EventDescriptorCollection events, Type type, Attribute[] attributes)
		{
		}

		[Conditional("DEBUG")]
		private static void DebugValidate(EventDescriptorCollection events, object instance, Attribute[] attributes, bool noCustomTypeDesc)
		{
		}

		[Conditional("DEBUG")]
		private static void DebugValidate(PropertyDescriptorCollection properties, Type type, Attribute[] attributes)
		{
		}

		[Conditional("DEBUG")]
		private static void DebugValidate(PropertyDescriptorCollection properties, object instance, Attribute[] attributes, bool noCustomTypeDesc)
		{
		}

		private static ArrayList FilterMembers(IList members, Attribute[] attributes)
		{
			return null;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static object GetAssociation(Type type, object primary)
		{
			return null;
		}

		public static AttributeCollection GetAttributes(Type componentType)
		{
			return null;
		}

		public static AttributeCollection GetAttributes(object component)
		{
			return null;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static AttributeCollection GetAttributes(object component, bool noCustomTypeDesc)
		{
			return null;
		}

		internal static IDictionary GetCache(object instance)
		{
			return null;
		}

		public static string GetClassName(object component)
		{
			return null;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static string GetClassName(object component, bool noCustomTypeDesc)
		{
			return null;
		}

		public static string GetClassName(Type componentType)
		{
			return null;
		}

		public static string GetComponentName(object component)
		{
			return null;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static string GetComponentName(object component, bool noCustomTypeDesc)
		{
			return null;
		}

		public static TypeConverter GetConverter(object component)
		{
			return null;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static TypeConverter GetConverter(object component, bool noCustomTypeDesc)
		{
			return null;
		}

		public static TypeConverter GetConverter(Type type)
		{
			return null;
		}

		private static object ConvertFromInvariantString(Type type, string stringValue)
		{
			return null;
		}

		public static EventDescriptor GetDefaultEvent(Type componentType)
		{
			return null;
		}

		public static EventDescriptor GetDefaultEvent(object component)
		{
			return null;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static EventDescriptor GetDefaultEvent(object component, bool noCustomTypeDesc)
		{
			return null;
		}

		public static PropertyDescriptor GetDefaultProperty(Type componentType)
		{
			return null;
		}

		public static PropertyDescriptor GetDefaultProperty(object component)
		{
			return null;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static PropertyDescriptor GetDefaultProperty(object component, bool noCustomTypeDesc)
		{
			return null;
		}

		internal static ICustomTypeDescriptor GetDescriptor(Type type, string typeName)
		{
			return null;
		}

		internal static ICustomTypeDescriptor GetDescriptor(object component, bool noCustomTypeDesc)
		{
			return null;
		}

		internal static ICustomTypeDescriptor GetExtendedDescriptor(object component)
		{
			return null;
		}

		public static object GetEditor(object component, Type editorBaseType)
		{
			return null;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static object GetEditor(object component, Type editorBaseType, bool noCustomTypeDesc)
		{
			return null;
		}

		public static object GetEditor(Type type, Type editorBaseType)
		{
			return null;
		}

		public static EventDescriptorCollection GetEvents(Type componentType)
		{
			return null;
		}

		public static EventDescriptorCollection GetEvents(Type componentType, Attribute[] attributes)
		{
			return null;
		}

		public static EventDescriptorCollection GetEvents(object component)
		{
			return null;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static EventDescriptorCollection GetEvents(object component, bool noCustomTypeDesc)
		{
			return null;
		}

		public static EventDescriptorCollection GetEvents(object component, Attribute[] attributes)
		{
			return null;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static EventDescriptorCollection GetEvents(object component, Attribute[] attributes, bool noCustomTypeDesc)
		{
			return null;
		}

		private static string GetExtenderCollisionSuffix(MemberDescriptor member)
		{
			return null;
		}

		public static string GetFullComponentName(object component)
		{
			return null;
		}

		private static Type GetNodeForBaseType(Type searchType)
		{
			return null;
		}

		public static PropertyDescriptorCollection GetProperties(Type componentType)
		{
			return null;
		}

		public static PropertyDescriptorCollection GetProperties(Type componentType, Attribute[] attributes)
		{
			return null;
		}

		public static PropertyDescriptorCollection GetProperties(object component)
		{
			return null;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static PropertyDescriptorCollection GetProperties(object component, bool noCustomTypeDesc)
		{
			return null;
		}

		public static PropertyDescriptorCollection GetProperties(object component, Attribute[] attributes)
		{
			return null;
		}

		public static PropertyDescriptorCollection GetProperties(object component, Attribute[] attributes, bool noCustomTypeDesc)
		{
			return null;
		}

		private static PropertyDescriptorCollection GetPropertiesImpl(object component, Attribute[] attributes, bool noCustomTypeDesc, bool noAttributes)
		{
			return null;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static TypeDescriptionProvider GetProvider(Type type)
		{
			return null;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static TypeDescriptionProvider GetProvider(object instance)
		{
			return null;
		}

		internal static TypeDescriptionProvider GetProviderRecursive(Type type)
		{
			return null;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static Type GetReflectionType(Type type)
		{
			return null;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static Type GetReflectionType(object instance)
		{
			return null;
		}

		private static TypeDescriptionNode NodeFor(Type type)
		{
			return null;
		}

		private static TypeDescriptionNode NodeFor(Type type, bool createDelegator)
		{
			return null;
		}

		private static TypeDescriptionNode NodeFor(object instance)
		{
			return null;
		}

		private static TypeDescriptionNode NodeFor(object instance, bool createDelegator)
		{
			return null;
		}

		private static void NodeRemove(object key, TypeDescriptionProvider provider)
		{
		}

		private static ICollection PipelineAttributeFilter(int pipelineType, ICollection members, Attribute[] filter, object instance, IDictionary cache)
		{
			return null;
		}

		private static ICollection PipelineFilter(int pipelineType, ICollection members, object instance, IDictionary cache)
		{
			return null;
		}

		private static ICollection PipelineInitialize(int pipelineType, ICollection members, IDictionary cache)
		{
			return null;
		}

		private static ICollection PipelineMerge(int pipelineType, ICollection primary, ICollection secondary, object instance, IDictionary cache)
		{
			return null;
		}

		private static void RaiseRefresh(object component)
		{
		}

		private static void RaiseRefresh(Type type)
		{
		}

		public static void Refresh(object component)
		{
		}

		private static void Refresh(object component, bool refreshReflectionProvider)
		{
		}

		public static void Refresh(Type type)
		{
		}

		public static void Refresh(Module module)
		{
		}

		public static void Refresh(Assembly assembly)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static void RemoveAssociation(object primary, object secondary)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static void RemoveAssociations(object primary)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static void RemoveProvider(TypeDescriptionProvider provider, Type type)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static void RemoveProvider(TypeDescriptionProvider provider, object instance)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static void RemoveProviderTransparent(TypeDescriptionProvider provider, Type type)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static void RemoveProviderTransparent(TypeDescriptionProvider provider, object instance)
		{
		}

		private static bool ShouldHideMember(MemberDescriptor member, Attribute attribute)
		{
			return false;
		}

		public static void SortDescriptorArray(IList infos)
		{
		}

		[Conditional("DEBUG")]
		internal static void Trace(string message, params object[] args)
		{
		}
	}
}
