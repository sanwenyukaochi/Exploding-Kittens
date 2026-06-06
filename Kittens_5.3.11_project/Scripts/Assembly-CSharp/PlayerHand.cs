using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerHand : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CMoveHandCardStreaking_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HandCard handCard;

		public PlayerHand _003C_003E4__this;

		public Vector3 tpos;

		private Transform _003Cpsave_003E5__2;

		private float _003Ctimer_003E5__3;

		private bool _003Cleft_003E5__4;

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
		public _003CMoveHandCardStreaking_003Ed__39(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CMoveHandCardToCenterCR_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HandCard handCard;

		public PlayerHand _003C_003E4__this;

		private float _003CmovementOnXAxis_003E5__2;

		private float _003Ctimer_003E5__3;

		private SpringPanel _003Csp_003E5__4;

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
		public _003CMoveHandCardToCenterCR_003Ed__41(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CWaitAndExecute_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public Action callback;

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
		public _003CWaitAndExecute_003Ed__42(int _003C_003E1__state)
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

	public GameMessages GameMessages;

	public GameObject Prefab;

	public Vector3 StartLocation;

	public Vector3 Spacing;

	public DiscardPile DiscardPile;

	public UIScrollView UIScrollView;

	public CardSpawnLocationProvider SpawnLocationProvider;

	public float ScrollingSpeed;

	public float StaggerOffsetForCards;

	public GameObject HandCardContainer;

	public UIGrid HandCardGrid;

	public PlayMakerFSM MovementFsm;

	public UIPanel Panel;

	public PlayerProvider PlayerProvider;

	public float CenterCardMovementTime;

	public GameObject DropHandTarget;

	private Dictionary<Card, HandCard> handCardLookup;

	private List<Card> cards;

	private Vector3 OutOfView;

	private int siblingindex;

	private int leftsiblingindex;

	private int rightsiblingindex;

	private GameObject nearestcard;

	public List<HandCard> HandCards => null;

	public int Depth
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private Player player => null;

	public void Start()
	{
	}

	public void DiscardCardWithTooltip(Player player, Card card)
	{
	}

	public void DiscardCardBlind(Player player, Card card)
	{
	}

	public void OnDeath(Player _)
	{
	}

	public void MoveOutOfView()
	{
	}

	public void MoveIntoView()
	{
	}

	public void OnReceiveCardFromPlayer(Player player, Player __, Card card)
	{
	}

	public void OnDrawCard(Player _, Card card)
	{
	}

	public void OnRemoveCard(Player player, Card card)
	{
	}

	public void StreakingCardEffect(HandCard handCard, Vector3 tpos)
	{
	}

	private GameObject FindNearestCard(HandCard card, Vector3 pos)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CMoveHandCardStreaking_003Ed__39))]
	private IEnumerator MoveHandCardStreaking(HandCard handCard, Vector3 tpos)
	{
		return null;
	}

	public void MoveHandCardToCenter(HandCard handCard)
	{
	}

	[IteratorStateMachine(typeof(_003CMoveHandCardToCenterCR_003Ed__41))]
	private IEnumerator MoveHandCardToCenterCR(HandCard handCard)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CWaitAndExecute_003Ed__42))]
	private IEnumerator WaitAndExecute(float delay, Action callback)
	{
		return null;
	}

	private void CreateHandCard(Card card)
	{
	}

	private void RemoveHandCard(Card card, HandCard handCard)
	{
	}

	public void StopDraggingCard()
	{
	}
}
