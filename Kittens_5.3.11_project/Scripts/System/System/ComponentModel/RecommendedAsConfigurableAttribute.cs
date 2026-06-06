namespace System.ComponentModel
{
	[Obsolete("Use System.ComponentModel.SettingsBindableAttribute instead to work with the new settings model.")]
	[AttributeUsage(AttributeTargets.Property)]
	public class RecommendedAsConfigurableAttribute : Attribute
	{
		public static readonly RecommendedAsConfigurableAttribute No;

		public static readonly RecommendedAsConfigurableAttribute Yes;

		public static readonly RecommendedAsConfigurableAttribute Default;

		public bool RecommendedAsConfigurable { get; }

		public RecommendedAsConfigurableAttribute(bool recommendedAsConfigurable)
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

		public override bool IsDefaultAttribute()
		{
			return false;
		}
	}
}
