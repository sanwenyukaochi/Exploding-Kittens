namespace System.Net.Cache
{
	public class RequestCachePolicy
	{
		private RequestCacheLevel m_Level;

		public RequestCacheLevel Level => default(RequestCacheLevel);

		public RequestCachePolicy(RequestCacheLevel level)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
