using HutongGames.PlayMaker;

[Tooltip("Sets NGUI object to be activated or deactivated")]
[ActionCategory("Ngui Actions")]
public class nguiActivateMultiObjects : FsmStateAction
{
	[CompoundArray("How many", "Object", "setActive")]
	[RequiredField]
	public FsmGameObject[] nguiObject;

	[Tooltip("Activate nGui GameObject. If False the game object will be Deactivated")]
	public FsmBool[] setActive;

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

	private void DoSetActive()
	{
	}
}
