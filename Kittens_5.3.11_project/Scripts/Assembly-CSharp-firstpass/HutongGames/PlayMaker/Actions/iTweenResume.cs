namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("iTween")]
	[Tooltip("Resume an iTween action.")]
	public class iTweenResume : FsmStateAction
	{
		[RequiredField]
		public FsmOwnerDefault gameObject;

		public iTweenFSMType iTweenType;

		public bool includeChildren;

		public bool inScene;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoiTween()
		{
		}
	}
}
