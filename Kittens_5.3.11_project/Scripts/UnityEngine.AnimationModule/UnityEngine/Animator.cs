using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("Modules/Animation/ScriptBindings/AnimatorControllerParameter.bindings.h")]
	[NativeHeader("Modules/Animation/Animator.h")]
	[UsedByNativeCode]
	[NativeHeader("Modules/Animation/ScriptBindings/Animator.bindings.h")]
	public class Animator : Behaviour
	{
		public bool isHuman
		{
			[NativeMethod("IsHuman")]
			get
			{
				return false;
			}
		}

		public float humanScale => 0f;

		public Vector3 deltaPosition => default(Vector3);

		public Quaternion deltaRotation => default(Quaternion);

		public Vector3 rootPosition
		{
			[NativeMethod("GetAvatarPosition")]
			get
			{
				return default(Vector3);
			}
		}

		public Quaternion rootRotation
		{
			[NativeMethod("GetAvatarRotation")]
			get
			{
				return default(Quaternion);
			}
		}

		public bool applyRootMotion
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float gravityWeight => 0f;

		public Vector3 bodyPosition
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		internal Vector3 bodyPositionInternal
		{
			[NativeMethod("GetBodyPosition")]
			get
			{
				return default(Vector3);
			}
			[NativeMethod("SetBodyPosition")]
			set
			{
			}
		}

		public Quaternion bodyRotation
		{
			get
			{
				return default(Quaternion);
			}
			set
			{
			}
		}

		internal Quaternion bodyRotationInternal
		{
			[NativeMethod("GetBodyRotation")]
			get
			{
				return default(Quaternion);
			}
			[NativeMethod("SetBodyRotation")]
			set
			{
			}
		}

		public bool stabilizeFeet
		{
			set
			{
			}
		}

		public int layerCount => 0;

		public float feetPivotActive
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float pivotWeight => 0f;

		public Vector3 pivotPosition => default(Vector3);

		public bool isMatchingTarget
		{
			[NativeMethod("IsMatchingTarget")]
			get
			{
				return false;
			}
		}

		public float speed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Vector3 targetPosition => default(Vector3);

		public Quaternion targetRotation => default(Quaternion);

		public AnimatorCullingMode cullingMode
		{
			get
			{
				return default(AnimatorCullingMode);
			}
			set
			{
			}
		}

		public float playbackTime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float recorderStartTime => 0f;

		public float recorderStopTime => 0f;

		public bool hasBoundPlayables
		{
			[NativeMethod("HasBoundPlayables")]
			get
			{
				return false;
			}
		}

		public Avatar avatar => null;

		public bool layersAffectMassCenter
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float leftFeetBottomHeight => 0f;

		public float rightFeetBottomHeight => 0f;

		public bool logWarnings => false;

		public float GetFloat(string name)
		{
			return 0f;
		}

		public float GetFloat(int id)
		{
			return 0f;
		}

		public void SetFloat(string name, float value)
		{
		}

		public void SetFloat(int id, float value)
		{
		}

		public void SetFloat(int id, float value, float dampTime, float deltaTime)
		{
		}

		public bool GetBool(string name)
		{
			return false;
		}

		public bool GetBool(int id)
		{
			return false;
		}

		public void SetBool(string name, bool value)
		{
		}

		public void SetBool(int id, bool value)
		{
		}

		public int GetInteger(string name)
		{
			return 0;
		}

		public int GetInteger(int id)
		{
			return 0;
		}

		public void SetInteger(string name, int value)
		{
		}

		public void SetInteger(int id, int value)
		{
		}

		public void SetTrigger(string name)
		{
		}

		public void ResetTrigger(string name)
		{
		}

		public bool IsParameterControlledByCurve(string name)
		{
			return false;
		}

		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		private Vector3 GetGoalPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		public void SetIKPosition(AvatarIKGoal goal, Vector3 goalPosition)
		{
		}

		private void SetGoalPosition(AvatarIKGoal goal, Vector3 goalPosition)
		{
		}

		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		private Quaternion GetGoalRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		public void SetIKRotation(AvatarIKGoal goal, Quaternion goalRotation)
		{
		}

		private void SetGoalRotation(AvatarIKGoal goal, Quaternion goalRotation)
		{
		}

		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return 0f;
		}

		private float GetGoalWeightPosition(AvatarIKGoal goal)
		{
			return 0f;
		}

		public void SetIKPositionWeight(AvatarIKGoal goal, float value)
		{
		}

		private void SetGoalWeightPosition(AvatarIKGoal goal, float value)
		{
		}

		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return 0f;
		}

		private float GetGoalWeightRotation(AvatarIKGoal goal)
		{
			return 0f;
		}

		public void SetIKRotationWeight(AvatarIKGoal goal, float value)
		{
		}

		private void SetGoalWeightRotation(AvatarIKGoal goal, float value)
		{
		}

		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[NativeMethod("SetLookAtPosition")]
		private void SetLookAtPositionInternal(Vector3 lookAtPosition)
		{
		}

		public void SetLookAtWeight(float weight)
		{
		}

		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		public void SetLookAtWeight(float weight, [DefaultValue("0.0f")] float bodyWeight, [DefaultValue("1.0f")] float headWeight, [DefaultValue("0.0f")] float eyesWeight, [DefaultValue("0.5f")] float clampWeight)
		{
		}

		[NativeMethod("SetLookAtWeight")]
		private void SetLookAtWeightInternal(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		public string GetLayerName(int layerIndex)
		{
			return null;
		}

		public float GetLayerWeight(int layerIndex)
		{
			return 0f;
		}

		public void SetLayerWeight(int layerIndex, float weight)
		{
		}

		private void GetAnimatorStateInfo(int layerIndex, StateInfoIndex stateInfoIndex, out AnimatorStateInfo info)
		{
			info = default(AnimatorStateInfo);
		}

		public AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex)
		{
			return default(AnimatorStateInfo);
		}

		public AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex)
		{
			return default(AnimatorStateInfo);
		}

		private void GetAnimatorTransitionInfo(int layerIndex, out AnimatorTransitionInfo info)
		{
			info = default(AnimatorTransitionInfo);
		}

		public AnimatorTransitionInfo GetAnimatorTransitionInfo(int layerIndex)
		{
			return default(AnimatorTransitionInfo);
		}

		[FreeFunction(Name = "AnimatorBindings::GetCurrentAnimatorClipInfo", HasExplicitThis = true)]
		public AnimatorClipInfo[] GetCurrentAnimatorClipInfo(int layerIndex)
		{
			return null;
		}

		[FreeFunction(Name = "AnimatorBindings::GetNextAnimatorClipInfo", HasExplicitThis = true)]
		public AnimatorClipInfo[] GetNextAnimatorClipInfo(int layerIndex)
		{
			return null;
		}

		public bool IsInTransition(int layerIndex)
		{
			return false;
		}

		private void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, int targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch)
		{
		}

		public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, [DefaultValue("1")] float targetNormalizedTime)
		{
		}

		public void InterruptMatchTarget([DefaultValue("true")] bool completeMatch)
		{
		}

		public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset)
		{
		}

		public void CrossFade(string stateName, float normalizedTransitionDuration, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float normalizedTimeOffset, [DefaultValue("0.0f")] float normalizedTransitionTime)
		{
		}

		[FreeFunction(Name = "AnimatorBindings::CrossFade", HasExplicitThis = true)]
		public void CrossFade(int stateHashName, float normalizedTransitionDuration, [DefaultValue("-1")] int layer, [DefaultValue("0.0f")] float normalizedTimeOffset, [DefaultValue("0.0f")] float normalizedTransitionTime)
		{
		}

		public void Play(string stateName, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float normalizedTime)
		{
		}

		[FreeFunction(Name = "AnimatorBindings::Play", HasExplicitThis = true)]
		public void Play(int stateNameHash, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float normalizedTime)
		{
		}

		public void SetTarget(AvatarTarget targetIndex, float targetNormalizedTime)
		{
		}

		public Transform GetBoneTransform(HumanBodyBones humanBoneId)
		{
			return null;
		}

		[NativeMethod("GetBoneTransform")]
		internal Transform GetBoneTransformInternal(int humanBoneId)
		{
			return null;
		}

		public void StartPlayback()
		{
		}

		public void StopPlayback()
		{
		}

		public void StartRecording(int frameCount)
		{
		}

		public void StopRecording()
		{
		}

		private float GetRecorderStartTime()
		{
			return 0f;
		}

		private float GetRecorderStopTime()
		{
			return 0f;
		}

		[NativeMethod(Name = "ScriptingStringToCRC32", IsThreadSafe = true)]
		public static int StringToHash(string name)
		{
			return 0;
		}

		private void CheckIfInIKPass()
		{
		}

		private bool IsInIKPass()
		{
			return false;
		}

		[FreeFunction(Name = "AnimatorBindings::SetFloatString", HasExplicitThis = true)]
		private void SetFloatString(string name, float value)
		{
		}

		[FreeFunction(Name = "AnimatorBindings::SetFloatID", HasExplicitThis = true)]
		private void SetFloatID(int id, float value)
		{
		}

		[FreeFunction(Name = "AnimatorBindings::GetFloatString", HasExplicitThis = true)]
		private float GetFloatString(string name)
		{
			return 0f;
		}

		[FreeFunction(Name = "AnimatorBindings::GetFloatID", HasExplicitThis = true)]
		private float GetFloatID(int id)
		{
			return 0f;
		}

		[FreeFunction(Name = "AnimatorBindings::SetBoolString", HasExplicitThis = true)]
		private void SetBoolString(string name, bool value)
		{
		}

		[FreeFunction(Name = "AnimatorBindings::SetBoolID", HasExplicitThis = true)]
		private void SetBoolID(int id, bool value)
		{
		}

		[FreeFunction(Name = "AnimatorBindings::GetBoolString", HasExplicitThis = true)]
		private bool GetBoolString(string name)
		{
			return false;
		}

		[FreeFunction(Name = "AnimatorBindings::GetBoolID", HasExplicitThis = true)]
		private bool GetBoolID(int id)
		{
			return false;
		}

		[FreeFunction(Name = "AnimatorBindings::SetIntegerString", HasExplicitThis = true)]
		private void SetIntegerString(string name, int value)
		{
		}

		[FreeFunction(Name = "AnimatorBindings::SetIntegerID", HasExplicitThis = true)]
		private void SetIntegerID(int id, int value)
		{
		}

		[FreeFunction(Name = "AnimatorBindings::GetIntegerString", HasExplicitThis = true)]
		private int GetIntegerString(string name)
		{
			return 0;
		}

		[FreeFunction(Name = "AnimatorBindings::GetIntegerID", HasExplicitThis = true)]
		private int GetIntegerID(int id)
		{
			return 0;
		}

		[FreeFunction(Name = "AnimatorBindings::SetTriggerString", HasExplicitThis = true)]
		private void SetTriggerString(string name)
		{
		}

		[FreeFunction(Name = "AnimatorBindings::ResetTriggerString", HasExplicitThis = true)]
		private void ResetTriggerString(string name)
		{
		}

		[FreeFunction(Name = "AnimatorBindings::IsParameterControlledByCurveString", HasExplicitThis = true)]
		private bool IsParameterControlledByCurveString(string name)
		{
			return false;
		}

		[FreeFunction(Name = "AnimatorBindings::SetFloatIDDamp", HasExplicitThis = true)]
		private void SetFloatIDDamp(int id, float value, float dampTime, float deltaTime)
		{
		}

		[NativeMethod("UpdateWithDelta")]
		public void Update(float deltaTime)
		{
		}

		[SpecialName]
		private void get_deltaPosition_Injected(out Vector3 ret)
		{
			ret = default(Vector3);
		}

		[SpecialName]
		private void get_deltaRotation_Injected(out Quaternion ret)
		{
			ret = default(Quaternion);
		}

		[SpecialName]
		private void get_rootPosition_Injected(out Vector3 ret)
		{
			ret = default(Vector3);
		}

		[SpecialName]
		private void get_rootRotation_Injected(out Quaternion ret)
		{
			ret = default(Quaternion);
		}

		[SpecialName]
		private void get_bodyPositionInternal_Injected(out Vector3 ret)
		{
			ret = default(Vector3);
		}

		[SpecialName]
		private void set_bodyPositionInternal_Injected(ref Vector3 value)
		{
		}

		[SpecialName]
		private void get_bodyRotationInternal_Injected(out Quaternion ret)
		{
			ret = default(Quaternion);
		}

		[SpecialName]
		private void set_bodyRotationInternal_Injected(ref Quaternion value)
		{
		}

		private void GetGoalPosition_Injected(AvatarIKGoal goal, out Vector3 ret)
		{
			ret = default(Vector3);
		}

		private void SetGoalPosition_Injected(AvatarIKGoal goal, ref Vector3 goalPosition)
		{
		}

		private void GetGoalRotation_Injected(AvatarIKGoal goal, out Quaternion ret)
		{
			ret = default(Quaternion);
		}

		private void SetGoalRotation_Injected(AvatarIKGoal goal, ref Quaternion goalRotation)
		{
		}

		private void SetLookAtPositionInternal_Injected(ref Vector3 lookAtPosition)
		{
		}

		[SpecialName]
		private void get_pivotPosition_Injected(out Vector3 ret)
		{
			ret = default(Vector3);
		}

		private void MatchTarget_Injected(ref Vector3 matchPosition, ref Quaternion matchRotation, int targetBodyPart, ref MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch)
		{
		}

		[SpecialName]
		private void get_targetPosition_Injected(out Vector3 ret)
		{
			ret = default(Vector3);
		}

		[SpecialName]
		private void get_targetRotation_Injected(out Quaternion ret)
		{
			ret = default(Quaternion);
		}
	}
}
