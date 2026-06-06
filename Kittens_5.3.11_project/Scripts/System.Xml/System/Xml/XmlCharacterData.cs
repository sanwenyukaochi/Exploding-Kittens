namespace System.Xml
{
	public abstract class XmlCharacterData : XmlLinkedNode
	{
		private string data;

		public override string Value
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string InnerText
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual string Data
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected internal XmlCharacterData(string data, XmlDocument doc)
			: base(null)
		{
		}

		internal bool CheckOnData(string data)
		{
			return false;
		}
	}
}
