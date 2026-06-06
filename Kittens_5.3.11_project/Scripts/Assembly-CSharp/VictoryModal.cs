using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof(WindowTransitioner))]
public class VictoryModal : MonoBehaviour, IModal
{
	[CompilerGenerated]
	private sealed class _003CNewDifficultyUnlocked_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public VictoryModal _003C_003E4__this;

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
		public _003CNewDifficultyUnlocked_003Ed__25(int _003C_003E1__state)
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
	private sealed class _003CShowAchievementEmote_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public VictoryModal _003C_003E4__this;

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
		public _003CShowAchievementEmote_003Ed__26(int _003C_003E1__state)
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

	public WindowTransitioner WindowTransitioner;

	public Player Winner;

	public UILabel WinnerNameLabel;

	public AudioSource AudioSource;

	public AudioSource ExplodeSound;

	public VictoryStats VictoryStats;

	public AvatarGrid AvatarGrid;

	public GameObject BottomAnchor;

	public ExitGameAction ExitGameAction;

	public GameObject Buttons;

	public GameMessages GameMessages;

	public MyTurnTimeout MyTurnTimeout;

	[Header("Player List")]
	public PlayerProvider PlayerProvider;

	public TurnQueue TurnQueue;

	public UILabel m_WinsText;

	public UILabel m_LossesText;

	private Avatar recentlyDeceasedAvatar;

	public GameObject m_GroupObject;

	private bool m_EndEmote;

	private float m_DelayEmoteTimer;

	public event ModalDelegate OnDone
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

	public void Show()
	{
	}

	private void Update()
	{
	}

	[IteratorStateMachine(typeof(_003CNewDifficultyUnlocked_003Ed__25))]
	private IEnumerator NewDifficultyUnlocked()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CShowAchievementEmote_003Ed__26))]
	private IEnumerator ShowAchievementEmote()
	{
		return null;
	}

	private void CreateAvatars()
	{
	}
}
