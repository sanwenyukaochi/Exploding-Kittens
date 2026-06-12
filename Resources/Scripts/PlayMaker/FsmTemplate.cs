using System;
using HutongGames.PlayMaker;
using UnityEngine;

[Serializable]
public class FsmTemplate : ScriptableObject
{
	[Delayed]
	[SerializeField]
	private string category;

	public Fsm fsm;

	public string Description => null;

	public string Category
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public void OnEnable()
	{
	}
}
