namespace System.ComponentModel
{
	public class LicFileLicenseProvider : LicenseProvider
	{
		private class LicFileLicense : License
		{
			private LicFileLicenseProvider _owner;

			public override string LicenseKey { get; }

			public LicFileLicense(LicFileLicenseProvider owner, string key)
			{
			}

			public override void Dispose()
			{
			}
		}

		protected virtual bool IsKeyValid(string key, Type type)
		{
			return false;
		}

		protected virtual string GetKey(Type type)
		{
			return null;
		}

		public override License GetLicense(LicenseContext context, Type type, object instance, bool allowExceptions)
		{
			return null;
		}
	}
}
