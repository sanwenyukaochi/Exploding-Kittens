using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class HandCard : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CWaitAndExecute_003Ed__72 : IEnumerator<object>, IEnumerator, IDisposable
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
		public _003CWaitAndExecute_003Ed__72(int _003C_003E1__state)
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

	public UIWidget CardWidget;

	public UIWidget[] WidgetsOnTopOfCard;

	public UITexture CardTexture;

	public UITexture BombTexture;

	public UISprite MarkedCardTexture;

	public ActionBase MoveCardAction;

	public MovementAction MoveCardMovementAction;

	public MovementAction MoveTextureAction;

	public UITexture GlowTexture;

	public ParticleSystem DragParticleSystem;

	public ParticleSystem DrawParticleSystem;

	public float GlowAlpha;

	public float MoveDelay;

	private Player player;

	private CardCommandAction nextAction;

	private CardCommand command;

	public PlayMakerFSM DiarrheaFsm;

	public PlayMakerFSM ShowCardFsm;

	public TooltipCaptionDefinition DiarrheaTooltipCaption;

	public TooltipCaptionDefinition CatButtTooltipCaption;

	public PlayMakerFSM RevealAnimationFsm;

	public PlayMakerFSM DisguisingFsm;

	public TooltipCaptionFactory TooltipCaptionFactory;

	public GameObject ToolTipOffset;

	private Action onDoneRevealing;

	private TooltipCaption tooltipCaption;

	public Card card;

	public ShakeAction ShakeAction;

	private PlayerHand PlayerHand;

	private BoxCollider boxCollider;

	public SpringPosition SpringPosition;

	public GameObject TextureContainer;

	public UILabel TextLabel;

	public Vector3 OPosition;

	public bool FirstInit;

	private bool Dragging;

	private bool ShownFlag;

	private Vector3 MouseDragPos;

	private bool MouseDragging;

	private float DragTimer;

	public Card Card => null;

	private string RevealEventName => null;

	private Color ParticleColor => default(Color);

	public void Initialize(Card card, CardCommand command, CardCommandAction nextAction, PlayerHand PlayerHand)
	{
	}

	public void OnDestroy()
	{
	}

	public void OnMarked(Card _)
	{
	}

	private void MarkScaleUpComplete()
	{
	}

	private void MarkScaleDownComplete()
	{
	}

	public void OnUnMarked(Card _)
	{
	}

	public bool IsToolTipOn()
	{
		return false;
	}

	public void ToggleTooltip(bool centercard = true)
	{
	}

	public void DeSelectCard()
	{
	}

	public void SelectCard()
	{
	}

	private void OnClick()
	{
	}

	private void OnDrag()
	{
	}

	private void OnTooltipDisabled(GameObject tooltip)
	{
	}

	private void OnTooltipEnabled(GameObject tooltip)
	{
	}

	public void OnDragDropStart()
	{
	}

	public void OnDragDropEnd()
	{
	}

	public void RevealToPlayer(Action onComplete)
	{
	}

	public void DoneRevealing()
	{
	}

	public void DiarrheaSpray(Card card)
	{
	}

	public void DiarrheaCleanup(Card card)
	{
	}

	private void UpdateTooltip()
	{
	}

	private void Disguise(Card card)
	{
	}

	private void ShedDisguise(Card card)
	{
	}

	public void SetDepth(int depth)
	{
	}

	public void MoveTo(Vector3 localPosition, float duration = 0.25f)
	{
	}

	public void MoveTo(Vector3 localPosition, float duration, Action onCompleteCallback)
	{
	}

	public void MoveToWorld(Vector3 worldPosition)
	{
	}

	public void MoveToWorld(Vector3 worldPosition, Action onCompleteCallback)
	{
	}

	public void MoveTextureTo(Vector3 localPosition)
	{
	}

	public void Play(Action onFailure)
	{
	}

	public void Remove()
	{
	}

	public void UpdateRestingGridPosition(Vector3 pos)
	{
	}

	[IteratorStateMachine(typeof(_003CWaitAndExecute_003Ed__72))]
	private IEnumerator WaitAndExecute(float delay, Action callback)
	{
		return null;
	}

	public void ResetCard()
	{
	}

	private bool CheckCardInHand()
	{
		return false;
	}

	private void LateUpdate()
	{
	}

	public void StopDraggingCard()
	{
	}

	private void OnApplicationPause(bool paused)
	{
	}
}
