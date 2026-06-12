using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

namespace HutongGames.PlayMaker
{
	public static class FsmUtility
	{
		public static class BitConverter
		{
			public static int ToInt32(byte[] value, int startIndex)
			{
				return 0;
			}

			public static float ToSingle(byte[] value, int startIndex)
			{
				return 0f;
			}

			public static bool ToBoolean(byte[] value, int startIndex)
			{
				return false;
			}

			public static byte[] GetBytes(bool value)
			{
				return null;
			}

			public static byte[] GetBytes(int value)
			{
				return null;
			}

			public static byte[] GetBytes(float value)
			{
				return null;
			}
		}

		private static UTF8Encoding encoding;

		public static UTF8Encoding Encoding => null;

		[Obsolete("Use VariableType property in NamedVariable")]
		public static VariableType GetVariableType(INamedVariable variable)
		{
			return default(VariableType);
		}

		public static Type GetVariableRealType(VariableType variableType)
		{
			return null;
		}

		public static object GetEnum(Type enumType, int enumValue)
		{
			return null;
		}

		public static ICollection<byte> FsmEventToByteArray(FsmEvent fsmEvent)
		{
			return null;
		}

		public static ICollection<byte> FsmFloatToByteArray(FsmFloat fsmFloat)
		{
			return null;
		}

		public static ICollection<byte> FsmIntToByteArray(FsmInt fsmInt)
		{
			return null;
		}

		public static ICollection<byte> FsmBoolToByteArray(FsmBool fsmBool)
		{
			return null;
		}

		public static ICollection<byte> FsmVector2ToByteArray(FsmVector2 fsmVector2)
		{
			return null;
		}

		public static ICollection<byte> FsmVector3ToByteArray(FsmVector3 fsmVector3)
		{
			return null;
		}

		public static ICollection<byte> FsmRectToByteArray(FsmRect fsmRect)
		{
			return null;
		}

		public static ICollection<byte> FsmQuaternionToByteArray(FsmQuaternion fsmQuaternion)
		{
			return null;
		}

		public static ICollection<byte> FsmColorToByteArray(FsmColor fsmColor)
		{
			return null;
		}

		public static ICollection<byte> ColorToByteArray(Color color)
		{
			return null;
		}

		public static ICollection<byte> Vector2ToByteArray(Vector2 vector2)
		{
			return null;
		}

		public static ICollection<byte> Vector3ToByteArray(Vector3 vector3)
		{
			return null;
		}

		public static ICollection<byte> Vector4ToByteArray(Vector4 vector4)
		{
			return null;
		}

		public static ICollection<byte> RectToByteArray(Rect rect)
		{
			return null;
		}

		public static ICollection<byte> QuaternionToByteArray(Quaternion quaternion)
		{
			return null;
		}

		public static byte[] StringToByteArray(string str)
		{
			return null;
		}

		public static string ByteArrayToString(byte[] bytes)
		{
			return null;
		}

		public static string ByteArrayToString(byte[] bytes, int startIndex, int count)
		{
			return null;
		}

		public static FsmEvent ByteArrayToFsmEvent(byte[] bytes, int startIndex, int size)
		{
			return null;
		}

		public static FsmFloat ByteArrayToFsmFloat(Fsm fsm, byte[] bytes, int startIndex, int totalLength)
		{
			return null;
		}

		public static FsmInt ByteArrayToFsmInt(Fsm fsm, byte[] bytes, int startIndex, int totalLength)
		{
			return null;
		}

		public static FsmBool ByteArrayToFsmBool(Fsm fsm, byte[] bytes, int startIndex, int totalLength)
		{
			return null;
		}

		public static Color ByteArrayToColor(byte[] bytes, int startIndex)
		{
			return default(Color);
		}

		public static Vector2 ByteArrayToVector2(byte[] bytes, int startIndex)
		{
			return default(Vector2);
		}

		public static FsmVector2 ByteArrayToFsmVector2(Fsm fsm, byte[] bytes, int startIndex, int totalLength)
		{
			return null;
		}

		public static Vector3 ByteArrayToVector3(byte[] bytes, int startIndex)
		{
			return default(Vector3);
		}

		public static FsmVector3 ByteArrayToFsmVector3(Fsm fsm, byte[] bytes, int startIndex, int totalLength)
		{
			return null;
		}

		public static FsmRect ByteArrayToFsmRect(Fsm fsm, byte[] bytes, int startIndex, int totalLength)
		{
			return null;
		}

		public static FsmQuaternion ByteArrayToFsmQuaternion(Fsm fsm, byte[] bytes, int startIndex, int totalLength)
		{
			return null;
		}

		public static FsmColor ByteArrayToFsmColor(Fsm fsm, byte[] bytes, int startIndex, int totalLength)
		{
			return null;
		}

		public static Vector4 ByteArrayToVector4(byte[] bytes, int startIndex)
		{
			return default(Vector4);
		}

		public static Rect ByteArrayToRect(byte[] bytes, int startIndex)
		{
			return default(Rect);
		}

		public static Quaternion ByteArrayToQuaternion(byte[] bytes, int startIndex)
		{
			return default(Quaternion);
		}

		private static byte[] ReadToEnd(Stream stream)
		{
			return null;
		}

		public static string StripNamespace(string name)
		{
			return null;
		}

		public static string GetPath(FsmState state)
		{
			return null;
		}

		public static string GetPath(FsmState state, FsmStateAction action)
		{
			return null;
		}

		public static string GetPath(FsmState state, FsmStateAction action, string parameter)
		{
			return null;
		}

		public static string GetFullFsmLabel(Fsm fsm)
		{
			return null;
		}

		public static string GetFullFsmLabel(PlayMakerFSM fsm)
		{
			return null;
		}

		public static string GetFsmLabel(Fsm fsm)
		{
			return null;
		}

		public static UnityEngine.Object GetOwner(Fsm fsm)
		{
			return null;
		}

		public static string GetFullPath(Fsm fsm)
		{
			return null;
		}

		public static string GetFullPath(GameObject go, string seperator = "/")
		{
			return null;
		}
	}
}
