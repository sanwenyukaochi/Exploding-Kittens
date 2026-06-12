namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets NGUI object to be draggable or not. This will automatically set up a drag object for you.")]
	[ActionCategory("Ngui Actions")]
	public class nguiSetDragObject : FsmStateAction
	{
		[UIHint(UIHint.Description)]
		public string des;

		[Tooltip("NGUI object to be draggable or not")]
		[RequiredField]
		public FsmOwnerDefault NguiObject;

		[RequiredField]
		[Tooltip("draggable nGui GameObject. If False the game object will not be draggable")]
		public FsmBool setDrag;

		public UIDragDropItem.Restriction restriction;

		public FsmBool cloneOnDrag;

		[Tooltip("When true, runs on every frame")]
		public bool everyFrame;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoSetDrag()
		{
		}
	}
}
