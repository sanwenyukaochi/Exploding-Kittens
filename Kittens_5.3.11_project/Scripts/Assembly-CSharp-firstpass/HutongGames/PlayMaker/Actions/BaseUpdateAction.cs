namespace HutongGames.PlayMaker.Actions
{
	public abstract class BaseUpdateAction : FsmStateAction
	{
		public enum UpdateType
		{
			OnUpdate = 0,
			OnLateUpdate = 1,
			OnFixedUpdate = 2
		}

		[ActionSection("Update type")]
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		[Tooltip("When to update the action.\nOnUpdate: The most common setting.\nOnLateUpdate: Update after everything else. Useful if dependent on another GameObect, e.g. following.\nOnFixedUpdate: Used to update physics e.g., GameObjects with RigidBody components.")]
		public UpdateType updateType;

		public abstract void OnActionUpdate();

		public override void Reset()
		{
		}

		public override void OnPreprocess()
		{
		}

		public override void OnUpdate()
		{
		}

		public override void OnLateUpdate()
		{
		}

		public override void OnFixedUpdate()
		{
		}
	}
}
