using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using UnityEngine;

namespace HutongGames.PlayMaker
{
	[Serializable]
	public class ActionData
	{
		public class Context
		{
			public Fsm currentFsm;

			public FsmState currentState;

			public FsmStateAction currentAction;

			public int currentActionIndex;

			public string currentParameter;

			public override string ToString()
			{
				return null;
			}
		}

		private const string autoNameString = "~AutoName";

		private static readonly Dictionary<string, Type> ActionTypeLookup;

		public static readonly Dictionary<Type, FieldInfo[]> ActionFieldsLookup;

		public static readonly Dictionary<Type, int> ActionHashCodeLookup;

		private static bool resaveActionData;

		private static readonly List<int> UsedIndices;

		private static readonly List<FieldInfo> LoadedFields;

		[SerializeField]
		private List<string> actionNames;

		[SerializeField]
		private List<string> customNames;

		[SerializeField]
		private List<bool> actionEnabled;

		[SerializeField]
		private List<bool> actionIsOpen;

		[SerializeField]
		private List<int> actionStartIndex;

		[SerializeField]
		private List<int> actionHashCodes;

		[SerializeField]
		private List<UnityEngine.Object> unityObjectParams;

		[SerializeField]
		private List<FsmGameObject> fsmGameObjectParams;

		[SerializeField]
		private List<FsmOwnerDefault> fsmOwnerDefaultParams;

		[SerializeField]
		private List<FsmAnimationCurve> animationCurveParams;

		[SerializeField]
		private List<FunctionCall> functionCallParams;

		[SerializeField]
		private List<FsmTemplateControl> fsmTemplateControlParams;

		[SerializeField]
		private List<FsmEventTarget> fsmEventTargetParams;

		[SerializeField]
		private List<FsmProperty> fsmPropertyParams;

		[SerializeField]
		private List<LayoutOption> layoutOptionParams;

		[SerializeField]
		private List<FsmString> fsmStringParams;

		[SerializeField]
		private List<FsmObject> fsmObjectParams;

		[SerializeField]
		private List<FsmVar> fsmVarParams;

		[SerializeField]
		private List<FsmArray> fsmArrayParams;

		[SerializeField]
		private List<FsmEnum> fsmEnumParams;

		[SerializeField]
		private List<FsmFloat> fsmFloatParams;

		[SerializeField]
		private List<FsmInt> fsmIntParams;

		[SerializeField]
		private List<FsmBool> fsmBoolParams;

		[SerializeField]
		private List<FsmVector2> fsmVector2Params;

		[SerializeField]
		private List<FsmVector3> fsmVector3Params;

		[SerializeField]
		private List<FsmColor> fsmColorParams;

		[SerializeField]
		private List<FsmRect> fsmRectParams;

		[SerializeField]
		private List<FsmQuaternion> fsmQuaternionParams;

		[SerializeField]
		private List<string> stringParams;

		[SerializeField]
		private List<byte> byteData;

		[NonSerialized]
		private byte[] byteDataAsArray;

		[SerializeField]
		private List<int> arrayParamSizes;

		[SerializeField]
		private List<string> arrayParamTypes;

		[SerializeField]
		private List<int> customTypeSizes;

		[SerializeField]
		private List<string> customTypeNames;

		[SerializeField]
		private List<ParamDataType> paramDataType;

		[SerializeField]
		private List<string> paramName;

		[SerializeField]
		private List<int> paramDataPos;

		[SerializeField]
		private List<int> paramByteDataSize;

		private int nextParamIndex;

		private const int MUST_BE_LESS_THAN = 100000000;

		public int ActionCount => 0;

		public List<string> ActionNames => null;

		public ActionData Copy()
		{
			return null;
		}

		private List<string> CopyStringParams()
		{
			return null;
		}

		private List<FsmFloat> CopyFsmFloatParams()
		{
			return null;
		}

		private List<FsmInt> CopyFsmIntParams()
		{
			return null;
		}

		private List<FsmBool> CopyFsmBoolParams()
		{
			return null;
		}

		private List<FsmVector2> CopyFsmVector2Params()
		{
			return null;
		}

		private List<FsmVector3> CopyFsmVector3Params()
		{
			return null;
		}

		private List<FsmColor> CopyFsmColorParams()
		{
			return null;
		}

		private List<FsmRect> CopyFsmRectParams()
		{
			return null;
		}

		private List<FsmQuaternion> CopyFsmQuaternionParams()
		{
			return null;
		}

		private List<FsmString> CopyFsmStringParams()
		{
			return null;
		}

		private List<FsmObject> CopyFsmObjectParams()
		{
			return null;
		}

		private List<FsmGameObject> CopyFsmGameObjectParams()
		{
			return null;
		}

		private List<FsmOwnerDefault> CopyFsmOwnerDefaultParams()
		{
			return null;
		}

		private List<FsmAnimationCurve> CopyAnimationCurveParams()
		{
			return null;
		}

		private List<FunctionCall> CopyFunctionCallParams()
		{
			return null;
		}

		private List<FsmTemplateControl> CopyFsmTemplateControlParams()
		{
			return null;
		}

		private List<FsmVar> CopyFsmVarParams()
		{
			return null;
		}

		private List<FsmArray> CopyFsmArrayParams()
		{
			return null;
		}

		private List<FsmEnum> CopyFsmEnumParams()
		{
			return null;
		}

		private List<FsmProperty> CopyFsmPropertyParams()
		{
			return null;
		}

		private List<FsmEventTarget> CopyFsmEventTargetParams()
		{
			return null;
		}

