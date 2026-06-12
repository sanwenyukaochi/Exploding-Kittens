namespace HutongGames.PlayMaker.Actions
{
	[NoActionTargets]
	[ActionCategory(ActionCategory.Array)]
	[Tooltip("Transfer a value from one array to another, basically a copy/cut paste action on steroids.")]
	public class ArrayTransferValue : FsmStateAction
	{
		public enum ArrayTransferType
		{
			Copy = 0,
			Cut = 1,
			nullify = 2
		}

		public enum ArrayPasteType
		{
			AsFirstItem = 0,
			AsLastItem = 1,
			InsertAtSameIndex = 2,
			ReplaceAtSameIndex = 3
		}

		[Tooltip("The Array Variable source.")]
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmArray arraySource;

		[Tooltip("The Array Variable target.")]
		[UIHint(UIHint.Variable)]
		[RequiredField]
		public FsmArray arrayTarget;

		[MatchFieldType("array")]
		[Tooltip("The index to transfer.")]
		public FsmInt indexToTransfer;

		[ActionSection("Transfer Options")]
		[Tooltip("Copy Options.")]
		[ObjectType(typeof(ArrayTransferType))]
		public FsmEnum copyType;

		[ObjectType(typeof(ArrayPasteType))]
		[Tooltip("Paste Options")]
		public FsmEnum pasteType;

		[Tooltip("Event sent if the array source does not contains that element.")]
		[ActionSection("Result")]
		public FsmEvent indexOutOfRange;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoTransferValue()
		{
		}
	}
}
