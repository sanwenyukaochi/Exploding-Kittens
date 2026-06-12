using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("Particles")]
	[Tooltip("Play particles in a particle system")]
	public class PlayParticlesStateAction : FsmStateAction
	{
		[Tooltip("ParticleSystem to start playing")]
		[RequiredField]
		public FsmOwnerDefault ParticleSystemGameObject;

		private ParticleSystem particleSystem;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}
	}
}
