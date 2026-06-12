using System;
using System.Collections.Generic;
using UnityEngine;

public class MainThreadQueue : MonoBehaviour
{
	private Queue<Action> queue;

	public static MainThreadQueue Instance;

	public int Count => 0;

	private void Start()
	{
	}

	public void Enqueue(Action action)
	{
	}

	private Action Dequeue()
	{
		return null;
	}

	private void Update()
	{
	}
}
