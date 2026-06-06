using UnityEngine;
using UnityEngine.AI;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Synchronize a NavMesh Agent velocity and rotation with the animator process.")]
	public class NavMeshAgentAnimatorSynchronizer : FsmStateAction
	{
		[CheckForComponent(typeof(NavMeshAgent))]
		[Tooltip("The Agent target. An Animator component and a NavMeshAgent component are required")]
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		public FsmOwnerDefault gameObject;

		private Animator _animator;

		private NavMeshAgent _agent;

		private Transform _trans;

		public override void Reset()
		{
		}

		public override void OnPreprocess()
		{
		}

		public override void OnEnter()
		{
		}

		public override void DoAnimatorMove()
		{
		}
	}
}
