namespace System.Xml.Linq
{
	public abstract class XObject : IXmlLineInfo
	{
		internal XContainer parent;

		internal object annotations;

		public string BaseUri => null;

		public abstract XmlNodeType NodeType { get; }

		public XElement Parent => null;

		int IXmlLineInfo.LineNumber => 0;

		int IXmlLineInfo.LinePosition => 0;

		internal bool HasBaseUri => false;

		internal XObject()
		{
		}

		public void AddAnnotation(object annotation)
		{
		}

		private object AnnotationForSealedType(Type type)
		{
			return null;
		}

		public T Annotation<T>() where T : class
		{
			return null;
		}

		bool IXmlLineInfo.HasLineInfo()
		{
			return false;
		}

		internal bool NotifyChanged(object sender, XObjectChangeEventArgs e)
		{
			return false;
		}

		internal bool NotifyChanging(object sender, XObjectChangeEventArgs e)
		{
			return false;
		}

		internal void SetBaseUri(string baseUri)
		{
		}

		internal void SetLineInfo(int lineNumber, int linePosition)
		{
		}

		internal bool SkipNotify()
		{
			return false;
		}

		internal SaveOptions GetSaveOptionsFromAnnotations()
		{
			return default(SaveOptions);
		}
	}
}
