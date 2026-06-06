using System;
using System.Collections.Generic;
using UnityEngine;

namespace HutongGames.PlayMaker
{
	[Serializable]
	public class FsmVariables
	{
		private Dictionary<string, NamedVariable> _variableLookup;

		[NonSerialized]
		private NamedVariable[] _allVariables;

		[NonSerialized]
		private List<NamedVariable> _emptyVariables;

		[SerializeField]
		private FsmFloat[] floatVariables;

		[SerializeField]
		private FsmInt[] intVariables;

		[SerializeField]
		private FsmBool[] boolVariables;

		[SerializeField]
		private FsmString[] stringVariables;

		[SerializeField]
		private FsmVector2[] vector2Variables;

		[SerializeField]
		private FsmVector3[] vector3Variables;

		[SerializeField]
		private FsmColor[] colorVariables;

		[SerializeField]
		private FsmRect[] rectVariables;

		[SerializeField]
		private FsmQuaternion[] quaternionVariables;

		[SerializeField]
		private FsmGameObject[] gameObjectVariables;

		[SerializeField]
		private FsmObject[] objectVariables;

		[SerializeField]
		private FsmMaterial[] materialVariables;

		[SerializeField]
		private FsmTexture[] textureVariables;

		[SerializeField]
		private FsmArray[] arrayVariables;

		[SerializeField]
		private FsmEnum[] enumVariables;

		[SerializeField]
		private string[] categories;

		[SerializeField]
		private int[] variableCategoryIDs;

		public static PlayMakerGlobals GlobalsComponent => null;

		public static FsmVariables GlobalVariables => null;

		public static bool GlobalVariablesSynced { get; set; }

		private Dictionary<string, NamedVariable> variableLookup => null;

		private NamedVariable[] allVariables => null;

		private List<NamedVariable> emptyVariables => null;

		public string[] Categories
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int[] CategoryIDs
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int Count => 0;

		public FsmFloat[] FloatVariables
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public FsmInt[] IntVariables
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public FsmBool[] BoolVariables
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public FsmString[] StringVariables
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public FsmVector2[] Vector2Variables
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public FsmVector3[] Vector3Variables
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public FsmRect[] RectVariables
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public FsmQuaternion[] QuaternionVariables
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public FsmColor[] ColorVariables
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public FsmGameObject[] GameObjectVariables
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public FsmArray[] ArrayVariables
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public FsmEnum[] EnumVariables
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public FsmObject[] ObjectVariables
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public FsmMaterial[] MaterialVariables
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public FsmTexture[] TextureVariables
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public FsmVariables()
		{
		}

		public FsmVariables(FsmVariables source)
		{
		}

		public void Init()
		{
		}

		private void AddVariableLookup(NamedVariable v)
		{
		}

		public void Reinitialize()
		{
		}

		public NamedVariable[] GetAllNamedVariables()
		{
			return null;
		}

		public NamedVariable[] GetAllNamedVariablesSorted()
		{
			return null;
		}

		public NamedVariable[] GetNamedVariables(VariableType type)
		{
			return null;
		}

		public NamedVariable[] GetNamedVariablesSorted(VariableType type)
		{
			return null;
		}

		public List<NamedVariable> GetEmptyVariables()
		{
			return null;
		}

		public bool Contains(string variableName)
		{
			return false;
		}

		public bool Contains(NamedVariable variable)
		{
			return false;
		}

		public NamedVariable[] GetNames(Type ofType)
		{
			return null;
		}

		public int GetVariableIndex(string variableName)
		{
			return 0;
		}

		public static bool AreCompatible(FsmVariables vars1, FsmVariables vars2)
		{
			return false;
		}

		public void OverrideVariableValues(FsmVariables source)
		{
		}

		public void ApplyVariableValues(FsmVariables source)
		{
		}

		public void ApplyVariableValuesCareful(FsmVariables source)
		{
		}

		public NamedVariable GetVariable(string name)
		{
			return null;
		}

		public NamedVariable GetVariable(VariableType variableType, string name)
		{
			return null;
		}

		public FsmFloat GetFsmFloat(string name)
		{
			return null;
		}

		public FsmObject GetFsmObject(string name)
		{
			return null;
		}

		public FsmMaterial GetFsmMaterial(string name)
		{
			return null;
		}

		public FsmTexture GetFsmTexture(string name)
		{
			return null;
		}

		public FsmInt GetFsmInt(string name)
		{
			return null;
		}

		public FsmBool GetFsmBool(string name)
		{
			return null;
		}

		public FsmString GetFsmString(string name)
		{
			return null;
		}

		public FsmVector2 GetFsmVector2(string name)
		{
			return null;
		}

		public FsmVector3 GetFsmVector3(string name)
		{
			return null;
		}

		public FsmRect GetFsmRect(string name)
		{
			return null;
		}

		public FsmQuaternion GetFsmQuaternion(string name)
		{
			return null;
		}

		public FsmColor GetFsmColor(string name)
		{
			return null;
		}

		public FsmGameObject GetFsmGameObject(string name)
		{
			return null;
		}

		public FsmArray GetFsmArray(string name)
		{
			return null;
		}

		public FsmEnum GetFsmEnum(string name)
		{
			return null;
		}

		public NamedVariable FindVariable(string name)
		{
			return null;
		}

		public NamedVariable LoadGlobalVariable(string name)
		{
			return null;
		}

		public NamedVariable FindVariable(VariableType type, string name)
		{
			return null;
		}

		public FsmFloat FindFsmFloat(string name)
		{
			return null;
		}

		public FsmObject FindFsmObject(string name)
		{
			return null;
		}

		public FsmMaterial FindFsmMaterial(string name)
		{
			return null;
		}

		public FsmTexture FindFsmTexture(string name)
		{
			return null;
		}

		public FsmInt FindFsmInt(string name)
		{
			return null;
		}

		public FsmBool FindFsmBool(string name)
		{
			return null;
		}

		public FsmString FindFsmString(string name)
		{
			return null;
		}

		public FsmVector2 FindFsmVector2(string name)
		{
			return null;
		}

		public FsmVector3 FindFsmVector3(string name)
		{
			return null;
		}

		public FsmRect FindFsmRect(string name)
		{
			return null;
		}

		public FsmQuaternion FindFsmQuaternion(string name)
		{
			return null;
		}

		public FsmColor FindFsmColor(string name)
		{
			return null;
		}

		public FsmGameObject FindFsmGameObject(string name)
		{
			return null;
		}

		public FsmEnum FindFsmEnum(string name)
		{
			return null;
		}

		public FsmArray FindFsmArray(string name)
		{
			return null;
		}
	}
}
