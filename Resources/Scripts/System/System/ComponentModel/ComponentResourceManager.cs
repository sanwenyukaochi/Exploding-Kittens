using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Resources;

namespace System.ComponentModel
{
	public class ComponentResourceManager : ResourceManager
	{
		private Hashtable _resourceSets;

		private CultureInfo _neutralResourcesCulture;

		private CultureInfo NeutralResourcesCulture => null;

		public ComponentResourceManager()
		{
		}

		public ComponentResourceManager(Type t)
		{
		}

		public void ApplyResources(object value, string objectName)
		{
		}

		public virtual void ApplyResources(object value, string objectName, CultureInfo culture)
		{
		}

		private SortedList<string, object> FillResources(CultureInfo culture, out ResourceSet resourceSet)
		{
			resourceSet = null;
			return null;
		}
	}
}
