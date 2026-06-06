using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DefusableKittenController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CDelayDefuse_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public DefusableKittenController _003C_003E4__this;

		public Player player;

		public Card card;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CDelayDefuse_003Ed__14(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public DefuseModalFactory DefuseModalFactory;

	public CardSpawnLocationProvider SpawnLocationProvider;

	public GameMessages GameMessages;

	public BombPlacementModal BombPlacementModal;

	public PlayerHand PlayerHand;

	public PlayerProvider PlayerProvider;

	public DeckStats DeckStats;

	public int PlayerHandDepth;

	private int originalHandDepth;

	private DefusableKittenAnimation currentAnimation;

	private Card BombCard;

	private Player player => null;

	private bool BombPlacementDoesNotMatter => false;

	public void Start()
	{
	}

	private void OnDrawExplodingKitten(Player player, Card card)
	{
	}

	private void SetupDefuse(Player player, Card card)
	{
	}

	[IteratorStateMachine(typeof(_003CDelayDefuse_003Ed__14))]
	private IEnumerator DelayDefuse(Player player, Card card, float delay)
	{
		return null;
	}

	private void SendPlayerDied(Player player)
	{
	}

	private void OnDefuse(Player _)
	{
	}

	private void ActivateHand()
	{
	}
}
