namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Activates a GameObject and de-activates other GameObjects at the same level of the hierarchy. E.g, a single UI Screen, a single accessory etc. This action is very helpful if you often organize GameObject hierarchies in this way. \nNOTE: The targeted GameObject should have a parent. This action will not work on GameObjects at the scene root.")]
	[ActionCategory(ActionCategory.GameObject)]
	public class ActivateSolo : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The GameObject to activate.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("Re-activate if already active. This means deactivating the target GameObject then activating it again. This will reset FSMs on that GameObject.")]
		public FsmBool allowReactivate;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoActivateSolo()
		{
		}
	}
}
