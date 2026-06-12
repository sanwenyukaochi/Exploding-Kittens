namespace System.ComponentModel
{
	public class PropertyChangingEventArgs : EventArgs
	{
		private readonly string _propertyName;

		public virtual string PropertyName => null;

		public PropertyChangingEventArgs(string propertyName)
		{
		}
	}
}
