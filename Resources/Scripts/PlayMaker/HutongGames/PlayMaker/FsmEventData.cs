using UnityEngine;

namespace HutongGames.PlayMaker
{
	public class FsmEventData
	{
		public GameObject SentByGameObject;

		public Fsm SentByFsm;

		public FsmState SentByState;

		public FsmStateAction SentByAction;

		public bool BoolData;

		public int IntData;

		public float FloatData;

		public Vector2 Vector2Data;

		public Vector3 Vector3Data;

		public string StringData;

		public Quaternion QuaternionData;

		public Rect RectData;

		public Color ColorData;

		public Object ObjectData;

		public GameObject GameObjectData;

		public Material MaterialData;

		public Texture TextureData;

		public FsmEventData()
		{
		}

		public FsmEventData(FsmEventData source)
		{
		}

		public void DebugLog()
		{
		}
	}
}
