using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	public abstract class TweenComponentBase<T> : TweenActionBase where T : Component
	{
		[Tooltip("The Game Object to tween.")]
		[RequiredField]
		[DisplayOrder(0)]
		[UIHint(UIHint.Variable)]
		public FsmOwnerDefault gameObject;

		protected GameObject cachedGameObject;

		protected T cachedComponent;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		protected bool UpdateCache(GameObject go)
		{
			return false;
		}

		protected override void DoTween()
		{
		}

		public override string ErrorCheck()
		{
			return null;
		}
	}
}
