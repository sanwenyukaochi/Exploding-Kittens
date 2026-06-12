using System;
using UnityEngine;

namespace HutongGames.PlayMaker
{
	[Serializable]
	public class FsmVar
	{
		public string variableName;

		public string objectType;

		public bool useVariable;

		[NonSerialized]
		private NamedVariable namedVar;

		[NonSerialized]
		private Type namedVarType;

		private Type enumType;

		private Enum enumValue;

		[NonSerialized]
		private Type _objectType;

		[SerializeField]
		private VariableType type;

		public float floatValue;

		public int intValue;

		public bool boolValue;

		public string stringValue;

		public Vector4 vector4Value;

		public UnityEngine.Object objectReference;

		public FsmArray arrayValue;

		private Vector2 vector2;

		private Vector3 vector3;

		private Rect rect;

		public NamedVariable NamedVar
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Type NamedVarType => null;

		public Type EnumType
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Enum EnumValue
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Type ObjectType
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public VariableType Type
		{
			get
			{
				return default(VariableType);
			}
			set
			{
			}
		}

		public Type RealType => null;

		public bool IsNone => false;

		public Vector2 vector2Value
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public Vector3 vector3Value
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Color colorValue
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Rect rectValue
		{
			get
			{
				return default(Rect);
			}
			set
			{
			}
		}

		public Quaternion quaternionValue
		{
			get
			{
				return default(Quaternion);
			}
			set
			{
			}
		}

		public GameObject gameObjectValue
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Material materialValue
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Texture textureValue
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public FsmVar()
		{
		}

		public FsmVar(Type type)
		{
		}

		public FsmVar(FsmVar source)
		{
		}

		public FsmVar(INamedVariable variable)
		{
		}

		public void Init(NamedVariable variable)
		{
		}

		private void UpdateType(INamedVariable sourceVar)
		{
		}

		private void InitNamedVar()
		{
		}

		private void InitEnumType()
		{
		}

		public object GetValue()
		{
			return null;
		}

		public void GetValueFrom(INamedVariable variable)
		{
		}

		public void UpdateValue()
		{
		}

		public void ApplyValueTo(INamedVariable targetVariable)
		{
		}

		public string DebugString()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public void SetValue(object value)
		{
		}

		private void DebugLog()
		{
		}

		public static VariableType GetVariableType(Type type)
		{
			return default(VariableType);
		}
	}
}
