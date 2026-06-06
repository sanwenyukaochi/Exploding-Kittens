using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Gets a Game Object's Transform and stores it in an Object Variable.")]
	[ActionCategory(ActionCategory.GameObject)]
	public class GetTransform : FsmStateAction
	{
		[Tooltip("The Game Object.")]
		[RequiredField]
		public FsmGameObject gameObject;

		[Tooltip("Store the GameObject's Transform in an Object variable of type UnityEngine.Transform.")]
		[ObjectType(typeof(Transform))]
		[UIHint(UIHint.Variable)]
		[RequiredField]
		public FsmObject storeTransform;

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

		private void DoGetGameObjectName()
		{
		}
	}
}
