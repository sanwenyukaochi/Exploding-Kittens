namespace HutongGames.PlayMaker.Actions
{
	[HelpUrl("http://hutonggames.com/playmakerforum/index.php?topic=4758.0")]
	[Tooltip("Move a GameObject to another GameObject using easing functions. Works like iTween Move To, but with better performance.")]
	[ActionCategory(ActionCategory.Transform)]
	public class MoveObject : EaseFsmAction
	{
		[RequiredField]
		[Tooltip("The GameObject to move.")]
		public FsmOwnerDefault objectToMove;

		[RequiredField]
		[Tooltip("The target GamObject.")]
		public FsmGameObject destination;

		private FsmVector3 fromValue;

		private FsmVector3 toVector;

		private FsmVector3 fromVector;

		private bool finishInNextStep;

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
