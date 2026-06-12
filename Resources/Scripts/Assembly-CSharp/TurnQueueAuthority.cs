using System;
using UnityEngine;

public class TurnQueueAuthority : MonoBehaviour
{
	public Player CurrentAuthority => null;

	public void WhenCurrentAuthority(Action callback)
	{
	}
}
