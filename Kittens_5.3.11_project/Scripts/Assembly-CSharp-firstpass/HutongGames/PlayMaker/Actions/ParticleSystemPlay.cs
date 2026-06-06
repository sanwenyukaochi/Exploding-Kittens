using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Plays a ParticleSystem. Optionally destroy the GameObject when the ParticleSystem is finished.")]
	[ActionCategory(ActionCategory.Effects)]
	public class ParticleSystemPlay : ComponentAction<ParticleSystem>
	{
		[RequiredField]
		[Tooltip("The GameObject with the ParticleSystem.")]
		[CheckForComponent(typeof(ParticleSystem))]
		public FsmOwnerDefault gameObject;

		[Tooltip("Play ParticleSystems on all child GameObjects too.")]
		public FsmBool withChildren;

		[Tooltip("''With Children'' can be quite expensive since it has to find Particle Systems in all children. If the hierarchy doesn't change, use Cache Children to speed this up.")]
		public FsmBool cacheChildren;

		[Tooltip("Stop playing when state exits")]
		public FsmBool stopOnExit;

		[Tooltip("Destroy the GameObject when the ParticleSystem has finished playing. 'With Children' means all child particle systems also need to finish.")]
		public FsmBool destroyOnFinish;

		private GameObject go;

		private ParticleSystem[] childParticleSystems;

		public override void Reset()
		{
		}

		public override void Awake()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnExit()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoParticleSystemPlay()
		{
		}
	}
}
