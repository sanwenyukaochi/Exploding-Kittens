using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets the value of any public property or field on the targeted Unity Object. E.g., Drag and drop any component attached to a Game Object to access its properties.")]
	[ActionTarget(typeof(GameObject), "targetProperty", false)]
	[ActionTarget(typeof(Component), "targetProperty", false)]
	[ActionCategory(ActionCategory.UnityObject)]
	public class SetProperty : FsmStateAction
	{
		[Tooltip("Target Property. See below for more details.")]
		public FsmProperty targetProperty;

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
