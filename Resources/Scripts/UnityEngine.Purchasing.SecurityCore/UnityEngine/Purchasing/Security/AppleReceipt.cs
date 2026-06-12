using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing.Security
{
	public class AppleReceipt
	{
		[CompilerGenerated]
		private string _003CappVersion_003Ek__BackingField;

		[CompilerGenerated]
		private byte[] _003Copaque_003Ek__BackingField;

		[CompilerGenerated]
		private byte[] _003Chash_003Ek__BackingField;

		[CompilerGenerated]
		private string _003CoriginalApplicationVersion_003Ek__BackingField;

		public AppleInAppPurchaseReceipt[] inAppPurchaseReceipts;

		public string bundleID { get; internal set; }

		internal string appVersion
		{
			[CompilerGenerated]
			set
			{
				_003CappVersion_003Ek__BackingField = value;
			}
		}

		internal byte[] opaque
		{
			[CompilerGenerated]
			set
			{
				_003Copaque_003Ek__BackingField = value;
			}
		}

		internal byte[] hash
		{
			[CompilerGenerated]
			set
			{
				_003Chash_003Ek__BackingField = value;
			}
		}

		internal string originalApplicationVersion
		{
			[CompilerGenerated]
			set
			{
				_003CoriginalApplicationVersion_003Ek__BackingField = value;
			}
		}

		public DateTime receiptCreationDate { get; internal set; }
	}
}
