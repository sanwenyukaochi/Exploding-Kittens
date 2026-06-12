namespace System.ComponentModel
{
	public class PropertyChangedEventArgs : EventArgs
	{
		private readonly string _propertyName;

		public virtual string PropertyName => null;

		public PropertyChangedEventArgs(string propertyName)
		{
		}
	}
}
