using System.Collections.Generic;
using UnityEngine;

public class InAppPurchaseController : MonoBehaviour
{
	private Queue<InAppPurchaseRequest> purchaseQueue;

	private InAppPurchaseRequest currentRequest;

	private bool WaitingForTransaction => false;

	private bool NoPurchaseRequests => false;

	public void EnqueuePurchaseRequest(InAppPurchaseRequest request)
	{
	}

	private void ExecuteNextTransaction()
	{
	}

	private void RegisterForPurchaseEvents(InAppPurchaseRequest request)
	{
	}

	private void DeregisterForPurchaseEvents(InAppPurchaseRequest request)
	{
	}

	private void OnPurchaseSucceeded()
	{
	}

	private void OnPurchaseFailed()
	{
	}
}