		private List<LayoutOption> CopyLayoutOptionParams()
		{
			return null;
		}

		private void ClearActionData()
		{
		}

		public static Type GetActionType(string actionName)
		{
			return null;
		}

		public static FieldInfo[] GetFields(Type actionType)
		{
			return null;
		}

		private static int GetActionTypeHashCode(Type actionType)
		{
			return 0;
		}

		private static int GetStableHash(string s)
		{
			return 0;
		}

		public FsmStateAction[] LoadActions(FsmState state)
		{
			return null;
		}

		public FsmStateAction CreateAction(FsmState state, int actionIndex)
		{
			return null;
		}

		public FsmStateAction CreateAction(Context context, int actionIndex)
		{
			return null;
		}

		public void InitEditorData(FsmState state)
		{
		}

		private void InitEditorData(FsmStateAction action, int actionIndex)
		{
		}

		private string GetStringParam(int paramIndex)
		{
			return null;
		}

		private void LoadActionField(Fsm fsm, object obj, FieldInfo field, int paramIndex)
		{
		}

		private void LoadArrayElement(Fsm fsm, Array field, Type fieldType, int elementIndex, int paramIndex)
		{
		}

		public static void LogError(Context context, string error)
		{
		}

		private static void LogInfo(Context context, string info)
		{
		}

		private FsmFloat GetFsmFloat(Fsm fsm, int paramIndex)
		{
			return null;
		}

		private FsmInt GetFsmInt(Fsm fsm, int paramIndex)
		{
			return null;
		}

		private FsmBool GetFsmBool(Fsm fsm, int paramIndex)
		{
			return null;
		}

		private FsmVector2 GetFsmVector2(Fsm fsm, int paramIndex)
		{
			return null;
		}

		private FsmVector3 GetFsmVector3(Fsm fsm, int paramIndex)
		{
			return null;
		}

		private FsmColor GetFsmColor(Fsm fsm, int paramIndex)
		{
			return null;
		}

		private FsmAnimationCurve GetFsmAnimationCurve(int paramIndex)
		{
			return null;
		}

		private FsmRect GetFsmRect(Fsm fsm, int paramIndex)
		{
			return null;
		}

		private FsmQuaternion GetFsmQuaternion(Fsm fsm, int paramIndex)
		{
			return null;
		}

		private FsmGameObject GetFsmGameObject(Fsm fsm, int paramIndex)
		{
			return null;
		}

		private FsmTemplateControl GetFsmTemplateControl(Fsm fsm, int paramIndex)
		{
			return null;
		}

		private FsmVar GetFsmVar(Fsm fsm, int paramIndex)
		{
			return null;
		}

		private FsmArray GetFsmArray(Fsm fsm, int paramIndex)
		{
			return null;
		}

		private FsmEnum GetFsmEnum(Fsm fsm, int paramIndex)
		{
			return null;
		}

		private FunctionCall GetFunctionCall(Fsm fsm, int paramIndex)
		{
			return null;
		}

		private FsmProperty GetFsmProperty(Fsm fsm, int paramIndex)
		{
			return null;
		}

		private FsmEventTarget GetFsmEventTarget(Fsm fsm, int paramIndex)
		{
			return null;
		}

		private LayoutOption GetLayoutOption(Fsm fsm, int paramIndex)
		{
			return null;
		}

		private FsmOwnerDefault GetFsmOwnerDefault(Fsm fsm, int paramIndex)
		{
			return null;
		}

		private FsmString GetFsmString(Fsm fsm, int paramIndex)
		{
			return null;
		}

		private FsmObject GetFsmObject(Fsm fsm, int paramIndex)
		{
			return null;
		}

		private FsmMaterial GetFsmMaterial(Fsm fsm, int paramIndex)
		{
			return null;
		}

		private FsmTexture GetFsmTexture(Fsm fsm, int paramIndex)
		{
			return null;
		}

		public bool UsesDataVersion2()
		{
			return false;
		}

		private static string TryFixActionName(string actionName)
		{
			return null;
		}

		private FsmStateAction TryRecoverAction(Context context, Type actionType, FsmStateAction action, int actionIndex)
		{
			return null;
		}

		private FieldInfo FindField(Type actionType, int paramIndex)
		{
			return null;
		}

		private static FieldInfo FindField(Type actionType, string name)
		{
			return null;
		}

		private bool TryConvertParameter(Context context, FsmStateAction action, FieldInfo field, int paramIndex)
		{
			return false;
		}

		private bool TryConvertArrayElement(Fsm fsm, Array field, ParamDataType originalParamType, ParamDataType currentParamType, int elementIndex, int paramIndex)
		{
			return false;
		}

		private object ConvertType(Fsm fsm, ParamDataType originalParamType, ParamDataType currentParamType, int paramIndex)
		{
			return null;
		}

		public void SaveActions(FsmState state, FsmStateAction[] actions)
		{
		}

		private void SaveAction(Fsm fsm, FsmStateAction action)
		{
		}

		private void SaveActionField(Fsm fsm, Type fieldType, object obj)
		{
		}

		private void AddByteData(ICollection<byte> bytes)
		{
		}

		private void SaveString(string str)
		{
		}

		private static ParamDataType GetParamDataType(Type type)
		{
			return default(ParamDataType);
		}

		[Conditional("DEBUG_LOG")]
		private static void DebugLog(object message, LogColor logColor = LogColor.None)
		{
		}

		[Conditional("DEBUG_LOG")]
		private static void DebugLogWarning(object message)
		{
		}
	}
}
