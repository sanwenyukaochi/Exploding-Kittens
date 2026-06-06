using System;
using UnityEngine;

namespace HutongGames.PlayMaker
{
	[Serializable]
	public class FsmObject : NamedVariable
	{
		[SerializeField]
		private string typeName;

		[SerializeField]
		private UnityEngine.Object value;

		private Type objectType;

		public override Type ObjectType
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string TypeName => null;

		public UnityEngine.Object Value
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override object RawValue
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override VariableType VariableType => default(VariableType);

		public FsmObject()
		{
		}

		public FsmObject(string name)
		{
		}

		public FsmObject(FsmObject source)
		{
		}

		public override NamedVariable Clone()
		{
			return null;
		}

		public override void Clear()
		{
		}

		public override string ToString()
		{
			return null;
		}

		public static implicit operator FsmObject(UnityEngine.Object value)
		{
			return null;
		}

		public override bool TestTypeConstraint(VariableType variableType, Type _objectType = null)
		{
			return false;
		}
	}
}
