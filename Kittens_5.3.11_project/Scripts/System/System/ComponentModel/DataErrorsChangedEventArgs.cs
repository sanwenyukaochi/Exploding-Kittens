namespace System.ComponentModel
{
	public class DataErrorsChangedEventArgs : EventArgs
	{
		private readonly string _propertyName;

		public virtual string PropertyName => null;

		public DataErrorsChangedEventArgs(string propertyName)
		{
		}
	}
}
