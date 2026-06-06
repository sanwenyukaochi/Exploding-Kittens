using System;
using UnityEngine;

namespace HutongGames.PlayMaker
{
	[Serializable]
	public class FsmEnum : NamedVariable
	{
		[SerializeField]
		private string enumName;

		[SerializeField]
		private int intValue;

		private Enum value;

		private int parsedIntValue;

		private Type enumType;

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

		public string EnumName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Enum Value
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

		public override void Init()
		{
		}

		private void InitEnumType()
		{
		}

		public void ResetValue()
		{
		}

		public FsmEnum()
		{
		}

		public FsmEnum(string name, Type enumType, int intValue)
		{
		}

		public FsmEnum(string name)
		{
		}

		public FsmEnum(FsmEnum source)
		{
		}

		public override NamedVariable Clone()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public override int ToInt()
		{
			return 0;
		}

		public override void Clear()
		{
		}

		public override bool TestTypeConstraint(VariableType variableType, Type _enumType = null)
		{
			return false;
		}

		public static implicit operator FsmEnum(Enum value)
		{
			return null;
		}
	}
}
