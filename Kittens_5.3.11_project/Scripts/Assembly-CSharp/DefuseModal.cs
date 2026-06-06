using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DefuseModal : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CWaitThenCongratulationsDone_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DefuseModal _003C_003E4__this;

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
		public _003CWaitThenCongratulationsDone_003Ed__36(int _003C_003E1__state)
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

	public float CongratsDuration;

	public PlayerDelegate OnExplode;

	public PlayerDelegate OnDefuse;

	public SimpleCardFactory SimpleCardFactory;

	public WindowTransitioner DefusingWindow;

	public WindowTransitioner CongratsWindow;

	public ParticleSystem Smileys;

	public TimeoutAction DefuseTimeoutAction;

	public CardProvider CardProvider;

	public UISprite TimeoutProgress;

	public GameObject TapToSpeedUpTimerUiPopup;

	public int NumberOfTimesToShowSpeedUpPopup;

	public GameObject ChatButtonPanel;

	public GameObject CardLostPopup;

	public GameObject TitleText;

	private string NUM_TIMES_SEEN_SPEEDUP_POPUP_KEY;

	private Player player;

	private bool playerHasDefuseCard;

	public GameObject ExplodingKitten;

	public GameObject ExplodingKitten2;

	public GameObject ExplodingKitten2WithFuse;

	public GameObject Fuse;

	public GameObject Fuse2;

	public GameObject StoleBombTexture;

	public GameObject GaveAwayStreakingTexture;

	public GameObject PlayedStreakingTexture;

	public GameObject BombPlayedTexture;

	public GameObject DefuseBarkingTexture;

	private bool Exited;

	private PlayerHud PlayerHud;

	public UISprite ExplodingSprite;

	private Vector3 mouseDragStart;

	public void Initialize(Player player, Card card)
	{
	}

	private void Explode()
	{
	}

	private void DefuseBomb()
	{
	}

	private void ShowCongratulations()
	{
	}

	private void OnWin(Player player)
	{
	}

	[IteratorStateMachine(typeof(_003CWaitThenCongratulationsDone_003Ed__36))]
	private IEnumerator WaitThenCongratulationsDone()
	{
		return null;
	}

	private void OnPlayCard(Player player, Card card)
	{
	}

	private void OnDiscardCardBlind(Player player, Card card)
	{
	}

	private void OnExtraBombAdded(Player player, Card card)
	{
	}

	private void OnPlayerDefuse(Player player)
	{
	}

	private void SetupSecondBomb()
	{
	}

	private void Remove()
	{
	}

	private bool PlayerHasDefuseCard()
	{
		return false;
	}

	private bool TouchReleased()
	{
		return false;
	}

	private void Update()
	{
	}
}
