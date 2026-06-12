using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Purchasing;
using UnityEngine.Purchasing.Extension;
using UnityEngine.SceneManagement;

public class Purchaser : MonoBehaviour, IDetailedStoreListener, IStoreListener
{
	public class Receipt
	{
		public string Store;

		public string TransactionID;

		public string Payload;

		public Receipt()
		{
		}

		public Receipt(string store, string transactionID, string payload)
		{
		}
	}

	public class PayloadAndroid
	{
		public string json;

		public string signature;

		public PayloadAndroid()
		{
		}

		public PayloadAndroid(string _json, string _signature)
		{
		}
	}

	public static Purchaser Instance;

	public GenericEvent OnPurchaseSucceededEvent;

	public GenericEvent OnPurchaseFailedEvent;

	public GenericEvent OnRestoreSucceededEvent;

	public GenericEvent OnRestoreFailedEvent;

	public PurchasableProductRepository PurchasableProductRepository;

	private static IStoreController m_StoreController;

	private static IExtensionProvider m_StoreExtensionProvider;

	private InAppPurchaseRequest InAppPurchaseRequest;

	public MessageBoxModal MessageBoxModal;

	public GameObject InputBlock;

	private bool m_PurchaseInitiated;

	private bool m_RestorePurchase;

	private void Awake()
	{
	}

	public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	private void Start()
	{
	}

	private Task _InitUnityGamingServices()
	{
		return null;
	}

	public void InitializePurchasing()
	{
	}

	private bool IsInitialized()
	{
		return false;
	}

	public void BuyProductID(string productId)
	{
	}

	public void RestorePurchases()
	{
	}

	public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
	{
	}

	public void OnInitializeFailed(InitializationFailureReason error)
	{
	}

	public void OnInitializeFailed(InitializationFailureReason error, string message)
	{
	}

	public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs args)
	{
		return default(PurchaseProcessingResult);
	}

	public void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason)
	{
	}

	public bool HasProduct(string sku)
	{
		return false;
	}

	public string GetPrice(string sku)
	{
		return null;
	}

	public bool ValidateReceipt(string sku)
	{
		return false;
	}

	private void Update()
	{
	}

	public void OnPurchaseFailed(Product product, PurchaseFailureDescription failureDescription)
	{
	}
}
