namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("iTween base action - don't use!")]
	public abstract class iTweenFsmAction : FsmStateAction
	{
		public enum AxisRestriction
		{
			none = 0,
			x = 1,
			y = 2,
			z = 3,
			xy = 4,
			xz = 5,
			yz = 6
		}

		[ActionSection("Events")]
		public FsmEvent startEvent;

		public FsmEvent finishEvent;

		[Tooltip("Setting this to true will allow the animation to continue independent of the current time which is helpful for animating menus after a game has been paused by setting Time.timeScale=0.")]
		public FsmBool realTime;

		public FsmBool stopOnExit;

		public FsmBool loopDontFinish;

		internal iTweenFSMEvents itweenEvents;

		protected string itweenType;

		protected int itweenID;

		public override void Reset()
		{
		}

		protected void OnEnteriTween(FsmOwnerDefault anOwner)
		{
		}

		protected void IsLoop(bool aValue)
		{
		}

		protected void OnExitiTween(FsmOwnerDefault anOwner)
		{
		}
	}
}
