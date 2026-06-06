using System;
using UnityEngine;

namespace HutongGames.PlayMaker
{
	[Serializable]
	public class FsmArray : NamedVariable
	{
		[SerializeField]
		private VariableType type;

		[SerializeField]
		private string objectTypeName;

		private Type objectType;

		public float[] floatValues;

		public int[] intValues;

		public bool[] boolValues;

		public string[] stringValues;

		public Vector4[] vector4Values;

		public UnityEngine.Object[] objectReferences;

		[NonSerialized]
		private Array sourceArray;

		[NonSerialized]
		private object[] values;

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

		public string ObjectTypeName => null;

		public object[] Values
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int Length => 0;

		public override VariableType TypeConstraint => default(VariableType);

		public VariableType ElementType
		{
			get
			{
				return default(VariableType);
			}
			set
			{
			}
		}

		public override VariableType VariableType => default(VariableType);

		private void InitObjectType()
		{
		}

		private void InitArray()
		{
		}

		public override void Init()
		{
		}

		public object Get(int index)
		{
			return null;
		}

		public void Set(int index, object value)
		{
		}

		private object Load(int index)
		{
			return null;
		}

		private void Save(int index, object value)
		{
		}

		public void SetType(VariableType newType)
		{
		}

		public void SaveChanges()
		{
		}

		public void CopyValues(FsmArray source)
		{
		}

		private void ConformSourceArraySize()
		{
		}

		private Array GetSourceArray()
		{
			return null;
		}

		public void Resize(int newLength)
		{
		}

		public void InsertItem(object value, int atIndex)
		{
		}

		public void Reset()
		{
		}

		public FsmArray()
		{
		}

		public FsmArray(string name)
		{
		}

		public FsmArray(FsmArray source)
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

		public override bool TestTypeConstraint(VariableType variableType, Type _objectType = null)
		{
			return false;
		}

		public Type RealType()
		{
			return null;
		}
	}
}
