namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.StateMachine)]
	[SeeAlso("{{SetEventData}}")]
	[Tooltip("Gets info on the last event that caused a state change. See also: {{Set Event Data}} action.")]
	public class GetEventInfo : FsmStateAction
	{
		[UIHint(UIHint.Variable)]
		[Tooltip("The Game Object that sent the Event.")]
		public FsmGameObject sentByGameObject;

		[UIHint(UIHint.Variable)]
		[Tooltip("The name of the FSM that sent the Event.")]
		public FsmString fsmName;

		[UIHint(UIHint.Variable)]
		[Tooltip("Custom Bool data.")]
		public FsmBool getBoolData;

		[UIHint(UIHint.Variable)]
		[Tooltip("Custom Int data.")]
		public FsmInt getIntData;

		[UIHint(UIHint.Variable)]
		[Tooltip("Custom Float data.")]
		public FsmFloat getFloatData;

		[UIHint(UIHint.Variable)]
		[Tooltip("Custom Vector2 data.")]
		public FsmVector2 getVector2Data;

		[UIHint(UIHint.Variable)]
		[Tooltip("Custom Vector3 data.")]
		public FsmVector3 getVector3Data;

		[UIHint(UIHint.Variable)]
		[Tooltip("Custom String data.")]
		public FsmString getStringData;

		[UIHint(UIHint.Variable)]
		[Tooltip("Custom GameObject data.")]
		public FsmGameObject getGameObjectData;

		[Tooltip("Custom Rect data.")]
		[UIHint(UIHint.Variable)]
		public FsmRect getRectData;

		[UIHint(UIHint.Variable)]
		[Tooltip("Custom Quaternion data.")]
		public FsmQuaternion getQuaternionData;

		[UIHint(UIHint.Variable)]
		[Tooltip("Custom Material data.")]
		public FsmMaterial getMaterialData;

		[UIHint(UIHint.Variable)]
		[Tooltip("Custom Texture data.")]
		public FsmTexture getTextureData;

		[UIHint(UIHint.Variable)]
		[Tooltip("Custom Color data.")]
		public FsmColor getColorData;

		[UIHint(UIHint.Variable)]
		[Tooltip("Custom Object data.")]
		public FsmObject getObjectData;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
