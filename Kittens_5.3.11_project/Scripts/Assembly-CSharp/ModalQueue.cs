using System;
using System.Collections.Generic;
using UnityEngine;

public class ModalQueue : MonoBehaviour
{
	public ModalDelegate OnShowingFirstModal;

	public ModalDelegate OnAllModalsEnded;

	private Queue<IModal> queue;

	private IModal currentModal;

	private bool Empty => false;

	private bool ShowingModal => false;

	public void Enqueue(IModal modal)
	{
	}

	public void WhenShowingModals(Action callback)
	{
	}

	private void ShowNextInQueue()
	{
	}

	private void OnDone()
	{
	}
}
