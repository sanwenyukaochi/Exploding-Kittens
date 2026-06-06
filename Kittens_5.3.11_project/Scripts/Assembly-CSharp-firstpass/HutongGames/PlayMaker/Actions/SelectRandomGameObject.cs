namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Selects a Random Game Object from an array of Game Objects.")]
	[ActionCategory(ActionCategory.GameObject)]
	public class SelectRandomGameObject : FsmStateAction
	{
		[Tooltip("A possible GameObject choice.")]
		[CompoundArray("Game Objects", "Game Object", "Weight")]
		public FsmGameObject[] gameObjects;

		[Tooltip("The relative probability of this GameObject being picked. E.g. a weight of 0.5 is half as likely to be picked as a weight of 1.")]
		[HasFloatSlider(0f, 1f)]
		public FsmFloat[] weights;

		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the selected GameObject in a GameObject Variable.")]
		public FsmGameObject storeGameObject;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoSelectRandomGameObject()
		{
		}
	}
}
