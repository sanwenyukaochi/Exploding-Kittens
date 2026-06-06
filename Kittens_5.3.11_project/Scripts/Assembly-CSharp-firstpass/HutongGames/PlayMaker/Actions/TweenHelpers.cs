using HutongGames.PlayMaker.TweenEnums;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	public static class TweenHelpers
	{
		public static Quaternion GetTargetRotation(RotationOptions option, Transform owner, Transform target, Vector3 rotation)
		{
			return default(Quaternion);
		}

		public static bool GetTargetRotation(RotationOptions option, Transform owner, FsmVector3 rotation, FsmGameObject target, out Quaternion targetRotation)
		{
			targetRotation = default(Quaternion);
			return false;
		}

		private static bool CanEditTargetRotation(RotationOptions option, NamedVariable rotation, FsmGameObject target)
		{
			return false;
		}

		public static Vector3 GetTargetScale(ScaleOptions option, Transform owner, Transform target, Vector3 scale)
		{
			return default(Vector3);
		}

		public static bool GetTargetPosition(PositionOptions option, Transform owner, FsmVector3 position, FsmGameObject target, out Vector3 targetPosition)
		{
			targetPosition = default(Vector3);
			return false;
		}

		private static bool IsValidTargetPosition(PositionOptions option, NamedVariable position, FsmGameObject target)
		{
			return false;
		}

		public static bool CanEditTargetPosition(PositionOptions option, NamedVariable position, FsmGameObject target)
		{
			return false;
		}

		public static Vector3 GetTargetPosition(PositionOptions option, Transform owner, Transform target, Vector3 position)
		{
			return default(Vector3);
		}

		public static Vector3 GetUiTargetPosition(UiPositionOptions option, RectTransform owner, Transform target, Vector3 position)
		{
			return default(Vector3);
		}

		public static Rect GetWorldRect(RectTransform rectTransform)
		{
			return default(Rect);
		}
	}
}
