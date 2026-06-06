namespace System.ComponentModel
{
	[AttributeUsage(AttributeTargets.All)]
	public class CategoryAttribute : Attribute
	{
		private static CategoryAttribute appearance;

		private static CategoryAttribute asynchronous;

		private static CategoryAttribute behavior;

		private static CategoryAttribute data;

		private static CategoryAttribute design;

		private static CategoryAttribute action;

		private static CategoryAttribute format;

		private static CategoryAttribute layout;

		private static CategoryAttribute mouse;

		private static CategoryAttribute key;

		private static CategoryAttribute focus;

		private static CategoryAttribute windowStyle;

		private static CategoryAttribute dragDrop;

		private static CategoryAttribute defAttr;

		private bool localized;

		private string categoryValue;

		public static CategoryAttribute Action => null;

		public static CategoryAttribute Appearance => null;

		public static CategoryAttribute Asynchronous => null;

		public static CategoryAttribute Behavior => null;

		public static CategoryAttribute Data => null;

		public static CategoryAttribute Default => null;

		public static CategoryAttribute Design => null;

		public static CategoryAttribute DragDrop => null;

		public static CategoryAttribute Focus => null;

		public static CategoryAttribute Format => null;

		public static CategoryAttribute Key => null;

		public static CategoryAttribute Layout => null;

		public static CategoryAttribute Mouse => null;

		public static CategoryAttribute WindowStyle => null;

		public string Category => null;

		public CategoryAttribute()
		{
		}

		public CategoryAttribute(string category)
		{
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		protected virtual string GetLocalizedString(string value)
		{
			return null;
		}

		public override bool IsDefaultAttribute()
		{
			return false;
		}
	}
}
