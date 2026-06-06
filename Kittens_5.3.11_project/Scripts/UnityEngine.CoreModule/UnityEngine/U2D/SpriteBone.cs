using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.U2D
{
	[Serializable]
	[MovedFrom("UnityEngine.Experimental.U2D")]
	[NativeHeader("Runtime/2D/Common/SpriteDataAccess.h")]
	[RequiredByNativeCode]
	[NativeType(CodegenOptions.Custom, "ScriptingSpriteBone")]
	[NativeHeader("Runtime/2D/Common/SpriteDataMarshalling.h")]
	public struct SpriteBone
	{
		[NativeName("name")]
		[SerializeField]
		private string m_Name;

		[SerializeField]
		[NativeName("guid")]
		private string m_Guid;

		[SerializeField]
		[NativeName("position")]
		private Vector3 m_Position;

		[SerializeField]
		[NativeName("rotation")]
		private Quaternion m_Rotation;

		[NativeName("length")]
		[SerializeField]
		private float m_Length;

		[NativeName("parentId")]
		[SerializeField]
		private int m_ParentId;

		[NativeName("color")]
		[SerializeField]
		private Color32 m_Color;
	}
}
