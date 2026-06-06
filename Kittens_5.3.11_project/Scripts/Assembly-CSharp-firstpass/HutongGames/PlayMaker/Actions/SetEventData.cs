namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets Event Data before sending an event. Get the Event Data, along with sender information, using the {{Get Event Info}} action.")]
	[ActionCategory(ActionCategory.StateMachine)]
	public class SetEventData : FsmStateAction
	{
		[Tooltip("Custom Game Object data.")]
		public FsmGameObject setGameObjectData;

		[Tooltip("Custom Int data.")]
		public FsmInt setIntData;

		[Tooltip("Custom Float data.")]
		public FsmFloat setFloatData;

		[Tooltip("Custom String data.")]
		public FsmString setStringData;

		[Tooltip("Custom Bool data.")]
		public FsmBool setBoolData;

		[Tooltip("Custom Vector2 data.")]
		public FsmVector2 setVector2Data;

		[Tooltip("Custom Vector3 data.")]
		public FsmVector3 setVector3Data;

		[Tooltip("Custom Rect data.")]
		public FsmRect setRectData;

		[Tooltip("Custom Quaternion data.")]
		public FsmQuaternion setQuaternionData;

		[Tooltip("Custom Color data.")]
		public FsmColor setColorData;

		[Tooltip("Custom Material data.")]
		public FsmMaterial setMaterialData;

		[Tooltip("Custom Texture data.")]
		public FsmTexture setTextureData;

		[Tooltip("Custom Object data.")]
		public FsmObject setObjectData;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
