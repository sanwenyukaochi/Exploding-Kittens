namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Material)]
	[Tooltip("Sets the value of a Material Variable.")]
	public class SetMaterialValue : FsmStateAction
	{
		[UIHint(UIHint.Variable)]
		[Tooltip("The Material Variable.")]
		[RequiredField]
		public FsmMaterial materialVariable;

		[RequiredField]
		[Tooltip("Material Value.")]
		public FsmMaterial materialValue;

		[Tooltip("Repeat every frame.")]
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
	}
}
