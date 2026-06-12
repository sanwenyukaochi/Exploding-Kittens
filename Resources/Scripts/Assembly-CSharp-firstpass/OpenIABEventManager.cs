using System;
using System.Runtime.CompilerServices;
using OnePF;
using UnityEngine;

public class OpenIABEventManager : MonoBehaviour
{
	public static event Action billingSupportedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event Action<string> billingNotSupportedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event Action<Inventory> queryInventorySucceededEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event Action<string> queryInventoryFailedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event Action<Purchase> purchaseSucceededEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event Action<int, string> purchaseFailedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event Action<Purchase> consumePurchaseSucceededEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event Action<string> consumePurchaseFailedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event Action<string> transactionRestoredEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event Action<string> restoreFailedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event Action restoreSucceededEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Awake()
	{
	}

	private void OnMapSkuFailed(string exception)
	{
	}

	private void OnBillingSupported(string empty)
	{
	}

	private void OnBillingNotSupported(string error)
	{
	}

	private void OnQueryInventorySucceeded(string json)
	{
	}

	private void OnQueryInventoryFailed(string error)
	{
	}

	private void OnPurchaseSucceeded(string json)
	{
	}

	private void OnPurchaseFailed(string message)
	{
	}

	private void OnConsumePurchaseSucceeded(string json)
	{
	}

	private void OnConsumePurchaseFailed(string error)
	{
	}

	public void OnTransactionRestored(string sku)
	{
	}

	public void OnRestoreTransactionFailed(string error)
	{
	}

	public void OnRestoreTransactionSucceeded(string message)
	{
	}
}
