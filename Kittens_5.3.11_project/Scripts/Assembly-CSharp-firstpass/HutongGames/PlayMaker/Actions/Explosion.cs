using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Applies an explosion Force to all Game Objects with a Rigid Body inside a Radius.")]
	[ActionCategory(ActionCategory.Physics)]
	public class Explosion : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The world position of the center of the explosion.")]
		public FsmVector3 center;

		[Tooltip("The strength of the explosion.")]
		[RequiredField]
		public FsmFloat force;

		[RequiredField]
		[Tooltip("The radius of the explosion. Force falls of linearly with distance.")]
		public FsmFloat radius;

		[Tooltip("Applies the force as if it was applied from beneath the object. This is useful because explosions that throw things up instead of pushing things to the side look cooler. A value of 2 will apply a force as if it is applied from 2 meters below while not changing the actual explosion position.")]
		public FsmFloat upwardsModifier;

		[Tooltip("The type of force to apply.")]
		public ForceMode forceMode;

		[NonSerialized]
		[UIHint(UIHint.Layer)]
		public FsmInt layer;

		[UIHint(UIHint.Layer)]
		[Tooltip("Layers to effect.")]
		public FsmInt[] layerMask;

		[Tooltip("Invert the mask, so you effect all layers except those defined above.")]
		public FsmBool invertMask;

		[Tooltip("Repeat every frame while the state is active.")]
		public bool everyFrame;

		public override void Reset()
		{
		}

		public override void OnPreprocess()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnFixedUpdate()
		{
		}

		private void DoExplosion()
		{
		}

		private bool ShouldApplyForce(GameObject go)
		{
			return false;
		}
	}
}
