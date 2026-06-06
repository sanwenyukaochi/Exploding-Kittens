using System;
using System.Reflection;
using UnityEngine;

namespace HutongGames.PlayMaker
{
	[Serializable]
	public class FsmProperty
	{
		public FsmObject TargetObject;

		public string TargetTypeName;

		public Type TargetType;

		public string PropertyName;

		public Type PropertyType;

		public FsmBool BoolParameter;

		public FsmFloat FloatParameter;

		public FsmInt IntParameter;

		public FsmGameObject GameObjectParameter;

		public FsmString StringParameter;

		public FsmVector2 Vector2Parameter;

		public FsmVector3 Vector3Parameter;

		public FsmRect RectParamater;

		public FsmQuaternion QuaternionParameter;

		public FsmObject ObjectParameter;

		public FsmMaterial MaterialParameter;

		public FsmTexture TextureParameter;

		public FsmColor ColorParameter;

		public FsmEnum EnumParameter;

		public FsmArray ArrayParameter;

		public bool setProperty;

		private bool initialized;

		[NonSerialized]
		private UnityEngine.Object targetObjectCached;

		private MemberInfo[] memberInfo;

		public FsmProperty()
		{
		}

		public FsmProperty(FsmProperty source)
		{
		}

		public void SetVariable(NamedVariable variable)
		{
		}

		public NamedVariable GetVariable()
		{
			return null;
		}

		public void SetPropertyName(string propertyName)
		{
		}

		public void SetValue()
		{
		}

		public void GetValue()
		{
		}

		public void Init()
		{
		}

		public void CheckForReinitialize()
		{
		}

		public void ResetParameters()
		{
		}
	}
}
