namespace System.Net
{
	public class Authorization
	{
		private string m_Message;

		private bool m_Complete;

		internal string ModuleAuthenticationType;

		public string Message => null;

		public bool Complete => false;

		public Authorization(string token)
		{
		}

		public Authorization(string token, bool finished)
		{
		}
	}
}
