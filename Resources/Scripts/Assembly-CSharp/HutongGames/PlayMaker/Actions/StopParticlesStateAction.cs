using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Stop particles in a particle system")]
	[ActionCategory("Particles")]
	public class StopParticlesStateAction : FsmStateAction
	{
		[Tooltip("ParticleSystem to stop playing")]
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
